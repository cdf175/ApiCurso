using ApiCurso.Models;
using CursoBootcamp.Data.Repositories;

namespace ApiCurso.Data.Repositories
{
    public class CourseRepository : IRepository<Course>
    {
        public void Add(Course entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Course entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Course> GetAll()
        {
            List<Course> list = new List<Course>();
            list!.Add(new Course(1, "Biologia","Curso de biologia",20));
            list!.Add(new Course(2, "Literatura", "Curso de literatura", 18));
            list!.Add(new Course(3, "Geometria", "Curso de geometria", 25));
            list!.Add(new Course(4, "Algebra", "Curso de algebra", 32));
            list!.Add(new Course(5, "Ingles", "Curso de ingles", 10));

            return list;
        }

        public Course GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Course entity)
        {
            throw new NotImplementedException();
        }
    }
}
