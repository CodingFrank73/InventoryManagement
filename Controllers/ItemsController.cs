using InventoryManagement.Models;
using Microsoft.AspNetCore.Mvc;

namespace InventoryManagement.Controllers
{
    public class ItemsController : Controller
    {
        public IActionResult Overview() 
        {
            Item itemOne = new Item 
            {
                Id = 1,
                Name = "Fritzbox",
                Description = "Einfacher Router",
                Stock = 50
            };

            Item itemTwo = new Item
            {
                Id = 2,
                Name = "Lampe XY",
                Description = "Deckenleuchte",
                Stock = 20
            };

            IEnumerable<Item> items = new List<Item> { itemOne, itemTwo };
            return View(items);
        }

        public IActionResult Create() 
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Item item)
        {
            return RedirectToAction(nameof(Overview));
        }

        public IActionResult Delete(int id)
        {
            return RedirectToAction(nameof(Overview));
        }
    }
}

