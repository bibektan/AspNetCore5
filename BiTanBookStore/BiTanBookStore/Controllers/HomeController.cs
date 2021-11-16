using Microsoft.AspNetCore.Mvc;

namespace BiTanBookStore.Controllers
{
    public class HomeController : Controller
    {
        public string index()
        {
            return "home";
        }
    }
}
