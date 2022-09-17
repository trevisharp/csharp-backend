using Microsoft.AspNetCore.Mvc;
using static System.IO.File;

namespace csharp_backend.Controllers;

[ApiController]
[Route("/")]
public class TestController : ControllerBase
{
    [HttpGet]
    public ActionResult Index()
    {
        return Content(
            ReadAllText("Views/index.html"), 
            "text/html");
    }

    [HttpGet("/login")]
    public ActionResult Login()
    {
        return Content(
            ReadAllText("Views/login.html"), 
            "text/html");
    }
}
