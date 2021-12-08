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
    public class ImageService : IImageService
    {
        private readonly IGenericRepository<Image> _genericRepository;

        public ImageService(IGenericRepository<Image> genericRepository)
        {
            _genericRepository = genericRepository;
        }
    }
}
