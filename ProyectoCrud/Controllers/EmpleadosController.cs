using ProyectoCrud.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCrud.Controllers
{
    internal class EmpleadosController
    {
        #region controller
        public EmpleadosController()
        {
            _Empleados = new List<Empleados>();
        }
        private List<Empleados> _Empleados;
        public List<Empleados> Empleados { get { return _Empleados; } }
        #endregion controller


        //Metodo Llenar Lista
        #region MostarLista
        public void LlenarLista()
        {
            Empleados.Clear();
            Empleados.Add(new Empleados()
            {
                Id = 1,
                Nombre = "David",
                Apellidos = "Jurado M",
                Direccion = "Calle 10",
                Telefono = "301235456",
                Fecha_Ingreso = new DateTime(2018,10,23),
                IdArea = 1
 
            });
            Empleados.Add(new Empleados()
            {
                Id = 2,
                Nombre = "Peter",
                Apellidos = "Parker",
                Direccion = "Calle 101",
                Telefono = "3015897452",
                Fecha_Ingreso = new DateTime(2020, 11, 15),
                IdArea = 2
            });
            Empleados.Add(new Empleados()
            {
                Id = 3,
                Nombre = "Clark",
                Apellidos = "kent",
                Direccion = "Calle 20",
                Telefono = "7895482163",
                Fecha_Ingreso = new DateTime(2020, 11, 15),
                IdArea = 1
            });
            Empleados.Add(new Empleados()
            {
                Id = 4,
                Nombre = "Mauricio",
                Apellidos = "Vanegas",
                Direccion = "Carrera 210",
                Telefono = "3001485696",
                Fecha_Ingreso = new DateTime(2020, 11, 15),
                IdArea = 1
            });
            Empleados.Add(new Empleados()
            {
                Id = 5,
                Nombre = "Maria",
                Apellidos = "Maldonado",
                Direccion = "Carrera 310",
                Telefono = "300214589",
                Fecha_Ingreso = new DateTime(2020, 11, 15),
                IdArea = 3
            });

        }
        #endregion MostrarLista

        //get
        #region get
        public void get()
        {
            List<Empleados> lista = new List<Empleados>();
            lista.AddRange(from o in Empleados select o);
            Imprimir.ImprimirEmpleados(lista);
        }
        #endregion get


        //getxId
        #region getbyid
        public void getbyId(int id)
        {
            List<Empleados> lista = new List<Empleados>();
            lista.AddRange(from o in Empleados where o.Id == id select o);
            Imprimir.ImprimirEmpleados(lista);
        }
        #endregion getbyid
        //post
        #region Post
        public void post(int id, string nombre, string apellidos,
                    string direccion, string telefono,DateTime fecha_ingreso, int idarea)
        {
            var verificarId = Empleados.Any(i => i.Id == id);
            if (!verificarId)
            {
                Empleados.Add(new Empleados()
                {
                    Id = id,
                    Nombre = nombre,
                    Apellidos = apellidos,
                    Direccion = direccion,
                    Telefono = telefono,
                    Fecha_Ingreso = Convert.ToDateTime(fecha_ingreso),
                    IdArea = idarea
                });
                Console.WriteLine("201");
            }
            else
            {
                Console.WriteLine("Este Id ya existe");
            }
        }
        #endregion Post
        //put
        #region Update
        public void update(int id, string nombre, string apellidos,
                    string direccion, string telefono, int idarea)
        {
            var ReplaceItem = new Empleados
            {
                Id = id,
                Nombre = nombre,
                Apellidos = apellidos,
                Direccion = direccion,
                Telefono = telefono,
                IdArea = idarea
            };
            var element = Empleados.FirstOrDefault(i => i.Id == ReplaceItem.Id);
            if (element != null)
            {
                Empleados.Remove(element);
                Empleados.Add(ReplaceItem);
                Console.WriteLine("Registro Actualizado con exito!");
            }
            else
            {
                Console.WriteLine("505");
            }


        }
        #endregion Update
        //delete
        #region delete
        public void DeletexId(int id)
        {
            //var EliminarItem = new Productos { Id = id };
            var element = Empleados.FirstOrDefault(i => i.Id == id);
            if (element != null)
            {
                Empleados.Remove(element);
                Console.WriteLine("Registro con Id: " + id + " fue eliminado");
            }
            else
            {
                Console.WriteLine("No hay elemento con ese Id");
            }
        }
        #endregion delete
    }
}




