using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FormationApiRest.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FormationApiRest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly ITokenGenerator _tokenGenerator;

        public LoginController(ITokenGenerator tokenGenerator)
        {
            _tokenGenerator = tokenGenerator;
        }
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] UserRecord user)
        {
            string token = _tokenGenerator.GenerateToken(user.userName, user.password);
            return Ok(new { token = token });
        }
    }

    public record UserRecord(string userName, string password);
}