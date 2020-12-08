using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Enterprise.Models;
using Microsoft.EntityFrameworkCore;

namespace Enterprise.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class WishesController : ControllerBase
    {
        private readonly dbContext _dbContext;
        public WishesController(dbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        [Route("test")]
        public IActionResult test()
        {

            return Ok("Hello world");
        }

        [HttpGet]
        [Route("getAllWishes")]
        public IActionResult getAllWishes()
        {

            return Ok(_dbContext.Wishes.ToList());
        }

        [HttpPost]
        [Route("AddWish")]
        public IActionResult AddWish([FromBody] Wish _wish)
        {
            try
            {
                _dbContext.Wishes.Add(_wish);
                _dbContext.SaveChanges();
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.InnerException.Message);
            }

        }
    }
}
