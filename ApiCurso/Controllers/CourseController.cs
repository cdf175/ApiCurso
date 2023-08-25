using ApiCurso.Models;
using ApiCurso.Services;
using Microsoft.AspNetCore.Mvc;

namespace ApiCurso.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CourseController: ControllerBase
    {
        ICourseService _courseService;
        public CourseController(ICourseService courseService) {
            _courseService = courseService; 
        }

        [HttpGet]
        public IEnumerable<Course> Index()
        {
            return _courseService.GetAll();
        }

    }



}
