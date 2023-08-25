using ApiCurso.Models;
using CursoBootcamp.Data.Repositories;

namespace ApiCurso.Services
{
    public class CourseService:ICourseService
    {
        IRepository<Course> _courseRepository;
        List<Course> _courses;
        public CourseService(IRepository<Course> courseRepository) { 
            _courseRepository = courseRepository;
        }

        //Servicio que trae todos los cursos registrados
        public IEnumerable<Course> GetAll()
        {
            _courses = _courseRepository.GetAll().ToList();
            return _courses;
        }
    }
}
