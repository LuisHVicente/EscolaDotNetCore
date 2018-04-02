using FanSoft.Escola.MVCUI.Data;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace FanSoft.Escola.MVCUI.Controllers
{
    public class EscolasController : Controller
    {
        private readonly EscolaDataContext _ctx;

        public EscolasController(Data.EscolaDataContext ctx)
        {
            _ctx = ctx;
        }
        public IActionResult Index()
        {
            var model = _ctx.Escolas.ToList();
            return View(model);
        }

    }
}
