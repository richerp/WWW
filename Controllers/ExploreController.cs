using AiursoftBase;
using AiursoftBase.Attributes;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WWW.Data;
using WWW.Models;
using WWW.Models.ExploreViewModels;

namespace WWW.Controllers
{
    [AiurRequireHttps]
    [AiurExceptionHandler]
    public class ExploreController : AiurController
    {
        public readonly UserManager<WWWUser> _userManager;
        public readonly SignInManager<WWWUser> _signInManager;
        public readonly WWWDbContext _dbContext;

        public ExploreController(
            UserManager<WWWUser> userManager,
            SignInManager<WWWUser> signInManager,
            WWWDbContext _context)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _dbContext = _context;
        }

        public async Task<IActionResult> Organizations()
        {
            var orgs = await _dbContext.Orgs.Take(15).ToListAsync();
            var model = new OrganizationsViewModel(1, orgs);
            return View(model);
        }

        private async Task<WWWUser> GetCurrentUserAsync()
        {
            return await _dbContext.Users.SingleOrDefaultAsync(t => t.UserName == User.Identity.Name);
        }
    }
}
