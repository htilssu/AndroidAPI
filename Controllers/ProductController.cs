using System.Net;
using System.Web.Mvc;

namespace ShoppingWEBTraining.Controllers;

[Route("api/[controller]")]
public class ProductController : Controller
{
    [HttpGet]
    [ActionName("Index")]
    public ActionResult? Get(int? id)
    {
        if (id == null)
        {
            //TODO return all products
        }

        //TODO collect product by id
        return Json(new { id = 123, name = "product1" }, JsonRequestBehavior.AllowGet);
    }

    [HttpPost]
    public ActionResult Post()
    {
        return new HttpStatusCodeResult(HttpStatusCode.OK);
    }
}