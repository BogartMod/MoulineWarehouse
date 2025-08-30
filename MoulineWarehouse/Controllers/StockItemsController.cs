using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MoulineWarehouse.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MoulineWarehouse.Controllers
{
    public class StockItemsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public StockItemsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: StockItems
        public async Task<IActionResult> Index()
        {
            var items = await _context.StockItems
                .Include(s => s.ThreadColor)
                .Where(s => s.Quantity > 0)
                .ToListAsync();
            return View(items);
        }

        // GET: StockItems/Create
        public IActionResult Create()
        {
            ViewData["ThreadColorId"] = new Microsoft.AspNetCore.Mvc.Rendering.SelectList(
                _context.ThreadColors, "Id", "Code"
            );
            return View();
        }

        // POST: StockItems/Create
        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Create([Bind("ThreadColorId,Quantity,ReservedQuantity")] StockItem stockItem)
        {
            if (ModelState.IsValid)
            {
                _context.Add(stockItem);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }


            if (!ModelState.IsValid)
            {
                foreach (var error in ModelState.Values.SelectMany(v => v.Errors))
                {
                    Console.WriteLine(error.ErrorMessage);
                }
            }

            foreach (var error in ModelState.Values.SelectMany(v => v.Errors))
            {
                Console.WriteLine("ModelState error: " + error.ErrorMessage);
            }

            ViewData["ThreadColorId"] = new SelectList(
                _context.ThreadColors, "Id", "Code", stockItem.ThreadColorId
            );

            return View(stockItem);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.StockItems == null)
            {
                return NotFound();
            }
            var stockItem = await _context.StockItems.FindAsync(id);
            if (stockItem == null)
            {
                return NotFound();
            }
            ViewData["ThreadColorId"] = new SelectList(
                _context.ThreadColors, "Id", "Code", stockItem.ThreadColorId
            );
            return View(stockItem);
        }



    }
}
