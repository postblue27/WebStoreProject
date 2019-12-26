using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using web_store.Models;
using web_store.ViewModels;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace web_store.Controllers
{
    [Route("api/[controller]")]
    public class ProductDataController : Controller
    {
        private readonly IProductRepository _productRepository;

        public ProductDataController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        [HttpGet]
        public IEnumerable<ProductViewModel> LoadMoreProducts()
        {
            IEnumerable<Product> dbProducts = null;

            dbProducts = _productRepository.Products.OrderBy(p => p.ProductId).Take(10);

            List<ProductViewModel> products = new List<ProductViewModel>();

            foreach (var dbProduct in dbProducts)
            {
                products.Add(MapDbProductToProductViewModel(dbProduct));
            }
            return products;
        }

        private ProductViewModel MapDbProductToProductViewModel(Product dbProduct)
        {
            return new ProductViewModel()
            {
                ProductId = dbProduct.ProductId,
                Name = dbProduct.Name,
                Price = dbProduct.Price,
                ShortDescription = dbProduct.ShortDescription,
                ImageThumbnailUrl = dbProduct.ImageThumbnailUrl
            };
        }
    }
}
