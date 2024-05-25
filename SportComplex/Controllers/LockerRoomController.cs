using Microsoft.AspNetCore.Mvc;
using System;
using System.Text;
using SportComplex.Data;
using Microsoft.EntityFrameworkCore;
using SportComplex.Dto;
using SportComplex.Models;
using System.Net;

namespace SportComplex.Controllers
{
    public class LockerRoomController: Controller
    {
        private readonly ApplicationDbContext _context;

        public LockerRoomController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult> Index()
        {
            var lockerRooms = await _context.LockerRooms.ToListAsync();
            return View(lockerRooms);
        }

        [HttpPost]
        public async Task<ActionResult> Create([FromBody]CreateLockerRoomDto dto)
        {
            var lockerRoom = new LockerRoom()
            {
                Capacity = dto.Capacity,
                Name = dto.Name,
                Lockers = dto.Lockers.Select(c => new Locker()
                {
                    AssignedTo = c.AssignedTo,
                    IsAvailable = c.IsAvailable,
                    Number = c.Number,
                    ReservationEndTime = c.ReservationEndTime,
                    ReservationStartTime = c.ReservationStartTime,
                    
                }).ToList()
            };
            await _context.LockerRooms.AddAsync(lockerRoom);
            await _context.SaveChangesAsync();
            return View(lockerRoom);
        }

        public async Task<ActionResult> Edit([FromRoute]int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var lockerRoom = await _context.LockerRooms.FirstOrDefaultAsync(c => c.Id == id);
            if (lockerRoom == null)
            {
                return HttpNotFound();
            }
            return View(lockerRoom);
        }

        [HttpPost, ActionName("Edit")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> EditLockerRoom([FromRoute] int id, [FromBody] EditLockerRoomDto dto)
        {
            var lockerRoom = await _context.LockerRooms.FirstOrDefaultAsync(c => c.Id == id);
            if (lockerRoom is null)
                throw new Exception("رختکن یافت نشد");
            lockerRoom.Name=dto.Name;
            lockerRoom.Capacity=dto.Capacity;
            lockerRoom.Lockers=dto.Lockers.Select(c=>new Locker
            {
                AssignedTo = c.AssignedTo,
                IsAvailable = c.IsAvailable,
                Number = c.Number,
                ReservationEndTime = c.ReservationEndTime,
                ReservationStartTime = c.ReservationStartTime,
            }).ToList();

            _context.LockerRooms.Update(lockerRoom);
            await _context.SaveChangesAsync();
            return View(lockerRoom);
        }

        public async  Task<ActionResult> Delete([FromRoute]int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var lockerRoom = await _context.LockerRooms.FirstOrDefaultAsync(c => c.Id == id);
            if (lockerRoom == null)
            {
                return HttpNotFound();
            }
            return View(lockerRoom);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteLockerRoom([FromRoute] int id)
        {
            var lockerRoom = await _context.LockerRooms.FirstOrDefaultAsync(c => c.Id == id);
            if (lockerRoom is null)
                throw new Exception("رختکن یافت نشد");
            _context.LockerRooms.Remove(lockerRoom);
            await  _context.SaveChangesAsync();
            return View(lockerRoom);
        }

    }
}
