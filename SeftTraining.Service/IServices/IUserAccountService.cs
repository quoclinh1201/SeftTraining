using SeftTraining.Business.RequestObjects.UserAccountRequests;
using SeftTraining.Business.ResponseObjects.UserAccountResponses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeftTraining.Business.IServices
{
    public interface IUserAccountService
    {
        Task<LoginResponse> Login(LoginRequest request);
    }
}
