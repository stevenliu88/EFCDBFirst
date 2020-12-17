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
            using (var context = new BookStoresDBContext()) 
            {
                return context.Author.ToArray();   
            }
        }

        [HttpGet("{id}")]
        public IActionResult GetAuthor(int id) 
        {
            using (var context = new BookStoresDBContext()) 
            {
                var author = context.Author.FirstOrDefault(a => a.AuthorId == id);
                return Ok(author);
            }
        }

    }
}
