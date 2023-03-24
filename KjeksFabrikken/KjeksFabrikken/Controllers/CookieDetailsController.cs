using System.Net;
using KjeksFabrikken.DataAccess.Repository.IRepository;
using Microsoft.AspNetCore.Mvc;

namespace KjeksFabrikken.Controllers;

public class CookieDetailsController : Controller
{
    private readonly IUnitOfWork _unitOfWork;

    public CookieDetailsController(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public IActionResult Index(int id)
    {
        var chosenCookie = _unitOfWork.Cookie
            .GetById(id);
        return View(chosenCookie);
    }

}