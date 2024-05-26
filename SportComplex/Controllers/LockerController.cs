using Microsoft.AspNetCore.Mvc;
using SportComplex.Data;
using SportComplex.Dto;
using SportComplex.Models;
using System.Net;
using Microsoft.EntityFrameworkCore;

namespace SportComplex.Controllers
{
    public class LockerController:Controller
    {
        private readonly ApplicationDbContext _context;

        public LockerController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult> Index()
        {
            var lockers = await _context.Lockers.ToListAsync();
            return View(lockers);
        }

        [HttpPost]
        public async Task<ActionResult> Create([FromBody] CreateLockerDto dto)
        {
            var locker = new Locker()
            {
                AssignedTo = dto.AssignedTo,
                IsAvailable = dto.IsAvailable,
                Number = dto.Number,
                ReservationEndTime = dto.ReservationEndTime,
                ReservationStartTime = dto.ReservationStartTime
            };
            await _context.Lockers.AddAsync(locker);
            await _context.SaveChangesAsync();
            return View(locker);
        }

        public async Task<ActionResult> Edit([FromRoute] int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var locker = await _context.Lockers.FirstOrDefaultAsync(c => c.Id == id);
            if (locker == null)
            {
                return HttpNotFound();
            }
            return View(locker);
        }

        [HttpPost, ActionName("Edit")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> EditLocker([FromRoute] int id, [FromBody] CreateLockerDto dto)
        {
            var locker = await _context.Lockers.FirstOrDefaultAsync(c => c.Id == id);
            if (locker is null)
                throw new Exception("اتاق یافت نشد");
            locker.ReservationStartTime = dto.ReservationStartTime;
            locker.ReservationEndTime = dto.ReservationEndTime;
            locker.AssignedTo=dto.AssignedTo;
            locker.Number=dto.Number;

            _context.Lockers.Update(locker);
            await _context.SaveChangesAsync();
            return View(locker);
        }

        public async Task<ActionResult> Delete([FromRoute] int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var locker = await _context.Lockers.FirstOrDefaultAsync(c => c.Id == id);
            if (locker == null)
            {
                return HttpNotFound();
            }
            return View(locker);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteLockerRoom([FromRoute] int id)
        {
            var locker = await _context.Lockers.FirstOrDefaultAsync(c => c.Id == id);
            if (locker is null)
                throw new Exception("اتاق یافت نشد");
            _context.Lockers.Remove(locker);
            await _context.SaveChangesAsync();
            return View(locker);
        }
    }
}
