using InventoryManagement.Data;
using Microsoft.AspNetCore.Mvc;

namespace InventoryManagement.Controllers
{
    public class OrdersController : Controller
    {
        private readonly AppDbContext _context;

        public OrdersController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Overview()
        {
            var orders = _context.Orders.ToList();
            return View(orders);
        }

        public IActionResult CreateEdit(int id) 
        {
            if (id != 0)
            {
                var order = _context.Orders.Find(id);
                return View(order);
            }

            //Create Neues Item (id = 0)
            return View();
        }

    }
}
