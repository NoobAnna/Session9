using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using session9git.Model;
using session9git.Repository;

namespace session9git.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        readonly UserRepository _userRepository;

        public UserController(UserRepository userRepository)
        {
            _userRepository = userRepository;

        }

        [HttpGet]
        public ActionResult GetAllUsers()
        {
            List<User> users = _userRepository.GetAllUsers();

            return Ok(users);
        }


    }
}
