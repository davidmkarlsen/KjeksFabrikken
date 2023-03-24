using Microsoft.AspNetCore.Mvc;

namespace KjeksFabrikken.Controllers;

public class ContactController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
    
    // POST
}