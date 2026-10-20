using Microsoft.AspNetCore.Mvc;
using TechStoreMVC.Models;

namespace TechStoreMVC.Controllers
{
    public class CategoriasController : Controller
    {
        // GET: CategoriasController
       public ActionResult Index()
        {
            // Passo 05 - Objeto
            // Criar um objeto como vairos produtos, por isso usamos um List
            List<Categoria> categorias = new List<Categoria>
            {
                new Categoria(1, "Informática", "Computadores e componentes", true),
                new Categoria(2, "Periféricos", "Mouse, teclado e acessórios", true),
                new Categoria(3, "Áudio", "Fones, caixas e microfones", true),
                new Categoria(4, "Monitores", "Telas e monitores", true),
                new Categoria(5, "Descontinuados", "Categorias fora de uso", false),
            };
            return View(categorias); // Passo 06 - Passar o objeto para a View
        }


    }
}
