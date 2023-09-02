using Microsoft.AspNetCore.Mvc;
using Vaquinha.Domain.Interfaces.Service;

namespace Vaquinha.Controllers
{
    public class DoadoresController : Controller
    {
        private readonly IDoacaoService _doacaoService;

        public DoadoresController(IDoacaoService doacaoService)
        {
            _doacaoService = doacaoService;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _doacaoService.RecuperarDoadoresAsync());
        }
    }
}