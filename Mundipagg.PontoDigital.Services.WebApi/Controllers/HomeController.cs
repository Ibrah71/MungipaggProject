
using System.Web.Mvc;

namespace Mundipagg.PontoDigital.Services.WebApi.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }
    }
}
