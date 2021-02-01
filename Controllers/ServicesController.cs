using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using GymManagementSystem.Data;
using GymManagementSystem.Models;

namespace GymManagementSystem.Controllers
{
    [Authorize]
    public class ServicesController : Controller
    {
        private readonly GymContext _context;

        public ServicesController(GymContext context)
        {
            _context = context;
        }

        // GET: Services
        public async Task<IActionResult> Index()
        {
            var gymContext = _context.Services.Include(s => s.Member).Include(s => s.Staff);
            return View(await gymContext.ToListAsync());
        }

        // GET: Services/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var service = await _context.Services
                .Include(s => s.Member)
                .Include(s => s.Staff)
                .FirstOrDefaultAsync(m => m.Services_Id == id);
            if (service == null)
            {
                return NotFound();
            }

            return View(service);
        }

        // GET: Services/Create
        public IActionResult Create()
        {
            ViewData["Member_Id"] = new SelectList(_context.Members, "Member_Id", "Member_Name");
            ViewData["Staff_Id"] = new SelectList(_context.Staffs, "Staff_id", "Staff_Name");
            return View();
        }

        // POST: Services/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Services_Id,Member_Id,Staff_Id,Name,Description,Price")] Service service)
        {
            if (ModelState.IsValid)
            {
                _context.Add(service);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Member_Id"] = new SelectList(_context.Members, "Member_Id", "Email", service.Member_Id);
            ViewData["Staff_Id"] = new SelectList(_context.Staffs, "Staff_id", "Email", service.Staff_Id);
            return View(service);
        }

        // GET: Services/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var service = await _context.Services.FindAsync(id);
            if (service == null)
            {
                return NotFound();
            }
            ViewData["Member_Id"] = new SelectList(_context.Members, "Member_Id", "Member_Name", service.Member_Id);
            ViewData["Staff_Id"] = new SelectList(_context.Staffs, "Staff_id", "Staff_Name", service.Staff_Id);
            return View(service);
        }

        // POST: Services/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Services_Id,Member_Id,Staff_Id,Name,Description,Price")] Service service)
        {
            if (id != service.Services_Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(service);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ServiceExists(service.Services_Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["Member_Id"] = new SelectList(_context.Members, "Member_Id", "Email", service.Member_Id);
            ViewData["Staff_Id"] = new SelectList(_context.Staffs, "Staff_id", "Email", service.Staff_Id);
            return View(service);
        }

        // GET: Services/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var service = await _context.Services
                .Include(s => s.Member)
                .Include(s => s.Staff)
                .FirstOrDefaultAsync(m => m.Services_Id == id);
            if (service == null)
            {
                return NotFound();
            }

            return View(service);
        }

        // POST: Services/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var service = await _context.Services.FindAsync(id);
            _context.Services.Remove(service);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ServiceExists(int id)
        {
            return _context.Services.Any(e => e.Services_Id == id);
        }
    }
}
