using DemoPluginModel;
using Microsoft.AspNetCore.Mvc;


namespace DemoPlugin1.Controllers
{
    [Area("DemoPlugin4")]
    public class Plugin4Controller : Controller
    {
        public IActionResult HelloWorld()
        {
            var content = new Demo().SayHello();
            ViewBag.Content = content;
            return View();
        }
    }
}
