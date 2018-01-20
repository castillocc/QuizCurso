using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using QuizCurso.Models;
using QuizCurso.Repository;

namespace QuizCurso.Pages.Estudiantes
{
    public class CreateModel : PageModel
    {
        private IEstudianteRepository EstudiantesRepository { get; set; }

        public CreateModel(IEstudianteRepository estudiantesRepository)
        {
            EstudiantesRepository = estudiantesRepository;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Estudiante Estudiante { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            EstudiantesRepository.AgregarEstudiante(Estudiante);
            /*  _context.Estudiante.Add(Estudiante);
              await _context.SaveChangesAsync();
              /=*/
            return RedirectToPage("./Index");
        }
    }
}