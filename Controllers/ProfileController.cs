using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RecodeFitness.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfileController : ControllerBase
    {
        [HttpGet]
        public Profile GetProfile()
        {
            return new Profile { Name = "Almando Mason" };
        }
    }

    public class Profile
    {
        public string Name {  get; set; }        
    }
}
