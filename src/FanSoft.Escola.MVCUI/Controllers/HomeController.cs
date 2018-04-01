using Microsoft.AspNetCore.Mvc;

namespace FanSoft.Escola.MVCUI.Controllers
{
    public class HomeController:Controller
    {
        public IActionResult Index() => View();

        [Route("Sobre")]
        public IActionResult About() => View();
    }
}
