using ProyectoCrud.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCrud.Controllers
{
    internal class AreasController
    {
        #region controller
        public AreasController()
        {
            _Areas = new List<Areas>();
        }
        private List<Areas> _Areas;
        public List<Areas> Areas { get { return _Areas; } }
        #endregion controller


        //Metodo Llenar Lista
        #region MostarLista
        public void LlenarLista()
        {
            Areas.Clear();
            Areas.Add(new Areas()
            {
                Id = 1,
                Nombre = "Contaduria",
     

            });
            Areas.Add(new Areas()
            {
                Id = 2,
                Nombre = "Programacion",

            });
            Areas.Add(new Areas()
            {
                Id = 3,
                Nombre = "Marketing",

            });

        }
        #endregion MostrarLista

        //get
        #region get
        public void get()
        {
            List<Areas> lista = new List<Areas>();
            lista.AddRange(from o in Areas select o);
            Imprimir.ImprimirAreas(lista);
        }
        #endregion get

        //getxId
        #region getbyid
        public void getbyId(int id)
        {
            List<Areas> lista = new List<Areas>();
            lista.AddRange(from o in Areas where o.Id == id select o);
            Imprimir.ImprimirAreas(lista);
        }
        #endregion getbyid
        //post
        #region Post
        public void post(int id, string nombre)
        {
            var verificarId = Areas.Any(i => i.Id == id);
            if (!verificarId)
            {
                Areas.Add(new Areas()
                {
                    Id = id,
                    Nombre = nombre,
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
        public void update(int id, string nombre)
        {
            var ReplaceItem = new Areas
            {
                Id = id,
                Nombre = nombre,

            };
            var element = Areas.FirstOrDefault(i => i.Id == ReplaceItem.Id);
            if (element != null)
            {
                Areas.Remove(element);
                Areas.Add(ReplaceItem);
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
            var element = Areas.FirstOrDefault(i => i.Id == id);
            if (element != null)
            {
                Areas.Remove(element);
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
