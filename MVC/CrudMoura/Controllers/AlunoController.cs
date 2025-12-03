using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CrudMoura.Models;

namespace CrudMoura.Controllers
{
    public class AlunoController : Controller
    {
        private readonly ILogger<AlunoController> _logger;

        public static List<Aluno> ListaDeAlunos = new List<Aluno>
        {
            new Aluno{ID = 1, Nome = "Felipe Gomes", CPF = 12345678901, Idade = 17, Email = "felipegomes@gmail.com"},
            new Aluno{ID = 2, Nome = "Felipe Salgado", CPF = 12345678902, Idade = 16, Email = "felipetorolho@gmail.com"},
            new Aluno{ID = 3, Nome = "Felipe Torolho",  CPF = 12345678903, Idade = 16, Email = "felipetorolho@gmail.com"},
        };

        public AlunoController(ILogger<AlunoController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ListarAlunos()
        {
            ViewBag.Escola = ListaDeAlunos;
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Aluno aluno)
        {
            aluno.ID = ListaDeAlunos.Max(f => f.ID) + 1;

            ListaDeAlunos.Add(aluno);

            return RedirectToAction(nameof(Create));
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}