using QuizCurso.Models;
using System.Collections.Generic;


namespace QuizCurso.Repository
{
    public interface IEstudianteRepository
    {
        IEnumerable<Estudiante> ListarEstudiantes();
        void AgregarEstudiante(Estudiante estudiante);
    }
}
