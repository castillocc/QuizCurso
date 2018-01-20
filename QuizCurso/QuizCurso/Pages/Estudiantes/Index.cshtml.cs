using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using QuizCurso.Models;
using QuizCurso.Repository;

namespace QuizCurso.Pages.Estudiantes
{
    public class IndexModel : PageModel
    {

        private  IEstudianteRepository EstudiantesRepository { get; set; }
        public IndexModel(IEstudianteRepository estudiantesRepository)
        {
            EstudiantesRepository = estudiantesRepository;
        }

        public IList<Estudiante> Estudiante { get; set; }

        public async Task OnGetAsync()
        {
            Estudiante = EstudiantesRepository.ListarEstudiantes().ToList();
        }
    }
}
