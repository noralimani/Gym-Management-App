using GymManagementSystem.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.AspNetCore.Authorization;
using System.Linq;
using System.Threading.Tasks;
using GymManagementSystem.Data;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace GymManagementSystem.Controllers
{
    
    
    [Authorize]
    public class HomeController : Controller
    {
        private readonly GymContext _context;

        public HomeController(GymContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            ViewBag.Total_Members = _context.Members.Count();
            ViewBag.Total_Memberships = _context.Memberships.Count();
            ViewBag.Total_Services = _context.Services.Count();

            var memberships = _context.Memberships
                .Where(s => s.EndDate < DateTime.Now)
                .Include(s => s.Member)
                .ToList();
            
            ViewBag.Memberships = memberships;

            ViewBag.Calendar = JsonConvert.SerializeObject(memberships);


            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
