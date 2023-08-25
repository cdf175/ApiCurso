namespace ApiCurso.Models
{
    public class Course
    {
        public int CodCurso { get; set; }
        public string Nombre { get; set;}
        public string Descripcion { get; set; }
        public int Cupo { get; set; }

        public Course(int codCurso, string nombre, string descripcion, int cupo) { 
            CodCurso = codCurso;
            Nombre = nombre;
            Descripcion = descripcion;
            Cupo = cupo;
        }
    }
}
