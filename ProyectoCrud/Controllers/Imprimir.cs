using ProyectoCrud.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoCrud.Controllers
{
    internal class Imprimir
    {
        public static void ImprimirEmpleados(List<Empleados> Empleados)
        {
            foreach (var item in Empleados)
            {
                
                Console.WriteLine(
                    "Id: {0} \n" +
                    "Nombre: {1} \n" +
                    "Apellidos: {2} \n" +
                    "Direccion: {3} \n" +
                    "Telefono: {4}  \n" +
                    "Fecha_Ingreso: {5} \n" +
                    "IdArea: {6} \n ", item.Id,
                    item.Nombre, item.Apellidos, item.Direccion,
                    item.Telefono,item.Fecha_Ingreso , item.IdArea);
            }
        }
        public static void ImprimirAreas(List<Areas> Areas)
        {
            foreach (var item in Areas)
            {

                Console.WriteLine(
                    "Id: {0} \n" +
                    "Nombre: {1} \n", item.Id,
                    item.Nombre);
            }
        }
        public static void ImprimirNomina(List<Nomina> Areas)
        {
            foreach (var item in Areas)
            {

                Console.WriteLine(
                    "Id: {0} \n" +
                    "Fecha_Ingreso: {1} \n" +
                    "Id Empleado: {2} \n" +
                    "Sueldo: {3} \n" +
                    "Dias: {4} \n" +
                    "Direccion: {5} \n" +
                    "Telefono: {6} \n" +
                    "totalBasicos: {7} \n" +
                    "Otros: {8} \n" +"Devengado: {9} \n", item.Id,
                    item.Fecha_Ingreso, item.IdEmpleado, item.Sueldo,
                    item.Dias, item.Direccion, item.Telefono, item.TotalBasico, item.Otros, item.Devengado);
            }
        }
    }
}

