using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SeftTraining.Business.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeftTraining.API.Controllers
{
    [Route("api/v1/images")]
    [ApiController]
    public class ImagesController : ControllerBase
    {
        private readonly IImageService _service;

        public ImagesController(IImageService service)
        {
            _service = service;
        }
    }
}
