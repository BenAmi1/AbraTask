using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Web;
using System.Reflection.PortableExecutable;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.WebUtilities;
using AbraTaskAPI.Repositories;


namespace AbraTaskAPI.Controllers
{
    [ApiController]
    [Route("Users")]
    public class UserDataController : Controller
    {
        private readonly IUsersRepository r_usersRepository;

        public UserDataController(IUsersRepository usersRepository)
        {
            this.r_usersRepository = usersRepository;
        }

        [HttpGet]
        [Route("{gender}")]
        public async Task<IActionResult> GetRegionAsync(string i_Gender)
        {
            var users = await r_usersRepository.GetAsync(i_Gender);
            if (users == null)
                return NotFound();

            return Ok(users);
        }

    }
}
