using BeautyProducts.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.FileSystemGlobbing;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BeautyProducts.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        [HttpPut]
        public async Task<IActionResult> Put(Products products)
        {
            using (var db = new ProductsDb())
            {
                db.Products.Add(products);
                await db.SaveChangesAsync();
            }

            return Ok();
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            using (var db = new ProductsDb())
            {
                var products = await db.Products.ToListAsync();
                return Ok(products);
            }
        }
    }
}
