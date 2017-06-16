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
        public async Task<IActionResult> Get(string email)
        {
            var user = await _userService.GetAsync(email);
            
            if (user == null)
            {
                return NotFound();
            }

            return Json(user);
        }

        [HttpPost("")]
        public async Task<IActionResult> Post([FromBody] CreateUser createUser)
        {
            await this._userService.RegisterAsync(createUser.Email, createUser.Username, createUser.Password);

            return Created($"users/Prequest.Email", new object());
        }
    }
}
