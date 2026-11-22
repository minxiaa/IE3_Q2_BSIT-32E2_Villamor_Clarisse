using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using IE3_Q2_BSIT_32E2_Villamor_Clarisse.DTO.User;
using IE3_Q2_BSIT_32E2_Villamor_Clarisse;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace IE3_Q2_BSIT_32E2_Villamor_Clarisse.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        // GET: api/<UserController>
        [HttpGet]
        public IActionResult Get()
        {
            var response = new GetUserResponse
            {
                Users = new()
                {
                    new () {Id = 1, Name = "John Doe", Email = "john.doe@example.com"},
                    new () {Id = 2, Name = "John Otto", Email = "john.otto@example.com"},
                    new () {Id = 3, Name = "Jane Doe", Email = "jane.doe@example.com"},
                    new () {Id = 4, Name = "Jane Otto", Email = "jane.otto@example.com"},
                    new () {Id = 5, Name = "John Wick", Email = "john.wick@example.com"},
                    new () {Id = 7, Name = "John Snow", Email = "john.snow@example.com"},
                    new () {Id = 8, Name = "John Whoa", Email = "john.whoa@example.com"},
                    new () {Id = 9, Name = "John Hoe", Email = "john.hoe@example.com"},
                    new () {Id = 10, Name = "John No", Email = "john.no@example.com"},
                }
            };
            
            return Ok(response);
        }

        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            if (id < 1 || id > 10)

            {
                return NotFound();
            }


            return Ok(new GetUserByIdResponse
            {
                Something = $"Requested user with ID {id}"
            });
    
                    
            
        }

        // POST api/<UserController>
        [HttpPost]
        public IActionResult Post([FromBody] string value)
        {
            return Ok(new CreateUserResponse
            {
                Message = "User created successfully",
                Data = value
            });
        }

        // PUT api/<UserController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] string value)
        {
            return Ok(new EditUserResponse
            {
                Message = "User updated",
                Id = id,
                Data = value
            });
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return NoContent();
        }
    }
}
