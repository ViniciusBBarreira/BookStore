using BookStore.Domain.Entity;
using System.Web.Mvc;

namespace BookStore.Controllers
{
    public class TesteController : Controller
    {
        // GET: Teste
        public ActionResult Index()
        {
            return View();
        }

        public string Teste()
        {
            return "Testado";
        }

        public JsonResult Teste1()
        {
            var autor = new Autor
            {
                Id = 1,
                Nome = "Vinícius Batista"
            };

            return Json(autor, JsonRequestBehavior.AllowGet);
        }
    }
}