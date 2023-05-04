using Microsoft.AspNetCore.Mvc;

namespace AspNetEmpty.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "Oh, this is really a default one";
        }
    }
}
