using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebKaiqueCrud.Models;
using WebKaiqueCrud.Services;

namespace WebKaiqueCrud.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public async Task<ActionResult<IAsyncEnumerable<User>>> GetUsers()
        {
            try
            {
                var users = await _userService.GetUsers();
                return Ok(users);
            }
            catch
            {
                return BadRequest("Request inválido");
            }
        }
    }
}