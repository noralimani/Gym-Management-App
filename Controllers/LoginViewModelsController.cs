using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GymManagementSystem.Data;
using GymManagementSystem.Models;

namespace GymManagementSystem.Controllers
{
    public class LoginViewModelsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public LoginViewModelsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: LoginViewModels
        public async Task<IActionResult> Index()
        {
            return View(await _context.LoginViewModel.ToListAsync());
        }

        // GET: LoginViewModels/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var loginViewModel = await _context.LoginViewModel
                .FirstOrDefaultAsync(m => m.UserName == id);
            if (loginViewModel == null)
            {
                return NotFound();
            }

            return View(loginViewModel);
        }

        // GET: LoginViewModels/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: LoginViewModels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("UserName,Password,ReturnUrl")] LoginViewModel loginViewModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(loginViewModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(loginViewModel);
        }

        // GET: LoginViewModels/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var loginViewModel = await _context.LoginViewModel.FindAsync(id);
            if (loginViewModel == null)
            {
                return NotFound();
            }
            return View(loginViewModel);
        }

        // POST: LoginViewModels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("UserName,Password,ReturnUrl")] LoginViewModel loginViewModel)
        {
            if (id != loginViewModel.UserName)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(loginViewModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LoginViewModelExists(loginViewModel.UserName))
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
            return View(loginViewModel);
        }

        // GET: LoginViewModels/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var loginViewModel = await _context.LoginViewModel
                .FirstOrDefaultAsync(m => m.UserName == id);
            if (loginViewModel == null)
            {
                return NotFound();
            }

            return View(loginViewModel);
        }

        // POST: LoginViewModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var loginViewModel = await _context.LoginViewModel.FindAsync(id);
            _context.LoginViewModel.Remove(loginViewModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LoginViewModelExists(string id)
        {
            return _context.LoginViewModel.Any(e => e.UserName == id);
        }
    }
}
