using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using web_store.Models;

namespace web_store.ViewModels
{
    public class ProductsListViewModel
    {
        public IEnumerable<Product> Products { get; set; }
        public String CurrentCategory { get; set; }
    }
}
