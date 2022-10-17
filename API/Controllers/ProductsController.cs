using API.Data;
using API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly JstoreContext _jstoreContext;

        public ProductsController(JstoreContext jstoreContext)
        {
            _jstoreContext = jstoreContext;
        }
       

        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetProducts()
        {
            return  await _jstoreContext.Products.ToListAsync();
          

        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Product?>>GetProducts( long id)
        {
            return await _jstoreContext.Products.FindAsync(id);

        }

    }
}
