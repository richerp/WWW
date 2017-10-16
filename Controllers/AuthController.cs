using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using WWW.Models;
using WWW.Data;
using AiursoftBase.Services;
using AiursoftBase.Attributes;
using System;
using AiursoftBase.Models;
using AiursoftBase.Models.ForApps.AddressModels;
using AiursoftBase;

namespace WWW.Controllers
{
    [AiurRequireHttps]
    [AiurExceptionHandler]
    public class AuthController : AiurController
    {
        public readonly UserManager<WWWUser> _userManager;
        public readonly SignInManager<WWWUser> _signInManager;
        public readonly WWWDbContext _dbContext;

        public AuthController(
            UserManager<WWWUser> userManager,
            SignInManager<WWWUser> signInManager,
            WWWDbContext _context)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _dbContext = _context;
        }

        [AiurForceAuth(preferController: "", preferAction: "", justTry: false)]
        public IActionResult GoAuth()
        {
            throw new NotImplementedException();
        }

        public async Task<IActionResult> AuthResult(AuthResultAddressModel model)
        {
            if (!User.Identity.IsAuthenticated && ModelState.IsValid)
            {
                await AuthProcess.AuthApp(this, model, _userManager, _signInManager);
            }
            return Redirect(model.state);
        }
    }
}