using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using web_store.Models;

using Microsoft.AspNetCore.Authorization;

namespace web_store.Controllers.CRUDControllers
{
    [Authorize(Roles = "Employee")]
    public class OrderCrudController : Controller
    {
        private readonly AppDbContext _context;

        public OrderCrudController(AppDbContext context)
        {
            _context = context;
        }

        // GET: OrderCrud
        public async Task<IActionResult> Index()
        {
            return View(await _context.Orders.ToListAsync());
        }
    }
}
