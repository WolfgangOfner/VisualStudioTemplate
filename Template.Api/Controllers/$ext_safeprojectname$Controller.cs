using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using $ext_safeprojectname$.Service;

namespace $ext_safeprojectname$.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class $ext_safeprojectname$Controller : ControllerBase
    {
        private readonly I$ext_safeprojectname$Service _service;

        public $ext_safeprojectname$Controller(I$ext_safeprojectname$Service service)
        {
            _service = service;
        }

        [HttpGet]
        public List<string> Get()
        {
            return _service.GetAll();
        }
    }
}