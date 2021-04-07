using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ValidationDemo.Domain.Models;
using ValidationDemo.Domain.Services;

namespace ValidationDemo.Web.Controllers
{
    [ApiController]
    public class ProjectController : ControllerBase
    {
        private readonly IProjectDomainService _service;

        public ProjectController(IProjectDomainService service)
        {
            _service = service;
        }

        [HttpPost]
        public ActionResult<Project> Post(Project project)
        {
            try
            {
                var result = _service.CreateProject(project);
                return Created(HttpContext.Request.Path, result);
            }
            catch (ValidationException ve)
            {
                return UnprocessableEntity(ve.Message);
            }
        }
    }
}