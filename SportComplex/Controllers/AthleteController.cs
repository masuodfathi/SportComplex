using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SportComplex.Data;
using SportComplex.Dto;
using SportComplex.Models;
using System.Net;
using System.Reflection;

namespace SportComplex.Controllers
{
    public class AthleteController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AthleteController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult> Index()
        {
            var athletes = await _context.Athletes.ToListAsync();
            return View(athletes);
        }

        [HttpPost]
        public async Task<ActionResult> Create([FromBody] CreateAthleteDto dto)
        {
            var athletes = new Athlete()
            {
                SportId = dto.SportId,
                PhoneNumber = dto.PhoneNumber,
                LastName = dto.LastName,
                Gender = dto.Gender,
                FirstName = dto.FirstName,
                Email = dto.Email,
                DateOfBirth = dto.DateOfBirth,

            };
            await _context.Athletes.AddAsync(athletes);
            await _context.SaveChangesAsync();
            return View(athletes);
        }

        public async Task<ActionResult> Edit([FromRoute] int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var athlete = await _context.Athletes.FirstOrDefaultAsync(c => c.Id == id);
            if (athlete == null)
            {
                return HttpNotFound();
            }
            return View(athlete);
        }

        [HttpPost, ActionName("Edit")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> EditLockerRoom([FromRoute] int id, [FromBody] CreateAthleteDto dto)
        {
            var athlete = await _context.Athletes.FirstOrDefaultAsync(c => c.Id == id);
            if (athlete is null)
                throw new Exception("ورزشکار یافت نشد");
            athlete.Email = dto.Email;
            athlete.FirstName = dto.FirstName;
            athlete.PhoneNumber = dto.PhoneNumber;
            athlete.LastName = dto.LastName;
            athlete.DateOfBirth = dto.DateOfBirth;
            athlete.Gender = dto.Gender;
            athlete.SportId = dto.SportId;

            _context.Athletes.Update(athlete);
            await _context.SaveChangesAsync();
            return View(athlete);
        }

        public async Task<ActionResult> Delete([FromRoute] int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var athlete = await _context.Athletes.FirstOrDefaultAsync(c => c.Id == id);
            if (athlete == null)
            {
                return HttpNotFound();
            }
            return View(athlete);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteLockerRoom([FromRoute] int id)
        {
            var athlete = await _context.Athletes.FirstOrDefaultAsync(c => c.Id == id);
            if (athlete is null)
                throw new Exception("ورزشکار یافت نشد");
            _context.Athletes.Remove(athlete);
            await _context.SaveChangesAsync();
            return View(athlete);
        }

    }
}
