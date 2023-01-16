using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsEFEscuela.Models
{
    [Table("Aula")]
    public class Aula
    {
        public int Id { get; set; }


        [Required]
        public int Capacidad { get; set; }


        [Column(TypeName = "char")]
        [StringLength(1)]//long de la cadena
        [Required]
        public string Codigo { get; set; }


    }
}
