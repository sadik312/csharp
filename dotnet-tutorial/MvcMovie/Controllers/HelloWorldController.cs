using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers;

public class HelloWorldController : Controller{
    // GET: /HelloWorld/
    public string Index()
    {
        return "This is the default action";
    }
    // GET: /HelloWorld/Welcome/
    public string Welcome()
    {
        return "This is the Welcome action method";
    }
}