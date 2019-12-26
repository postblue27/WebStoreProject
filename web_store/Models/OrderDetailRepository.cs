using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace web_store.Models
{
    public class OrderDetailRepository : IOrderDetailRepository
    {
        private readonly AppDbContext _appDbContext;

        public OrderDetailRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public OrderDetail GetOrderDetailById(int orderDetailId)
        {
            return _appDbContext.OrderDetails.FirstOrDefault(o => o.OrderDetailId == orderDetailId);
        }
    }
}
