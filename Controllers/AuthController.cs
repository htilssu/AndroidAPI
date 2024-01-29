using System.Net;
using System.Web.Mvc;

namespace ShoppingWEBTraining.Controllers;

[Route("api/[controller]")]
public class AuthController : Controller
{
    [HttpPost]
    [ActionName("Login")]
    public ActionResult? Index(string? username, string? password)
    {
        if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
        {
            return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        }

        //TODO handle information from client
        // Session["username"] = username;
        return null;
    }
}