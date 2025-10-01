using InventoryManagement.Data;
using InventoryManagement.Models;
using Microsoft.AspNetCore.Mvc;

namespace InventoryManagement.Controllers
{
    public class ItemsController : Controller
    {
        private readonly AppDbContext _context;

        public ItemsController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Overview() 
        {
            var items = _context.Items.ToList();
            return View(items);
        }

        public IActionResult CreateEdit(int id) 
        {
            //Editieren eines bestehenden Items:
            //Prüfe ob ein Item übergeben wird. Wenn Ja zeige es an.
            if(id != 0)
            {
                var item = _context.Items.Find(id); 
                return View(item);
            }

            //Create Neues Item (id = 0)
            return View();
        }

        [HttpPost]
        public IActionResult CreateEditItem(Item item)
        {
            if (item.Id == 0)
            {
                _context.Items.Add(item);

            } else
            {
                _context.Items.Update(item);

            }

            _context.SaveChanges();

            return RedirectToAction(nameof(Overview));
        }

        
        public IActionResult Delete(int id)
        {
            var item = _context.Items.Find(id);

            if (item != null) 
            { 
                _context.Items.Remove(item);
                _context.SaveChanges();
            }
            return RedirectToAction(nameof(Overview));
        }
    }
}

