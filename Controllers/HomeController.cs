using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DersModelApp.Models;

namespace DersModelApp.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        Ders ders = new Ders();
        ders.Ad="Web";
        ders.Seviye=11;
        ders.Ogretmen="Ergün Karakuş";
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
