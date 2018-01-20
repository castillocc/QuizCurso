using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QuizCurso.Models
{
    public class Estudiante
    {
       
        public int Id { get; set; }
        [Display(Name = "Nombre")]
        [StringLength(15, MinimumLength = 5,ErrorMessage ="Debe digitar un nombre mayor a 5 caracteres y menores a 15")]
        [Required(ErrorMessage = "Ingrese su nombre")]
        public string Nombre { get; set; }

        [Display(Name = "Apellido")]
        [Required(ErrorMessage = "Ingrese su apellido")]
        public string Apellido { get; set; }
        [Required(ErrorMessage ="El numero telefonico es un campo requerido")]
        [Display(Name ="Numero Telefonico")]
        public int Telefono { get; set; }

        [Display(Name = "Correo Electronico")]
        [RegularExpression(@"^([a-zA-Z0-9_\.\-])+\@(([a-zA-Z0-9\-])+\.)+([a-zA-Z0-9]{2,4})+$",
        ErrorMessage = "Ingrese un correo con el formato correcto")]
        public string Correo { get; set; }

    }
}

/*
 - Usando Data Anotations y Data Validations vamos a poder retricciones en:
    * Nombre (minimo 5 caracteres maximo 15),
    * Formato de teléfono "0000-0000"
    * Validación de email con expresión regular
     */
