using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static Semana3_Proyecto_Menu.Ejemplo_if;
using static Semana3_Proyecto_Menu.Ejemplo_Switch;
using static Semana3_Proyecto_Menu.Ejemplo_for;
using static Semana3_Proyecto_Menu.Ejemplo_Dowhile;
using static Semana3_Proyecto_Menu.Ejemplo_While;


namespace Semana3_Proyecto_Menu
{
    class Principal2
    {
        
        //Funcion principal que inicia el programa
        static void Main(string[] args)
        {
            System.Console.WriteLine("Proyecto de Menu");
            System.Console.WriteLine("Primer Programa Usando Estructuras");

            System.Console.ReadKey();

            int repetir;

            //menu_interno();

            do
            {
                Console.Clear();
                menu_interno();

                System.Console.WriteLine("Ingrese 1 para repetir menú");
                System.Console.WriteLine("Ingrese 2 para salir");
                repetir = Int32.Parse(Console.ReadLine());
                
            } while (repetir == 1);

        } //Cierre de función principal


        //Inicio de funciones interna
        static void menu_interno()
        {
            string opcion;
            int opcionint;

            System.Console.WriteLine("Menu Principal");
            System.Console.WriteLine("1. Ejemplo If");
            System.Console.WriteLine("2. Ejemplo Switch");
            System.Console.WriteLine("3. Ejemplo For");
            System.Console.WriteLine("4. Ejemplo Wor");
            System.Console.WriteLine("5. Ejemplo Do While");

            System.Console.WriteLine("Selecciona tu opcion: ");
            opcion = Console.ReadLine();
            opcionint = Int32.Parse(opcion);

            switch (opcionint)
            {
                case 1:
                    
                    estructura_if();

                    break;

                case 2:
                    
                    estructura_switch();
                    break;

                case 3:
                    
                    estructura_for();
                    break;

                case 4:
                    
                    estructura_While();
                    break;
                case 5:
                    
                    estructura_Dowhile();
                    break;

                default:
                    System.Console.WriteLine("opcion no valida");
                    break;
                     
            }

        }

        //Función interna para ejemplo if
        static void programa_if()
        {
            System.Console.WriteLine("Aqui llamo ejemplo If");

        }

        //Función interna para ejemplo switch
        static void programa_switch()
        {
            System.Console.WriteLine("Aqui llamo ejemplo Switch");
        }

        //Función interna para ejemplo for
        static void programa_for()
        {
            System.Console.WriteLine("Aqui llamo ejemplo For");
        }

        //Función interna para ejemplo while
        static void programa_while()
        {
            System.Console.WriteLine("Aqui llamo ejemplo While");
        }

        //Función interna para ejemplo dowhile
        static void programa_dowhile()
        {
            System.Console.WriteLine("Aqui llamo ejemplo DoWhile");
        }




    }
}
