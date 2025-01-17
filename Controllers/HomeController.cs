using System.Security.Claims;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ApiTest.Controllers
{
    public class HomeController() : Controller
    {
        [Authorize(CookieAuthenticationDefaults.AuthenticationScheme, Policy = "EmployeeOnly")]
        public IActionResult Index(string username = "")
        {
            ClaimsPrincipal user = HttpContext.User;
            return Ok("{\"text\": \"All good\"}");
        }

        [Authorize(JwtBearerDefaults.AuthenticationScheme, Policy = "EmployeeOnly")]
        public IActionResult Test()
        {
            return Ok("{\"text\": \"All good\"}");
        }
    }
}