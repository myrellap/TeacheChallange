using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TeacheChallange.Models;

namespace TeacheChallange.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        

        return View();
    }

    public IActionResult About()
    {
         // ViewData e ViewBag servem para transportar os dados controller para a View
        //Imagine que os dados abaixo vieram de um banco de dados 
        ViewData["Nome"] = "Myrella Putti";
        ViewData["Idade"] = 45;

        ViewBag.Cidade = "Jaú";
        ViewBag.UF = "SP";


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
