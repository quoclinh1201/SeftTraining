using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeftTraining.Business.IServices
{
    public interface IAuthenticateService
    {
        string GenerateToken(int id, string username, string role);
    }
}
