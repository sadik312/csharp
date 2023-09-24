using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers;

public class HelloWorldController : Controller{
    // GET: /HelloWorld/
    public IActionResult Index()
    {
        return View();
    }
    // GET: /HelloWorld/Welcome/
    public string Welcome(string name, int numTimes=1)
    {
        return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");
    }
}

/*
Every public method in controller is callable as an HTTP endpoint
First method: invoked by appending /HelloWorld/ to base URL
Second method: invoked by appending /HelloWorld/Welcome/ to URL
MVC invokes controller classes in this format:
/[Controller]/[ActionName]/[Parameters]
Routing format is set in Program.cs
*/