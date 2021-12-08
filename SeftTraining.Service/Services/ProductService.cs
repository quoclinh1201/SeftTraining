using SeftTraining.Business.IServices;
using SeftTraining.Data.IRepositories;
using SeftTraining.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeftTraining.Business.Services
{
    public class ProductService : IProductService
    {
        private readonly IGenericRepository<Product> _genericRepository;

        public ProductService(IGenericRepository<Product> genericRepository)
        {
            _genericRepository = genericRepository;
        }
    }
}
