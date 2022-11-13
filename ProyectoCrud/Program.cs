
using ProyectoCrud.Controllers;
using System;
using System.Linq;

namespace ProyectoCrud
{
    class Program
    {
        static void Main(string[] args)
        {
            int id = 0;
            string nombre = string.Empty;
            string apellidos = string.Empty;
            string direccion = string.Empty;
            string telefono = string.Empty;
            DateTime fecha_ingreso;
            DateTime fecha;
            int idEmpleado = 0;
            int sueldo = 0;
            int dias = 0;
            int idarea = 0;
            int otros = 0;
            Console.WriteLine("CRUD WITH LINQ QUERY POO");
            EmpleadosController pc = new EmpleadosController();
            AreasController ar = new AreasController();
            NominaController no = new NominaController();
            menu Menu = new menu();
            int opc = 0;
            do
            {
                
                Menu.MenuPrincipal();
                Console.Write("Digite Opción: ");
                opc = Convert.ToInt32(Console.ReadLine());
                switch (opc) 
                {
                    case 1:
                        do
                        {
                            Menu.Menu();
                            Console.Write("Digite Opción: ");
                            opc = Convert.ToInt32(Console.ReadLine());
                            switch (opc) {
                                case 1:
                                    Console.WriteLine("Mostrar Lista");
                                    Console.ReadKey();
                                    pc.LlenarLista();
                                    pc.get();
                                    Menu.Esperar();
                                    break;

                                case 2:

                                    Console.WriteLine("Buscar Producto por Id: ");
                                    Console.ReadKey();
                                    Console.Write("Digite id: ");
                                    id = Convert.ToInt32(Console.ReadLine());
                                    Console.Clear();
                                    pc.getbyId(id);
                                    Menu.Esperar();
                                    break;

                                case 3:
                                    Console.WriteLine("Insertar producto: ");
                                    Console.Write("Introduzca Id: ");
                                    id = Convert.ToInt32(Console.ReadLine());
                                    Console.Write("Introduzca Nombre: ");
                                    nombre = (Console.ReadLine());
                                    Console.Write("Introduzca Apellidos: ");
                                    apellidos = (Console.ReadLine());
                                    Console.Write("Introduzca Direccion: ");
                                    direccion = (Console.ReadLine());
                                    Console.Write("Introduzca Telefono: ");
                                    telefono = (Console.ReadLine());
                                    Console.Write("Introduzca Fecha ingreso: ");
                                    fecha_ingreso = Convert.ToDateTime(Console.ReadLine());
                                    Console.Write("Introduzca Id Area: ");
                                    idarea = Convert.ToInt32(Console.ReadLine());
                                    pc.post(id, nombre, apellidos, direccion, telefono, fecha_ingreso,
                                        idarea);
                                    pc.get();
                                    Console.WriteLine("Presione una tecla para continuar");
                                    Menu.Esperar();
                                    Console.Clear();

                                    break;

                                case 4:
                                    Console.WriteLine("Modificar producto: ");
                                    Console.Write("Introduzca Id: ");
                                    id = Convert.ToInt32(Console.ReadLine());
                                    Console.Write("Introduzca Nombre: ");
                                    nombre = (Console.ReadLine());
                                    Console.Write("Introduzca Apellidos: ");
                                    apellidos = (Console.ReadLine());
                                    Console.Write("Introduzca Direccion: ");
                                    direccion = (Console.ReadLine());
                                    Console.Write("Introduzca Telefono: ");
                                    telefono = (Console.ReadLine());
                                    Console.Write("Introduzca Id Area: ");
                                    idarea = Convert.ToInt32(Console.ReadLine());
                                    pc.update(id, nombre, apellidos, direccion, telefono,
                                        idarea);
                                    pc.get();
                                    Menu.Esperar();

                                    break;

                                case 5:
                                    Console.WriteLine("Eliminar producto: ");
                                    Console.Write("Introduzca Id: ");
                                    id = Convert.ToInt32(Console.ReadLine());
                                    pc.DeletexId(id);
                                    pc.get();
                                    Console.ReadKey();
                                    break;

                                case 6:
                                    char confirmacion = 'F';
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Realmente quieres salir ?");
                                    confirmacion = Convert.ToChar(Console.ReadLine());
                                    if (confirmacion == 'S')
                                    {
                                        opc = 6;
                                    }
                                    else
                                    {
                                        opc = 1;
                                    }
                                    break;
                                default:
                                    Console.WriteLine("Opción inexistente, escoje una válida");
                                    break;
                            }
                        } while (opc != 6);

                        break;

                     case 2:

                        do
                        {
                            Menu.Menu();
                            Console.Write("Digite Opción: ");
                            opc = Convert.ToInt32(Console.ReadLine());
                            switch (opc)
                            {
                                case 1:
                                    Console.WriteLine("Mostrar Lista");
                                    Console.ReadKey();
                                    ar.LlenarLista();
                                    ar.get();
                                    Menu.Esperar();
                                    break;

                                case 2:

                                    Console.WriteLine("Buscar Producto por Id: ");
                                    Console.ReadKey();
                                    Console.Write("Digite id: ");
                                    id = Convert.ToInt32(Console.ReadLine());
                                    Console.Clear();
                                    ar.getbyId(id);
                                    Menu.Esperar();
                                    break;

                                case 3:
                                    Console.WriteLine("Insertar producto: ");
                                    Console.Write("Introduzca Id: ");
                                    id = Convert.ToInt32(Console.ReadLine());
                                    Console.Write("Introduzca Nombre: ");
                                    nombre = (Console.ReadLine());
                                    ar.post(id, nombre);
                                    ar.get();
                                    Console.WriteLine("Presione una tecla para continuar");
                                    Menu.Esperar();
                                    Console.Clear();

                                    break;

                                case 4:
                                    Console.WriteLine("Modificar producto: ");
                                    Console.Write("Introduzca Id: ");
                                    id = Convert.ToInt32(Console.ReadLine());
                                    Console.Write("Introduzca Nombre: ");
                                    nombre = (Console.ReadLine());
                                    ar.update(id, nombre);
                                    ar.get();
                                    Menu.Esperar();

                                    break;

                                case 5:
                                    Console.WriteLine("Eliminar producto: ");
                                    Console.Write("Introduzca Id: ");
                                    id = Convert.ToInt32(Console.ReadLine());
                                    ar.DeletexId(id);
                                    ar.get();
                                    Console.ReadKey();
                                    break;

                                case 6:
                                    char confirmacion = 'F';
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Realmente quieres salir ?");
                                    confirmacion = Convert.ToChar(Console.ReadLine());
                                    if (confirmacion == 'S')
                                    {
                                        opc = 6;
                                    }
                                    else
                                    {
                                        opc = 1;
                                    }
                                    break;
                                default:
                                    Console.WriteLine("Opción inexistente, escoje una válida");
                                    break;

                            }

                        } while (opc != 6);
                        break;

                    case 3:
                        do
                        {
                            Menu.Menu();
                            Console.Write("Digite Opción: ");
                            opc = Convert.ToInt32(Console.ReadLine());
                            switch (opc)
                            {
                                case 1:
                                    Console.WriteLine("Mostrar Lista");
                                    Console.ReadKey();
                                    no.LlenarLista();
                                    no.get();
                                    Menu.Esperar();
                                    break;

                                case 2:

                                    Console.WriteLine("Buscar Producto por Id: ");
                                    Console.ReadKey();
                                    Console.Write("Digite id: ");
                                    id = Convert.ToInt32(Console.ReadLine());
                                    no.getbyId(id);
                                    Menu.Esperar();
                                    break;

                                case 3:
                                    Console.WriteLine("Insertar producto: ");
                                    Console.Write("Introduzca Id: ");
                                    id = Convert.ToInt32(Console.ReadLine());
                                    Console.Write("Introduzca Fecha ingreso: ");
                                    fecha = Convert.ToDateTime(Console.ReadLine());
                                    Console.Write("Introduzca Id Empleado: ");
                                    idEmpleado = Convert.ToInt32(Console.ReadLine());
                                    Console.Write("Introduzca Sueldo: ");
                                    sueldo = Convert.ToInt32(Console.ReadLine());
                                    Console.Write("Introduzca Dias: ");
                                    dias = Convert.ToInt32(Console.ReadLine());
                                    Console.Write("Introduzca Direccion: ");
                                    direccion = (Console.ReadLine());
                                    Console.Write("Introduzca Telefono: ");
                                    telefono = (Console.ReadLine());
                                    Console.Write("Introduzca Otros: ");
                                    otros = Convert.ToInt32(Console.ReadLine());
                                    no.post(id,fecha,idEmpleado,sueldo, dias, direccion, telefono, otros);
                                    no.get();
                                    Console.WriteLine("Presione una tecla para continuar");
                                    Menu.Esperar();
                                    Console.Clear();

                                    break;

                                case 4:
                                    Console.WriteLine("Modificar producto: ");
                                    Console.Write("Introduzca Id: ");
                                    id = Convert.ToInt32(Console.ReadLine());
                                    Console.Write("Introduzca Fecha ingreso: ");
                                    fecha = Convert.ToDateTime(Console.ReadLine());
                                    Console.Write("Introduzca Id Empleado: ");
                                    idEmpleado = Convert.ToInt32(Console.ReadLine());
                                    Console.Write("Introduzca Sueldo: ");
                                    sueldo = Convert.ToInt32(Console.ReadLine());
                                    Console.Write("Introduzca Dias: ");
                                    dias = Convert.ToInt32(Console.ReadLine());
                                    Console.Write("Introduzca Direccion: ");
                                    direccion = (Console.ReadLine());
                                    Console.Write("Introduzca Telefono: ");
                                    telefono = (Console.ReadLine());
                                    Console.Write("Introduzca Otros: ");
                                    otros = Convert.ToInt32(Console.ReadLine());
                                    no.update(id, fecha, idEmpleado, sueldo, dias, direccion, telefono, otros);
                                    no.get();
                                    Menu.Esperar();

                                    break;

                                case 5:
                                    Console.WriteLine("Eliminar producto: ");
                                    Console.Write("Introduzca Id: ");
                                    id = Convert.ToInt32(Console.ReadLine());
                                    no.DeletexId(id);
                                    no.get();
                                    Console.ReadKey();
                                    break;

                                case 6:
                                    char confirmacion = 'F';
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Realmente quieres salir ?");
                                    confirmacion = Convert.ToChar(Console.ReadLine());
                                    if (confirmacion == 'S')
                                    {
                                        opc = 6;
                                    }
                                    else
                                    {
                                        opc = 1;
                                    }
                                    break;
                                default:
                                    Console.WriteLine("Opción inexistente, escoje una válida");
                                    break;
                            }
                        } while (opc != 6);

                        break;


                }
                    
            
            } while (opc != 4);
        }
    }

    public class menu
    {
        public void MenuPrincipal()
        {
            Console.Clear();
            Console.WriteLine("1. Empleados");
            Console.WriteLine("2. Areas");
            Console.WriteLine("3. Nomina");
            Console.WriteLine("4. Salir");
        }
        public void Menu()
        {
            Console.Clear();
            Console.WriteLine("1. Mostrar lista");
            Console.WriteLine("2. Mostrar lista por Id");
            Console.WriteLine("3. Insertar");
            Console.WriteLine("4. Editar");
            Console.WriteLine("5. Eliminaer");
            Console.WriteLine("6. Salir");
        }
        public void Esperar()
        {
            Console.ReadKey();
        }

    }

}



