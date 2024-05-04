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
    public class CategoriesController : ControllerBase
    {
        private readonly ApplicationDataContext _context;
        public CategoriesController(ApplicationDataContext context)
        {
            _context = context;
        }

        [HttpGet]
        //Ienumerable lista
        public ActionResult<IEnumerable<Category>> GetCategory()
        {
            return _context.Category.ToList();
        }
        [HttpGet]
        [Route("{id  Guid}")]
        //200 201 400 404 500
        public ActionResult<Category> GetByCategoryId( Guid id)
        {
            var category = _context.Category.FirstOrDefault(c => c.Id == id);
            if (category == null)
            {
                return NotFound();
            }
            return Ok(category);
        }

        [HttpPost]  
        //tratamento no post
        public ActionResult PostCategory(Category category)
        {
            _context.Category.Add(category);
            _context.SaveChanges();
          
           
            return Ok();
        }
    }
}

//migration update nome intuitivo