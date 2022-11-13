using ProyectoCrud.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCrud.Controllers
{
    internal class NominaController
    {
        #region controller
        public NominaController()
        {
            _Nomina = new List<Nomina>();
        }
        private List<Nomina> _Nomina;
        public List<Nomina> Nomina { get { return _Nomina; } }
        #endregion controller


        //Metodo Llenar Lista
        #region MostarLista
        public void LlenarLista()
        {
            Nomina.Clear();
            Nomina.Add(new Nomina()
            {
                Id = 1,
                Fecha_Ingreso = new DateTime(2022, 01, 15),
                IdEmpleado =  1,
                Sueldo = 132132132,
                Dias= 30,
                Direccion = "Calle 12",
                Telefono = "300215458",
                TotalBasico= 31232131333, 
                Otros = 313135,
                Devengado= 231231233,

            });
            Nomina.Add(new Nomina()
            {
                Id = 2,
                Fecha_Ingreso = new DateTime(2010, 11, 25),
                IdEmpleado = 2,
                Sueldo = 132132132,
                Dias = 30,
                Direccion = "Calle 12",
                Telefono = "300215458",
                TotalBasico = 31232131333,
                Otros = 313135,
                Devengado = 231231233,
            });
            Nomina.Add(new Nomina()
            {
                Id = 3,
                Fecha_Ingreso = new DateTime(2015, 04, 01),
                IdEmpleado = 3,
                Sueldo = 132132132,
                Dias = 30,
                Direccion = "Calle 12",
                Telefono = "300215458",
                TotalBasico = 31232131333,
                Otros = 313135,
                Devengado = 231231233,
            });

        }
        #endregion MostrarLista

        //get
        #region get
        public void get()
        {
            List<Nomina> lista = new List<Nomina>();
            lista.AddRange(from o in Nomina select o);
            Imprimir.ImprimirNomina(lista);
        }
        #endregion get

        //getxId
        #region getbyid
        public void getbyId(int id)
        {
            List<Nomina> lista = new List<Nomina>();
            lista.AddRange(from o in Nomina where o.Id == id select o);
            Imprimir.ImprimirNomina(lista);
        }

        #endregion getbyid
        //post
        #region Post
        public void post(int id, DateTime fecha_Ingreso, int idEmpleado, int sueldo, int dias, string direccion, string telefono, int otros)
        {
            var verificarId = Nomina.Any(i => i.Id == id);
            if (!verificarId)
            {
                Nomina.Add(new Nomina()
                {
                    Id = id,
                    Fecha_Ingreso = Convert.ToDateTime(fecha_Ingreso),
                    IdEmpleado = idEmpleado,
                    Sueldo = sueldo,
                    Dias = dias,
                    Direccion = direccion,
                    Telefono = telefono,
                    TotalBasico = sueldo * dias / 30,
                    Otros = otros,
                    Devengado = (sueldo * dias / 30) + otros,
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
        public void update(int id, DateTime fecha_Ingreso, int idEmpleado, int sueldo, int dias, string direccion, string telefono, int otros)
        {
            var ReplaceItem = new Nomina
            {
                Id = id,
                Fecha_Ingreso = Convert.ToDateTime(fecha_Ingreso),
                IdEmpleado = idEmpleado,
                Sueldo = sueldo,
                Dias = dias,
                Direccion = direccion,
                Telefono = telefono,
                TotalBasico = sueldo * dias / 30,
                Otros = otros,
                Devengado = (sueldo * dias / 30) + otros,
            };
            var element = Nomina.FirstOrDefault(i => i.Id == ReplaceItem.Id);
            if (element != null)
            {
                Nomina.Remove(element);
                Nomina.Add(ReplaceItem);
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
            var element = Nomina.FirstOrDefault(i => i.Id == id);
            if (element != null)
            {
                Nomina.Remove(element);
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
