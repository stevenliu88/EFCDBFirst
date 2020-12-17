using BookStoresWebAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoresWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Author> Get() 
        {
            //using (var context = new BookStoresDBContext()) 
            //{
            //    return context.Authors.ToArray();   
            //}
            return null;
        }

        [HttpGet("{id}")]
        public IActionResult GetAuthor(int id) 
        {
            //using (var context = new BookStoresDBContext()) 
            //{
            //    var author = context.Authors.FirstOrDefault(a => a.AuthorId == id);
            //    return Ok(author);
            //}
            return null;
        }

    }
}
