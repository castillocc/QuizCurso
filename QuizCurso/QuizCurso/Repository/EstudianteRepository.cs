using Microsoft.EntityFrameworkCore;
using QuizCurso.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizCurso.Repository
{
    public class EstudianteRepository:IEstudianteRepository
    {
        private readonly Service.EstudianteContext _context;
        public EstudianteRepository(Service.EstudianteContext context)
        {
            _context = context;
        }

        public void AgregarEstudiante(Estudiante estudiante)
        {
            _context.Estudiante.Add(estudiante);
            _context.SaveChanges();

        }


        public IEnumerable<Estudiante> ListarEstudiantes()
        {
            return _context.Estudiante.ToList();
        }
    }
}
