using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProfessionalPortfolio.BusinessLogic.Services;
using ProfessionalPortfolio.Model.Models;
using ProfessionalPortfolio.Dtos;

namespace ProfessionalPortfolio.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IMapper _mapper;

        public UsersController(IUserService userService, IMapper mapper)
        {
            _userService = userService;
            _mapper = mapper;
        }

        // GET: api/Users
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await _userService.GetAllUsersAsync();

            return Ok(_mapper.Map<IEnumerable<UserDto>>(result));
        }

        // GET: api/Users/5
        [HttpGet("{userId}")]
        public async Task<IActionResult> Get(int userId)
        {
            var result = await _userService.GetUserAsync(userId);

            return Ok(_mapper.Map<UserDto>(result));
        }

        // POST: api/Users
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] UserDto userDto)
        {
            await _userService.CreateUserAsync(_mapper.Map<User>(userDto));

            return Ok();
        }

        // PUT: api/Users/5
        [HttpPut("{userId}")]
        public async Task<IActionResult> Put(int userId, [FromBody] UpdateUserDto userDto)
        {
            await _userService.UpdateUserAsync(userId, userDto.PhoneNumber, userDto.EmailAddress);

            return Ok();
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{userId}")]
        public async Task<IActionResult> Delete(int userId)
        {
            await _userService.DeleteUserAsync(userId);

            return Ok();
        }
    }
}
