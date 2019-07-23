using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UserManagement.Api;
using UserManagement.Dto;

namespace UserManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;

        public UsersController(IUserService userService)
        {
            this._userService = userService;
        }

        // GET api/users, paginated
        [HttpGet]
        public ActionResult<IEnumerable<UserDto>> Get(int pageSize, int page)
        {
            return null;
        }

        // GET api/users/5
        [HttpGet("{id}")]
        public ActionResult<UserDto> Get(int id)
        {
            return Ok(_userService.GetUser(id));
        }

        // POST api/users
        [HttpPost]
        public long Post([FromBody] RegisterUserDto value)
        {
            return _userService.CreateUser(
                value.Email,
                value.FirstName,
                value.LastName,
                value.RawPassword,
                value.DateOfBirth
            ).Id;
        }

        // PUT api/users/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] UserDto value)
        {
            _userService.UpdateUserById(
                id,
                value.Email,
                value.FirstName,
                value.LastName,
                value.RawPassword,
                value.DateOfBirth
            );
        }

        // DELETE api/users/5
        [HttpDelete("{id}")]
        public void Delete(long id)
        {
            _userService.DeleteUserById(id);
        }
    }
}