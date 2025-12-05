using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CrudMoura.Models;

namespace CrudMoura.Controllers
{
    public class AlunoController : Controller
    {
        private readonly ILogger<AlunoController> _logger;
        private readonly CrudMouraContext _context;

        public AlunoController(ILogger<AlunoController> logger, CrudMouraContext context)
        {
            _logger = logger;
            _context = context;
        }

        public static List<Aluno> ListaDeAlunos = new List<Aluno>
        {
            new Aluno{id = 1, Nome = "Felipe Gomes", CPF = "333.123.321-67", Idade = 17, Email = "felipegomes@gmail.com"},
            new Aluno{id = 2, Nome = "Felipe Salgado", CPF = "333.123.321-68", Idade = 16, Email = "felipetorolho@gmail.com"},
            new Aluno{id = 3, Nome = "Felipe Torolho",  CPF = "333.123.321-69", Idade = 16, Email = "felipetorolho@gmail.com"},
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
            aluno.id = ListaDeAlunos.Max(f => f.id) + 1;

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