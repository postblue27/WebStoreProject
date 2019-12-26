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
    [Authorize(Roles ="Employee")]
    public class OrderDetailCrudController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IOrderDetailRepository _orderDetailRepository;

        public OrderDetailCrudController(AppDbContext context, IOrderDetailRepository orderDetailRepository)
        {
            _context = context;
            _orderDetailRepository = orderDetailRepository;
        }

        // GET: OrderDetailCrud
        public async Task<IActionResult> Index(int id)
        {
            var appDbContext = _context.OrderDetails.Include(o => o.Order).Include(o => o.Product);

            var orderDetails = from o in appDbContext select o;

            orderDetails = orderDetails.Where(s => s.OrderId.Equals(id));

            return View(await orderDetails.ToListAsync());

        }

    }
}
