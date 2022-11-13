using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCrud.Models
{
    internal class Empleados
    {
        [Key]
        public int Id { get; set; }
       
        [Required(ErrorMessage = "campo Requerido")]

        public string Nombre { get; set; }
     
        public string Apellidos { get; set; }

        public string Direccion { get; set; }
        public string Telefono { get; set; }

        public DateTime Fecha_Ingreso { get; set; }

        [ForeignKey("IdArea")]
        public int IdArea { get; set; }


    }
}