using DepartmentalStore.Data.Models;
using DepartmentalStore.UI;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiDepartmentalStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MyController : ControllerBase
    {
        private readonly DepartmentalContext _context;

        public MyController(DepartmentalContext context)
        {
            _context = context;
        }

        //[HttpGet("display")]
        //public string display()
        //{
        //    return "Hey api";
        //}




        [HttpGet("items")]
        public List<Product> getItems()
        {
            var result = from r in _context.Product select r;
            return result.ToList();
        }



        //[HttpPost("items")]
        //public Product createItem(Product p)
        //{
        //    _context.Product.Add(p);
        //    _context.SaveChanges();
        //    return p;
        //}

        //[HttpPut("items/{id}")]
        //public Product updateItem(Product p)
        //{
        //    _context.Entry(p).State = EntityState.Modified;
        //    _context.SaveChanges();
        //    return p;
        //}







        //[HttpGet("items/{name}")]
        //public List<Product> getItems(string name)
        //{

        //    var result = from r in _context.Product where r.ProductName = name select r;

        //    return result.ToList();
        //}













        //[HttpGet("ProductItems")]
        //public async Task<ActionResult<IEnumerable<Product>>> GetProduct()
        //{
        //    return await _context.Product.ToListAsync();
        //}




        //Search By Id

        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetProduct(long id)
        {
            var product = await _context.Product.FindAsync(id);

            if (product == null)
            {
                return NotFound();
            }

            return product;
        }


        //[HttpGet("{Name}")]
        //public async Task<ActionResult<Product>> GetProduct(string Name)
        //{
        //    var product = await _context.Product.FindAsync(Name);



        //    if (product == null)
        //    {

        //        return NotFound();
        //    }



        //    return product;
        //}















        //Add
        [HttpPost]
        public async Task<ActionResult<Product>> PostProduct(Product product)
        {
            _context.Product.Add(product);
            await _context.SaveChangesAsync();



            return CreatedAtAction("GetProduct", new { id = product.ProductId }, product);
        }
       
        























        //Delete  
        [HttpDelete("{id}")]
        public async Task<ActionResult<Product>> DeleteProduct(long id)
        {
            var product = await _context.Product.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }

            _context.Product.Remove(product);
            await _context.SaveChangesAsync();

            return product;
        }

    }
}