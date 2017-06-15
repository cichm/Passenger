using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Passenger.Infrastructure.Commands.Users;
using Passenger.Infrastructure.DTO;
using Passenger.Infrastructure.Services;

namespace Passenger.Api.Controllers
{
    [Route("[controller]")]
    public class UsersController : Controller
    {
        private readonly IUserService _userService;
        public UsersController(IUserService userService)
        {
            this._userService = userService;
        }

        [HttpGet("{email}")]
        public UserDto Get(string email) => this._userService.Get(email);

        [HttpPost("")]
        public void Post([FromBody]CreateUser createUser)
        {
            this._userService.Register(createUser.Email, createUser.Username, createUser.Password);
        }
    }
}
