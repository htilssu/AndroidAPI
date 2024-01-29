using System.Web.Mvc;

namespace ShoppingWEBTraining.Controllers;

public class HomeController : Controller
{
    public ActionResult Index()
    {
        return View();
    }
}