using KjeksFabrikken.DataAccess.Repository.IRepository;
using KjeksFabrikken.Models;
using Microsoft.AspNetCore.Mvc;

namespace KjeksFabrikken.Controllers;

public class CookiesController : Controller
{
    private readonly IUnitOfWork _unitOfWork;

    public CookiesController(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }
    
    public IActionResult Index()
    {
        IEnumerable<Cookie> objCookiesList = _unitOfWork.Cookie
            .GetAll();

        return View(objCookiesList);
    }
}