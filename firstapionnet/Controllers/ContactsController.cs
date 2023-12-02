using Microsoft.AspNetCore.Mvc;

namespace firstapionnet.Controllers;

public class ContactsController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}