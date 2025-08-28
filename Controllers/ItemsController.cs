using Microsoft.AspNetCore.Mvc;

namespace InventoryManagement.Controllers
{
    public class ItemsController : Controller
    {
        public IActionResult Overview() 
        {
            return View();
        }
    }
}
