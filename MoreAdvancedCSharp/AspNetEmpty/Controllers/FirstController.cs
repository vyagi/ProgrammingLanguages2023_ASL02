using Microsoft.AspNetCore.Mvc;

namespace AspNetEmpty.Controllers
{
    public class FirstController : Controller
    {
        public ViewResult MyAction()
        {
            return View();
        }

        public ViewResult SecondAction()
        {
            return View();
        }

        public string Index()
        {
            return "Oh, this is index";
        }
    }
}
