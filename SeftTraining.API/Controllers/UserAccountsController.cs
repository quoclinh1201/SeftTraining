using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SeftTraining.Business.IServices;
using SeftTraining.Business.RequestObjects.UserAccountRequests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeftTraining.API.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [Route("api/v1/user-accounts")]
    [ApiController]
    public class UserAccountsController : ControllerBase
    {
        private readonly IUserAccountService _service;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="service"></param>
        public UserAccountsController(IUserAccountService service)
        {
            _service = service;
        }

        /// <summary>
        /// Login with username and password
        /// </summary>
        /// <remarks>
        /// aaaaaaaaaaaaaa <br /> 
        /// bbbbbbbbbbbbbbbb
        /// </remarks>
        /// <param name="request"></param>
        /// <returns></returns>
        [AllowAnonymous]
        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginRequest request)
        {
            try
            {
                var user = await _service.Login(request);
                if (user != null) return Ok(user);
                return BadRequest();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
