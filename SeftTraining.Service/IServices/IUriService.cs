using SeftTraining.Business.ResponseObjects.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeftTraining.Business.IServices
{
    public interface IUriService
    {
        Uri GetPageUri(PaginationFilter filter, string route);
    }
}
