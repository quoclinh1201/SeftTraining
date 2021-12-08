using SeftTraining.Business.Enum;
using SeftTraining.Business.IServices;
using SeftTraining.Business.RequestObjects.UserAccountRequests;
using SeftTraining.Business.ResponseObjects.UserAccountResponses;
using SeftTraining.Data.IRepositories;
using SeftTraining.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeftTraining.Business.Services
{
    public class UserAccountService : IUserAccountService
    {
        private readonly IGenericRepository<UserAccount> _genericRepository;
        private readonly IAuthenticateService _authenticateService;

        public UserAccountService(IGenericRepository<UserAccount> genericRepository, IAuthenticateService authenticateService)
        {
            _genericRepository = genericRepository;
            _authenticateService = authenticateService;
        }

        public async Task<LoginResponse> Login(LoginRequest request)
        {
            var user = await _genericRepository.FindAsync(u => u.Username.Equals(request.Username) && u.Password.Equals(request.Password) && u.Status == (int) UserAccountStatus.Active);
            if(user != null)
            {
                var token = _authenticateService.GenerateToken(user.Id, user.Username, user.Role);
                return new LoginResponse { FullName = user.FullName, Role = user.Role, AccessToken = token };
            }
            return null;
        }
    }
}
