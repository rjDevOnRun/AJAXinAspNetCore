using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebModels;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        [HttpGet]
        [Route("GetAll")]
        public IEnumerable<Product> GetProducts()
        {
            return ProductList();
        }

        [HttpGet]
        [Route("GetById/{id}")]
        public Product GetById(int id)
        {
            return ProductList().Where(x => x.Id == id).FirstOrDefault();
        }

        public List<Product> ProductList()
        {
            var products = new List<Product>()
            {
                new Product(){Id=1, Name="Computer", Price=50000},
                new Product(){Id=2, Name="Laptop", Price=75000},
                new Product(){Id=3, Name="Mouse", Price=500},
                new Product(){Id=4, Name="Keyboard", Price=550},
                new Product(){Id=5, Name="Monitor", Price=11500}
            };
            return products;
        }

    }
}
