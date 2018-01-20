using Microsoft.EntityFrameworkCore;
using QuizCurso.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuizCurso.Service
{
    public class EstudianteContext : DbContext
    {
        public EstudianteContext(DbContextOptions opciones) : base(opciones)
        {

        }

        public DbSet<Estudiante> Estudiante { get; set; }
    }
}
