using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using WebApplication1.Services;

public class CalcController : Controller
{
    public IActionResult PassUsingModel()
    {
        var random = new Random();
        int num1 = random.Next(0, 11);
        int num2 = random.Next(0, 11);

        var model = new CalcModel
        {
            Num1 = num1,
            Num2 = num2
        };

        return View(model);
    }

    public IActionResult PassUsingViewData()
    {
        var random = new Random();
        int num1 = random.Next(0, 11);
        int num2 = random.Next(0, 11);

        ViewData["Num1"] = num1;
        ViewData["Num2"] = num2;
        ViewData["Add"] = num1 + num2;
        ViewData["Sub"] = num1 - num2;
        ViewData["Mul"] = num1 * num2;
        ViewData["Div"] = num2 != 0 ? num1 / num2 : null;
        ViewData["ErrorMessage"] = num2 == 0 ? "Division by zero error." : null;

        return View();
    }

    public IActionResult PassUsingViewBag()
    {
        var random = new Random();
        int num1 = random.Next(0, 11);
        int num2 = random.Next(0, 11);

        ViewBag.Num1 = num1;
        ViewBag.Num2 = num2;
        ViewBag.Add = num1 + num2;
        ViewBag.Sub = num1 - num2;
        ViewBag.Mul = num1 * num2;
        ViewBag.Div = num2 != 0 ? num1 / num2 : (int?)null;
        ViewBag.ErrorMessage = num2 == 0 ? "Division by zero error." : null;

        return View();
    }
    //AccessServiceDirectly
    private readonly CalcService _calcService;

    // Constructor injection (Dependency Injection)
    public CalcController(CalcService calcService)
    {
        _calcService = calcService;
    }
    public IActionResult AccessServiceDirectly()
    {
        var addResult = _calcService.Add();
        var subResult = _calcService.Sub();
        var mulResult = _calcService.Mul();
        var divResult = _calcService.Div();

        ViewBag.Num1 = _calcService.Num1;
        ViewBag.Num2 = _calcService.Num2;
        ViewBag.Add = addResult;
        ViewBag.Sub = subResult;
        ViewBag.Mul = mulResult;
        ViewBag.Div = divResult;
        ViewBag.ErrorMessage = divResult == null ? "Division by zero error." : null;

        return View();
    }
}
