using System.Collections.Generic;
using System;
using JonathanVilleda.Interfaz;
using static System.Console;
namespace JonathanVilleda.Model
{
    public class Menu
    {
         public void MostrarOpciones()
        {
            int opcionMenu = 100;
            do
            {
                WriteLine("1. Crear objeto Avión: ");
                WriteLine("2. Crear objeto Submarino: ");
                WriteLine("3. Mostar información de los aviones: ");
                WriteLine("4. Mostrar información de los submarinos: ");
                WriteLine("5. Salir");
                WriteLine("Ingrese su opción===>");
                if (opcionMenu == 1)
                {
                    CrearAvion(opcionMenu);
                }
                else if (opcionMenu == 2)
                {
                    CrearSubmarino(opcionMenu);
                }
                else if (opcionMenu == 3)
                {
                    Avion(opcionMenu);
                }
                else if (opcionMenu == 4)
                {
                    Submarino(opcionMenu);
                }
            } while (opcionMenu != 0);
        }
    }
}