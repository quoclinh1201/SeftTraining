using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SeftTraining.Business.IServices;
using SeftTraining.Business.RequestObjects.UserAccountRequests;
using SeftTraining.Business.ResponseObjects.Commons;
using SeftTraining.Business.ResponseObjects.UserAccountResponses;
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
                if (user != null) return Ok(new Response<LoginResponse>(user));
                return BadRequest(new Response<LoginResponse> { Message = "Invalid username or password"});
            }
            catch (Exception ex)
            {
                return BadRequest(new Response<LoginResponse> { Message = ex.Message});
            }
        }
    }
}
