using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCrud.Models
{
    internal class Nomina
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "campo Requerido")]

        public DateTime Fecha_Ingreso { get; set; }

        [ForeignKey("IdEmpleado")]
        public int IdEmpleado { get; set; }

        public decimal Sueldo { get; set; }

        public int Dias { get; set; }

        public string Direccion { get; set; }
        public string Telefono { get; set; }
        
        public decimal TotalBasico { get; set; }
        public int Otros { get; set; }
        public decimal Devengado { get; set; }



    }
}

