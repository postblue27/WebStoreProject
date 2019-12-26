using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace web_store.Models
{
    public interface IProductRepository
    {
        IEnumerable<Product> Products { get; }
        Product GetProductById(int productId);
        IEnumerable<Product> SuggestedProducts { get; }
    }
}
