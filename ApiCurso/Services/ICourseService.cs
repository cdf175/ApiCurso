using ApiCurso.Models;

namespace ApiCurso.Services
{
    public interface ICourseService
    {
        public IEnumerable<Course> GetAll();
    }
}
