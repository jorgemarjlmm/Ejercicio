using System;

namespace Ejercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Pila oPila = new Pila();
            Nodo oUltimoRegistro = new Nodo();

            int opcionMenu;
            int numero;

            do 
            {
                Menu();
                Console.WriteLine("Tecle la opción del menú que guste realizar;");
                opcionMenu = Convert.ToInt32(Console.ReadLine());

                switch (opcionMenu)
                {
                    case 1:
                        Console.WriteLine("Tecle el número a guardar en la pila:");
                        numero = Convert.ToInt32(Console.ReadLine());
                        oPila.Push(numero);
                        break;

                    case 2:
                        Console.WriteLine("Se ha eliminado el registro de la pila");
                        oPila.Pop();
                        break;

                    case 3:
                        Console.WriteLine("El último valor en la pila es:");
                        oUltimoRegistro = oPila.Peek();
                        Console.WriteLine(oUltimoRegistro.Dato.ToString());
                        break;

                    case 4:
                        Console.WriteLine("Los datos de la pila son:");
                        oPila.Imprimir();
                        break;

                    case 5:
                        Console.WriteLine("El valor máximo actual de la pila es:");
                        oUltimoRegistro = oPila.Peek();
                        Console.WriteLine(oUltimoRegistro.ValorMaximoPila.ToString());
                        break;
                }
            }
                while (opcionMenu <= 5) ;
            

            
            //oPila.Push(3);
            //oPila.Push(5);
            //oPila.Push(7);
            //oPila.Push(6);

            //oPila.Imprimir();

            //oPila.Pop();

            //oPila.Imprimir();

            //oPila.Peek();
        }       

        public static void Menu()
        {            
            Console.WriteLine("1.- Insertar datos en la pila;");
            Console.WriteLine("2.- Eliminar datos en la pila");
            Console.WriteLine("3.- Imprimir el último dato de la pila");
            Console.WriteLine("4.- Imprimir todos los datos de la pila");
            Console.WriteLine("5.- Obtener el máximo valor capturado en la pila");

        }
    }
}
