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
        public async Task<UserDto> Get(string email) => await this._userService.GetAsync(email);

        [HttpPost("")]
        public async Task Post([FromBody]CreateUser createUser) => await this._userService.RegisterAsync(createUser.Email, createUser.Username, createUser.Password);
    }
}
