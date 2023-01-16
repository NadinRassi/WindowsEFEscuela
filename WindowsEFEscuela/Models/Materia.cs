using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsEFEscuela.Models
{
    [Table("Materia")]
    public class Materia
    {
        public int Id { get; set; }

        [StringLength(50)]//long de la cadena
        [Required]
        public string Nombre { get; set; }


        [StringLength(50)]//long de la cadena
        [Required]
        public string Programa { get; set; }

    }
}
