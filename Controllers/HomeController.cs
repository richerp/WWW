using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AiursoftBase.Attributes;
using AiursoftBase;
using AiursoftBase.Models;
using Microsoft.AspNetCore.Identity;
using WWW.Models;
using WWW.Data;

namespace WWW.Controllers
{
    [AiurRequireHttps]
    [AiurExceptionHandler]
    public class HomeController : AiurController
    {
        public readonly UserManager<WWWUser> _userManager;
        public readonly SignInManager<WWWUser> _signInManager;
        public readonly WWWDbContext _dbContext;

        public HomeController(
            UserManager<WWWUser> userManager,
            SignInManager<WWWUser> signInManager,
            WWWDbContext _context)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _dbContext = _context;
        }

        [AiurForceAuth("", "", justTry: true)]
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";
            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";
            return View();
        }

        public IActionResult Error()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> LogOff()
        {
            await _signInManager.SignOutAsync();
            return SignoutRootServer(new AiurUrl(string.Empty, "Home", nameof(HomeController.Index), new { }));
        }
    }
}
