using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Drawing;
using System.Drawing.Text;

namespace WorkForceManagement.web.Controllers
{
    public class AuthController : Controller
    {
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly UserManager<IdentityUser> _userManager;
       
        public AuthController(RoleManager<IdentityRole> roleManager, UserManager<IdentityUser> userManager)
        {
            _roleManager = roleManager;
            _userManager = userManager;
        }
       

        public IActionResult Roles()
        {
            var roles=_roleManager.Roles.ToList();
          
            return View(roles);
        }
        public IActionResult AddRole() 
        {

            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddRole(IdentityRole role)
        {
            await _roleManager.CreateAsync(role);

            return RedirectToAction("Roles");
        }
        public IActionResult Users()
        {
            var users = _userManager.Users.ToList();
            return View(users);
        }
        
        public async Task<IActionResult> AssignRole(String userId)
        {
            var user= await _userManager.FindByIdAsync(userId);
            var roles = _roleManager.Roles.ToList();

            return View((user, roles));
        }
        [HttpPost]
        public async Task<IActionResult> AssignRole(string userId, string[] roles)
        {
            var user = await _userManager.FindByIdAsync(userId);
            await _userManager.AddToRolesAsync(user, roles);

            return RedirectToAction("Users");
        }
       
    }
}
