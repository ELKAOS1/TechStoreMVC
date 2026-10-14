using Microsoft.AspNetCore.Mvc;
using TechStoreMVC.Models;

namespace TechStoreMVC.Controllers
{
    public class ProdutosController : Controller // O ":" siginifica herança
    // Herança é quando uma classe herda os atributos e métodos de outra classe, ou seja, a classe filha herda da classe pai.
    {
        // GET: ProdutosController

        // Passo 02 - Criar a Ação
        // Conseito de POO -> Programção Orientada a Objetos
        public ActionResult Index()
        {
            // Passo 05 - Objeto
            // Criar um objeto como vairos produtos, por isso usamos um List
            List<Produto> produtos = new List<Produto>
            {
                new Produto(1, "Mouse Gamer", 129.9m, 10),
                new Produto(2, "Teclado Mecânico", 249.9m, 5),
                new Produto(3, "Monitor 24 polegadas", 899.9m, 8),
                new Produto(4, "Headset Gamer", 179.9m, 15),
            };
            return View(produtos); // Passo 06 - Passar o objeto para a View
        }

    }
}
