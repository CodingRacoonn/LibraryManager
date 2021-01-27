using ApiLibraryControl.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace ApiLibraryControl.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly UserManager<IdentityUser> _userManager;

        public HomeController(ILogger<HomeController> logger, RoleManager<IdentityRole> roleManager, UserManager<IdentityUser> userManager)
        {
            _logger = logger;
            _roleManager = roleManager;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Privacy()
        {

            //login: test@gmail.com
            //hasło: Qwe12.

            //var role = await _roleManager.FindByNameAsync("Manager");
            //var result = await _roleManager.DeleteAsync(role);




            //string[] roles = { "Manager"};

            //foreach (var rolem in roles)
            //{
            //    bool roleExist = await _roleManager.RoleExistsAsync(rolem);

            //    if (roleExist == false)
            //    {
            //        await _roleManager.CreateAsync(new IdentityRole(rolem));
            //    }
            //}

            //var user = await _userManager.FindByEmailAsync("test@gmail.com");

            //if (user != null)
            //{
            //    await _userManager.AddToRoleAsync(user, "Admin");
            //}
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
