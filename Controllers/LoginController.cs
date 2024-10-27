using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace CarClinic.Controllers
{
    public class LoginController : Controller
    {
        [HttpGet]
        public IActionResult Entrar()
        {
            ClaimsPrincipal usuario = HttpContext.User;

            if (usuario.Identity.IsAuthenticated)
            {
                return Redirect("/Portal/Index");
            }

            return View();
        }

    }
}
