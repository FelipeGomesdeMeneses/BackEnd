using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CrudMoura.Models;

namespace CrudMoura.Controllers
{
    public class FrutasController : Controller
    {
        private readonly ILogger<FrutasController> _logger;

        public static List<Fruta> ListaDeFrutas = new List<Fruta>
        {
            new Fruta{ID = 1, Nome = "Morango", Preco = 3.99f, Quantidade = 10, Categoria = "Tropical"},
            new Fruta{ID = 2, Nome = "Abacate", Preco = 5.90f, Quantidade = 12, Categoria = "Tropical"},
            new Fruta{ID = 3, Nome = "Limão", Preco = 2.95f, Quantidade = 100, Categoria = "Cítrico"},
        };

        public FrutasController(ILogger<FrutasController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ListarFrutas()
        {
            ViewBag.sacolinha = ListaDeFrutas;
            return View();
        }

        //Mostra a tela de cadastrar
        public IActionResult Create()
        {
            return View();
        }

        //Slavar a fruta na lista de frutas
        //Em seguida, redireciona para a lista/tela de ListarFrutas
        [HttpPost]
        public IActionResult SalvarFruta(Fruta frutaCadastrada)
        {
            //Criar um id novo
            frutaCadastrada.ID = ListaDeFrutas.Max(f => f.ID) + 1;
            //Salvar os dados da fruta na ListaDeFrutas
            ListaDeFrutas.Add(frutaCadastrada);
            //voltar para tela de listagem de fruta

            return RedirectToAction(nameof (ListarFrutas));
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}