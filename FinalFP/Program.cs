using System;
using System.Linq;

namespace FinalFP
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Variables
            int opcionMenuInicial = 0;
            int opcionGestionUsuarios = 0;
            int opcionGestionArticulos = 0;
            String[,] usuarios = new string[20, 4];
            String[,] articulos = new string[20, 4];


            usuarios[0, 0] = "usuario1";
            usuarios[0, 1] = "1111111111";
            usuarios[0, 2] = "usuario1@gmail.com";
            usuarios[0, 3] = "1111111111";

            usuarios[1, 0] = "usuario2";
            usuarios[1, 1] = "2222222222";
            usuarios[1, 2] = "usuario2@gmail.com";
            usuarios[1, 3] = "2222222222";

            usuarios[2, 0] = "usuario3";
            usuarios[2, 1] = "3333333333";
            usuarios[2, 2] = "usuario3@gmail.com";
            usuarios[2, 3] = "3333333333";

            articulos[0, 0] = "articulo1";
            articulos[0, 1] = "111111";
            articulos[0, 2] = "10";
            articulos[0, 3] = "10000";

            articulos[1, 0] = "articulo2";
            articulos[1, 1] = "222222";
            articulos[1, 2] = "20";
            articulos[1, 3] = "20000";

            do
            {
                opcionMenuInicial = MenuInicial();

                switch (opcionMenuInicial)
                {

                    //Gestion de usuarios
                    case 1:

                        do
                        {
                            Console.Clear();
                            opcionGestionUsuarios = GestionUsuarios();

                            switch (opcionGestionUsuarios)
                            {
                                case 1:
                                    VerUsuarios(usuarios);
                                    break;

                                case 2:
                                    AgregarUsuario(usuarios);

                                    break;
                                case 3:
                                    EditarUsuario(usuarios);

                                    break;
                                case 4:
                                    break;

                                default:
                                    Console.WriteLine("Opcion no valida");
                                    break;
                            }
                        }
                        while (opcionGestionUsuarios != 4);

                        break;


                    //Gestion de articulos
                    case 2:

                        do
                        {
                            Console.Clear();
                            opcionGestionArticulos = GestionArticulos();

                            switch (opcionGestionArticulos)
                            {
                                case 1:
                                    VerArticulos(articulos);
                                    break;
                                case 2:
                                    AgregarArticulo(articulos);
                                    break;
                                case 3:
                                    EditarArticulo(articulos);
                                    break;
                                case 4:
                                    break;

                                default:
                                    Console.WriteLine("Opcion no valida");
                                    break;

                            }

                        } while (opcionGestionArticulos != 4);

                        break;

                    //Gestion de ventas
                    case 3:

                        RegistrarVenta(usuarios, articulos);

                        break;


                    //Salir del programa
                    case 4:
                        break;


                    //Opcion no valida
                    default:
                        Console.WriteLine("Opcion no valida");
                        break;
                }
            } while (opcionMenuInicial != 4);

        }

        static int MenuInicial()
        {
            Console.CursorVisible = false;
            string[] opciones = { "Gestion de usuarios", "Gestion de articulos", "Gestion de pedidos", "Salir del programa" };
            int seleccion = 0;
            ConsoleKey tecla;

            do
            {
                Console.Clear();
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine("     Bienvenido al menu del supermercado");
                Console.WriteLine("---------------------------------------------\n");
                Console.WriteLine("Usa las flechas para moverte y presiona ENTER:\n");

                for (int i = 0; i < opciones.Length; i++)
                {
                    if (i == seleccion)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"> {opciones[i]}");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.WriteLine($"  {opciones[i]}");
                    }
                }

                tecla = Console.ReadKey(true).Key;

                if (tecla == ConsoleKey.UpArrow) seleccion = (seleccion == 0) ? 3 : seleccion - 1;
                if (tecla == ConsoleKey.DownArrow) seleccion = (seleccion == 3) ? 0 : seleccion + 1;

            } while (tecla != ConsoleKey.Enter);

            return seleccion + 1;
        }


        static int GestionUsuarios()
        {
            Console.CursorVisible = false;
            string[] opciones = { "Ver lista de usuarios", "Agregar usuario", "Editar info del usuario", "Volver al menu principal" };
            int seleccion = 0;
            ConsoleKey tecla;

            do
            {
                Console.Clear();
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine("     Bienvenido al Gestor de usuarios");
                Console.WriteLine("---------------------------------------------\n");
                Console.WriteLine("Usa las flechas para moverte y presiona ENTER:\n");

                for (int i = 0; i < opciones.Length; i++)
                {
                    if (i == seleccion)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"> {opciones[i]}");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.WriteLine($"  {opciones[i]}");
                    }
                }

                tecla = Console.ReadKey(true).Key;

                if (tecla == ConsoleKey.UpArrow) seleccion = (seleccion == 0) ? 3 : seleccion - 1;
                if (tecla == ConsoleKey.DownArrow) seleccion = (seleccion == 3) ? 0 : seleccion + 1;

            } while (tecla != ConsoleKey.Enter);

            return seleccion + 1;
        }

        static int GestionArticulos()
        {
            Console.CursorVisible = false;
            string[] opciones = { "Ver lista de articulos", "Agregar articulo", "Editar info del articulo", "Volver al menu principal" };
            int seleccion = 0;
            ConsoleKey tecla;

            do
            {
                Console.Clear();
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine("     Bienvenido al Gestor de articulos");
                Console.WriteLine("---------------------------------------------\n");
                Console.WriteLine("Usa las flechas para moverte y presiona ENTER:\n");

                for (int i = 0; i < opciones.Length; i++)
                {
                    if (i == seleccion)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"> {opciones[i]}");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.WriteLine($"  {opciones[i]}");
                    }
                }

                tecla = Console.ReadKey(true).Key;

                if (tecla == ConsoleKey.UpArrow) seleccion = (seleccion == 0) ? 3 : seleccion - 1;
                if (tecla == ConsoleKey.DownArrow) seleccion = (seleccion == 3) ? 0 : seleccion + 1;

            } while (tecla != ConsoleKey.Enter);

            return seleccion + 1;
        }

        static void AgregarUsuario(String[,] usuarios)
        {

            Console.CursorVisible = true;

            for (int i = 0; i < usuarios.GetLength(0); i++)
            {
                if (usuarios[i, 0] == null)
                {
                    Console.Clear();

                    Console.WriteLine("---------------------------------------------");
                    Console.WriteLine("             añadir usuario");
                    Console.WriteLine("---------------------------------------------\n");


                    //Ingresar nombre
                    Console.WriteLine("Ingrese el nombre completo del usuario:");
                    usuarios[i, 0] = Console.ReadLine();

                    //Ingresar numero de documento
                    do
                    {
                        Console.WriteLine("Ingrese el numero de documento del usuario:");
                        usuarios[i, 1] = Console.ReadLine();

                        if ((usuarios[i, 1].Length < 6) || (!usuarios[i, 1].All(char.IsDigit)))
                        {
                            Console.WriteLine("Numero de documento invalido. Por favor, ingrese un numero de documento valido.");
                        }
                    } while ((usuarios[i, 1].Length < 6) || (!usuarios[i, 1].All(char.IsDigit)));

                    //Ingresar correo
                    do
                    {
                        Console.WriteLine("Ingrese el correo del usuario:");
                        usuarios[i, 2] = Console.ReadLine();

                        if (!usuarios[i, 2].Contains("@") || !usuarios[i, 2].Contains(".com"))
                        {
                            Console.WriteLine("Correo invalido. Por favor, ingrese un correo valido.");
                        }
                    } while (!usuarios[i, 2].Contains("@") || !usuarios[i, 2].Contains(".com"));

                    //Ingresar telefono
                    do
                    {
                        Console.WriteLine("Ingrese el numero de telefono del usuario:");
                        usuarios[i, 3] = Console.ReadLine();

                        if ((usuarios[i, 3].Length != 10) || (!usuarios[i, 3].All(char.IsDigit)))
                        {
                            Console.WriteLine("Numero de telefono invalido. Por favor, ingrese un numero de telefono valido.");
                        }
                    } while (usuarios[i, 3].Length != 10 || (!usuarios[i, 3].All(char.IsDigit)));


                    Console.WriteLine("Usuario agregado correctamente");
                    Console.WriteLine("Presione cualquier tecla para volver al menu...");
                    Console.ReadKey();

                    return;

                }
            }
        }

        static void VerUsuarios(String[,] usuarios)
        {
            Console.Clear();
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("             Lista de usuarios");
            Console.WriteLine("---------------------------------------------\n");

            Console.Write(" | Nombre | Documento | Correo | Telefono |\n\n");
            for (int i = 0; i < usuarios.GetLength(0); i++)
            {
                if (usuarios[i, 0] != null)
                {
                    Console.Write((i + 1) + ". |" + usuarios[i, 0] + " | ");
                    Console.Write(usuarios[i, 1] + " | ");
                    Console.Write(usuarios[i, 2] + " | ");
                    Console.Write(usuarios[i, 3] + " | ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Presione cualquier tecla para volver al menu...");
            Console.ReadKey();
        }



        static void EditarUsuario(String[,] usuarios)
        {
            Console.CursorVisible = false;

            //Variables
            int seleccion = 0;
            int datoAEditar = 0;
            int cantidadUsuarios = 0;
            string[] opciones = { "Nombre", "Documento de identidad", "Correo", "Telefono" };
            ConsoleKey tecla;


            //Contar la cantidad de usuarios
            for (int i = 0; i < usuarios.GetLength(0); i++)
            {
                if (usuarios[i, 0] != null)
                {
                    cantidadUsuarios++;
                }
            }

            //Elegir que usuario se desea editar
            do
            {
                Console.Clear();
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine("     Bienvenido al Editor de usuarios");
                Console.WriteLine("---------------------------------------------\n");
                Console.WriteLine("Usa las flechas para moverte y presiona ENTER:\n");


                for (int i = 0; i < usuarios.GetLength(0); i++)
                {
                    if (usuarios[i, 0] != null)
                    {
                        if (i == seleccion)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                        }
                        Console.Write((i + 1) + ". |" + usuarios[i, 0] + " | ");
                        Console.Write(usuarios[i, 1] + " | ");
                        Console.Write(usuarios[i, 2] + " | ");
                        Console.Write(usuarios[i, 3] + " | ");
                        Console.ResetColor();
                    }

                    Console.WriteLine();
                }

                tecla = Console.ReadKey(true).Key;

                if (tecla == ConsoleKey.UpArrow) seleccion = (seleccion == 0) ? cantidadUsuarios - 1 : seleccion - 1;
                if (tecla == ConsoleKey.DownArrow) seleccion = (seleccion == cantidadUsuarios - 1) ? 0 : seleccion + 1;

            } while (tecla != ConsoleKey.Enter);

            //Elegir que dato del usuario se desea editar
            do
            {
                Console.Clear();
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine("     Que dato desea editar");
                Console.WriteLine("---------------------------------------------\n");
                Console.WriteLine("Usa las flechas para moverte y presiona ENTER:\n");


                for (int i = 0; i < opciones.Length; i++)
                {
                    if (i == datoAEditar)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"> {opciones[i]}");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.WriteLine($"  {opciones[i]}");
                    }
                }

                tecla = Console.ReadKey(true).Key;

                if (tecla == ConsoleKey.UpArrow) datoAEditar = (datoAEditar == 0) ? 3 : datoAEditar - 1;
                if (tecla == ConsoleKey.DownArrow) datoAEditar = (datoAEditar == 3) ? 0 : datoAEditar + 1;

            } while (tecla != ConsoleKey.Enter);


            Console.CursorVisible = true;
            //Editar el dato seleccionado
            switch (datoAEditar)
            {
                case 0:

                    //Editar nombre
                    Console.WriteLine("Ingrese el nuevo nombre completo del usuario:");
                    usuarios[seleccion, 0] = Console.ReadLine();
                    break;

                case 1:

                    //Editar numero de documento
                    do
                    {
                        Console.WriteLine("Ingrese el nuevo numero de documento del usuario:");
                        usuarios[seleccion, 1] = Console.ReadLine();

                        if ((usuarios[seleccion, 1].Length < 6) || (!usuarios[seleccion, 1].All(char.IsDigit)))
                        {
                            Console.WriteLine("Numero de documento invalido. Por favor, ingrese un numero de documento valido.");
                        }
                    } while ((usuarios[seleccion, 1].Length < 6) || (!usuarios[seleccion, 1].All(char.IsDigit)));
                    break;

                case 2:

                    //Ingresar correo
                    do
                    {
                        Console.WriteLine("Ingrese el nuevo correo del usuario:");
                        usuarios[seleccion, 2] = Console.ReadLine();

                        if (!usuarios[seleccion, 2].Contains("@") || !usuarios[seleccion, 2].Contains(".com"))
                        {
                            Console.WriteLine("Correo invalido. Por favor, ingrese un correo valido.");
                        }
                    } while (!usuarios[seleccion, 2].Contains("@") || !usuarios[seleccion, 2].Contains(".com"));
                    break;

                case 3:
                    do
                    {
                        Console.WriteLine("Ingrese el nuevo numero de telefono del usuario:");
                        usuarios[seleccion, 3] = Console.ReadLine();

                        if ((usuarios[seleccion, 3].Length != 10) || (!usuarios[seleccion, 3].All(char.IsDigit)))
                        {
                            Console.WriteLine("Numero de telefono invalido. Por favor, ingrese un numero de telefono valido.");
                        }
                    } while (usuarios[seleccion, 3].Length != 10 || (!usuarios[seleccion, 3].All(char.IsDigit)));



                    break;
            }

            Console.WriteLine("Informacion editada correctamente");

            Console.ReadKey();

        }




        static void AgregarArticulo(String[,] articulo)
        {

            Console.CursorVisible = true;

            for (int i = 0; i < articulo.GetLength(0); i++)
            {
                if (articulo[i, 0] == null)
                {
                    Console.Clear();

                    Console.WriteLine("---------------------------------------------");
                    Console.WriteLine("             añadir articulo");
                    Console.WriteLine("---------------------------------------------\n");


                    //Ingresar nombre del articulo

                    Console.WriteLine("Ingrese el nombre del articulo:");
                    articulo[i, 0] = Console.ReadLine();

                    //Ingresar codigo del articulo
                    do
                    {
                        Console.WriteLine("Ingrese el codigo del articulo:");
                        articulo[i, 1] = Console.ReadLine();

                        if (!articulo[i, 1].All(char.IsDigit))
                        {
                            Console.WriteLine("Codigo de articulo invalido. Por favor, ingrese un codigo de articulo valido.");
                        }
                    } while (!articulo[i, 1].All(char.IsDigit));

                    //Ingresar cantidad del articulo
                    do
                    {
                        Console.WriteLine("Ingrese la cantidad que desea añadir:");
                        articulo[i, 2] = Console.ReadLine();

                        if ((!articulo[i, 2].All(char.IsDigit)) || (int.Parse(articulo[i, 2]) < 0))
                        {
                            Console.WriteLine("Cantidad invalida. Por favor, ingrese una cantidad valida.");
                        }
                    } while ((!articulo[i, 2].All(char.IsDigit)) || (int.Parse(articulo[i, 2]) < 0));

                    //Ingresar precio del articulo
                    do
                    {
                        Console.WriteLine("Ingrese el precio del articulo:");
                        articulo[i, 3] = Console.ReadLine();
                        if (!articulo[i, 3].All(char.IsDigit))
                        {
                            Console.WriteLine("Precio invalido. Por favor, ingrese un precio valido.");
                        }
                    } while (!articulo[i, 3].All(char.IsDigit));


                    Console.WriteLine("Articulo agregado correctamente");
                    Console.WriteLine("Presione cualquier tecla para volver al menu...");
                    Console.ReadKey();

                    return;

                }
            }
        }



        static void VerArticulos(String[,] articulos)
        {
            Console.Clear();
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("             Lista de articulos");
            Console.WriteLine("---------------------------------------------\n");

            Console.Write(" | Nombre | Codigo | Cantidad | Precio |\n\n");
            for (int i = 0; i < articulos.GetLength(0); i++)
            {
                if (articulos[i, 0] != null)
                {
                    Console.Write((i + 1) + ". |" + articulos[i, 0] + " | ");
                    Console.Write(articulos[i, 1] + " | ");
                    Console.Write(articulos[i, 2] + " | ");
                    Console.Write(articulos[i, 3] + " | ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Presione cualquier tecla para volver al menu...");
            Console.ReadKey();
        }






        static void EditarArticulo(String[,] articulos)
        {
            Console.CursorVisible = false;

            //Variables
            int seleccion = 0;
            int datoAEditar = 0;
            int cantidadArticulos = 0;
            string[] opciones = { "Nombre", "Codigo", "Cantidad", "Precio" };
            ConsoleKey tecla;


            //Contar la cantidad de articulos
            for (int i = 0; i < articulos.GetLength(0); i++)
            {
                if (articulos[i, 0] != null)
                {
                    cantidadArticulos++;
                }
            }

            //Elegir que articulo se desea editar
            do
            {
                Console.Clear();
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine("     Bienvenido al Editor de articulos");
                Console.WriteLine("---------------------------------------------\n");
                Console.WriteLine("Usa las flechas para moverte y presiona ENTER:\n");


                for (int i = 0; i < articulos.GetLength(0); i++)
                {
                    if (articulos[i, 0] != null)
                    {
                        if (i == seleccion)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                        }
                        Console.Write((i + 1) + ". |" + articulos[i, 0] + " | ");
                        Console.Write(articulos[i, 1] + " | ");
                        Console.Write(articulos[i, 2] + " | ");
                        Console.Write(articulos[i, 3] + " | ");
                        Console.ResetColor();
                    }

                    Console.WriteLine();
                }

                tecla = Console.ReadKey(true).Key;

                if (tecla == ConsoleKey.UpArrow) seleccion = (seleccion == 0) ? cantidadArticulos - 1 : seleccion - 1;
                if (tecla == ConsoleKey.DownArrow) seleccion = (seleccion == cantidadArticulos - 1) ? 0 : seleccion + 1;

            } while (tecla != ConsoleKey.Enter);

            //Elegir que dato del articulo se desea editar
            do
            {
                Console.Clear();
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine("     Que dato desea editar");
                Console.WriteLine("---------------------------------------------\n");
                Console.WriteLine("Usa las flechas para moverte y presiona ENTER:\n");


                for (int i = 0; i < opciones.Length; i++)
                {
                    if (i == datoAEditar)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"> {opciones[i]}");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.WriteLine($"  {opciones[i]}");
                    }
                }

                tecla = Console.ReadKey(true).Key;

                if (tecla == ConsoleKey.UpArrow) datoAEditar = (datoAEditar == 0) ? 3 : datoAEditar - 1;
                if (tecla == ConsoleKey.DownArrow) datoAEditar = (datoAEditar == 4) ? 0 : datoAEditar + 1;

            } while (tecla != ConsoleKey.Enter);


            Console.CursorVisible = true;

            //Editar el dato seleccionado
            switch (datoAEditar)
            {
                case 0:

                    //Editar nombre
                    Console.WriteLine("Ingrese el nuevo nombre del articulo:");
                    articulos[seleccion, 0] = Console.ReadLine();
                    break;

                case 1:

                    //Editar codigo
                    do
                    {
                        Console.WriteLine("Ingrese el nuevo codigo del articulo:");
                        articulos[seleccion, 1] = Console.ReadLine();

                        if (!articulos[seleccion, 1].All(char.IsDigit))
                        {
                            Console.WriteLine("Codigo de articulo invalido. Por favor, ingrese un codigo de articulo valido.");
                        }
                    } while (!articulos[seleccion, 1].All(char.IsDigit));

                    break;

                case 2:

                    //Editar cantidad

                    do
                    {
                        Console.WriteLine("Ingrese la nueva cantidad que desea añadir:");
                        articulos[seleccion, 2] = Console.ReadLine();

                        if ((!articulos[seleccion, 2].All(char.IsDigit)) || (int.Parse(articulos[seleccion, 2]) < 0))
                        {
                            Console.WriteLine("Cantidad invalida. Por favor, ingrese una cantidad valida.");
                        }
                    } while ((!articulos[seleccion, 2].All(char.IsDigit)) || (int.Parse(articulos[seleccion, 2]) < 0));

                    break;

                case 3:

                    //Editar precio

                    do
                    {
                        Console.WriteLine("Ingrese el nuevo precio del articulo:");
                        articulos[seleccion, 3] = Console.ReadLine();
                        if (!articulos[seleccion, 3].All(char.IsDigit))
                        {
                            Console.WriteLine("Precio invalido. Por favor, ingrese un precio valido.");
                        }
                    } while (!articulos[seleccion, 3].All(char.IsDigit));

                    break;
            }

            Console.WriteLine("Informacion editada correctamente");
            Console.ReadKey();
        }



        static void RegistrarVenta(String[,] usuarios, String[,] articulos)
        {


        }




    }
}