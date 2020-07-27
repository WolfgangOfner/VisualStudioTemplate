using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Template.Service;

namespace Template.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TemplateController : ControllerBase
    {
        private readonly ITemplateService _service;

        public TemplateController(ITemplateService service)
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