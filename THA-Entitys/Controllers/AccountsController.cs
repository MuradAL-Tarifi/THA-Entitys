using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using THA_Entitys.Models;

namespace IdentityTest.Controllers
{
    public class AccountsController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly AlumniadbContext db;

        public AccountsController(UserManager<ApplicationUser> userManager,SignInManager<ApplicationUser> signInManager, AlumniadbContext alumniadbContext)
        {
            this._userManager = userManager;
            this._signInManager = signInManager;
            this.db = alumniadbContext;
        }
        public IActionResult List()
        {
           var UserList= db.ApplicationUsers.ToList();
            return View(UserList);
        }
        public IActionResult Registers()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Registers(ApplicationUser model)
        {
            if (ModelState.IsValid)
            {
              var result= await _userManager.CreateAsync(model, model.PasswordHash);
                if (result.Succeeded)
                {
                    await _signInManager.SignInAsync(model, false);

                    return RedirectToAction("Index","Home");
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(String.Empty, error.Description);
                }
            }
            return View(model);
        }
        //public async Task<IActionResult> Edit(string? Id)
        //{
        //    var User=await _userManager.FindByIdAsync(Id);
        //    if (User == null)
        //    {
        //        return NotFound();
        //    }
        //    var UserEdit = new RegisterEditViewModel
        //    {
        //        Id = User.Id,
        //        Email = User.Email
        //    };
        //    return View(UserEdit);
        //}
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Edit(RegisterEditViewModel model)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        var User = await _userManager.FindByIdAsync(model.Id);
        //        User.Email= model.Email;
        //        User.Id = model.Id;
        //        var result = await _userManager.UpdateAsync(User);
        //        if (result.Succeeded)
        //        {
                   
        //            return RedirectToAction("List", "Accounts");
        //        }
        //        foreach (var error in result.Errors)
        //        {
        //            ModelState.AddModelError(String.Empty, error.Description);
        //        }
        //    }
        //    return View(model);
        //}
    }
}
