using System.Net.Mime;
using Microsoft.AspNetCore.Mvc;
using AMS3A.Sales.Context;
using AMS3A.Sales.Domain;
using Swashbuckle.AspNetCore.Swagger;
using Microsoft.EntityFrameworkCore;

namespace AMS3A.Sales.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class ProductController :ControllerBase
    {
         private readonly ApplicationDataContext _context;
        public ProductController(ApplicationDataContext context )
        {
             _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Product>> GetProduct()
        {
               return _context.Product.ToList();
        }
        [HttpGet]
        [Route("{id  Guid}")]
        //200 201 400 404 500
        public ActionResult<Product> GetByProductId(Guid id)
        {
            var product = _context.Product.FirstOrDefault(c => c.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }

        [HttpPost] 
        public ActionResult PostProduct(Product product)
        {
            _context.Add(product);
           
            if(product != null)
            {
                _context.SaveChanges();
            }
            return Ok();

        }
        
    }
}