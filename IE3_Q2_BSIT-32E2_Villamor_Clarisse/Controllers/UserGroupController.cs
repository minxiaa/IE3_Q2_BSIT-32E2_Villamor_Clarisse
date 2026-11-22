using Microsoft.AspNetCore.Mvc;
using IE3_Q2_BSIT_32E2_Villamor_Clarisse.DTO.UserGroup;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace IE3_Q2_BSIT_32E2_Villamor_Clarisse.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserGroupController : ControllerBase
    {
        // GET: api/<UserGroupController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok();
        }

        // GET api/<UserGroupController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok();
        }

        // POST api/<UserGroupController>
        [HttpPost]
        public IActionResult Post([FromBody] string value)
        {
            return Ok(new CreateUserGroupResponse
            {
                Id = 1,
                Name = value
            });
        }

        // PUT api/<UserGroupController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] string value)
        {
            return Ok(new EditUserGroupResponse
            {
                Id = id,
                Name = value
            });
        }

        // DELETE api/<UserGroupController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return NoContent();
        }
    }
}
