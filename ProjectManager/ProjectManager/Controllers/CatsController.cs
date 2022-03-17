using Microsoft.AspNetCore.Mvc;
using ProjectManager.Models;

namespace ProjectManager.Controllers
{
    public class CatsController : Controller
    {
        public IActionResult All()
        {
            var cats = new List<CatViewModel>()
            {
                new CatViewModel{Name = "Kolyu", Age = 2},
                new CatViewModel{Name = "Kotio", Age = 1}
            };

            return View(cats);
        }
    }
}
 