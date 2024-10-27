using CarClinic.Data;
using CarClinic.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace CarClinic.Controllers
{
    public class LoginController : Controller
    {
        private readonly ApplicationDbContext _banco;
        public LoginController(ApplicationDbContext db)
        {
            _banco = db;
        }

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

        [HttpPost]
        public async Task<IActionResult> Entrar(string Email, string Senha)
        {
            LoginModel login = _banco.tb_login.Where(x => x.Email == Email && x.Senha == Senha).FirstOrDefault();

            if (login == null)
            {
                TempData["ErroValidadeLogin"] = "E-mail ou senha está incorreto, por favor, tente novamente. Se o problema persistir, entre em contato com o suporte.";
                return View();
            }

            var claims = new List<Claim>();
            claims.Add(new Claim(ClaimTypes.Name, login.Email));
            claims.Add(new Claim(ClaimTypes.Sid, login.Senha.ToString()));

            var identidade = new ClaimsIdentity(claims, "Aceso");
            ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(identidade);
            await HttpContext.SignInAsync("CookieAuthentication", claimsPrincipal, new AuthenticationProperties());
            return Redirect("/Portal/Index");
        }

        public async Task<IActionResult> Sair()
        {
            await HttpContext.SignOutAsync();
            return View(nameof(Entrar));
        }
    }
}
