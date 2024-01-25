using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;

namespace ShoppingWEBTraining.Controllers;

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

        Response.ContentType = "application/json";
        Response.SetCookie(new HttpCookie("cookie", Guid.NewGuid().ToString()));
        Response.StatusCode = (int)HttpStatusCode.OK;
        //TODO collect product by id
        return Json(new { id = 123, name = "product1" }, JsonRequestBehavior.AllowGet);
    }

    [HttpPost]
    public ActionResult Post()
    {
        return new HttpStatusCodeResult(HttpStatusCode.OK);
    }
}