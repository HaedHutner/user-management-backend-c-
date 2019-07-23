using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UserManagement.Api;
using UserManagement.Dto;
using UserManagement.Service;

namespace UserManagement.Controllers
{
    [Route("api/users/{userId}/[controller]")]
    [ApiController]
    public class AddressesController : ControllerBase
    {
        private IUserService _userService;
        public AddressesController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost]
        public void CreateAddress(long userId, [FromBody] CreateAddressDto dto)
        {

        }

        [HttpGet]
        public ActionResult<List<AddressDto>> GetUserAddresses(long userId)
        {
            return null;
        }

        [HttpPut("{addressIndex}")]
        public void UpdateUserAddress(long userId, int addressIndex, [FromBody] AddressDto updateDto)
        {

        }

        [HttpDelete("{addressIndex}")]
        public void RemoveUserAddress(long userId, int addressIndex)
        {

        }
    }
}