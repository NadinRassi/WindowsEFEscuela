using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsEFEscuela.Models
{
    [Table("Docente")]
    public class Profesor
    {
        public int ProfesorId { get; set; }


        [Column(TypeName = "varchar")]//cambiamos el tipo de datos en el sqlserver
        [StringLength(50)]//long de la cadena
        [Required]
        public string Nombre { get; set; }


        [Column(TypeName = "varchar")]//cambiamos el tipo de datos en el sqlserver
        [StringLength(50)]//long de la cadena
        [Required]
        public string Apellido { get; set; }


        [Column(TypeName = "varchar")]//cambiamos el tipo de datos en el sqlserver
        [StringLength(50)]//long de la cadena
        [Required]
        public string Titulo { get; set; }
    }
}
