using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsEFEscuela.Models
{
    [Table("Alumno")]
    public class Alumno
    {
        [Key]
        public int IdAlumno { get; set; }


        [Column(TypeName = "varchar")]//cambiamos el tipo de datos en el sqlserver
        [StringLength(50)]//long de la cadena
        [Required]
        public string Nombre { get; set; }


        [Column(TypeName = "varchar")]//cambiamos el tipo de datos en el sqlserver
        [StringLength(50)]//long de la cadena
        [Required]
        public string Apellido { get; set; }

        public DateTime? FechaNacimiento { get; set; }


    }
}
