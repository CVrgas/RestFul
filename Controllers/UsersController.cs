using Microsoft.AspNetCore.Mvc;

namespace NetApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NetApi : ControllerBase
    {
        private readonly ILogger<NetApi> _logger;
        static readonly Models.IUsersRepository Repository = new Models.UserRepository();

        public NetApi(ILogger<NetApi> logger)
        {
            _logger = logger;
        }

        //Create User
        [HttpPost]
        [Route("user")]
        public Models.User PostUser(Models.User user)
        {
            return Repository.AddUser(user);
        }

        //Read, Get all users
        [HttpGet]
        [Route("users")]
        public IEnumerable<Models.User> GetUsers()
        {
            return Repository.GetUsers();
        }

        // Read, get one user
        [HttpGet]
        [Route("user")]
        public Models.User GetUser(int id)
        {
            return Repository.GetUser(id);
        }

        //Update user    
        [HttpPut]
        [Route("user")]
        public Models.User PutUser(Models.User user)
        {
            return Repository.UpdateUser(user);
        }

        //Delete User
        [HttpDelete]
        [Route("user")]
        public Models.User DeleteUser(int id)
        {
            return Repository.DeleteUser(id);
        }
    }
}
