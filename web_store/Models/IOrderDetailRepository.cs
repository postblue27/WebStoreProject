
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace web_store.Models
{
    public interface IOrderDetailRepository
    {
        OrderDetail GetOrderDetailById(int orderDetailId);
    }
}
