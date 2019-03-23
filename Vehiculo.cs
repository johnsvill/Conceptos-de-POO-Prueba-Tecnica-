using System.Collections.Generic;
using System;
using static System.Console;
namespace PrimerJonathanPrimerVilleda.Model
{
    public class Vehiculo
    {
        private float velocidadMaxima;
        private float velocidadMinima;
        private string marca;
        private string modelo;
        public float VelocidadMaxima
        {
            get { return velocidadMaxima; }
            set { velocidadMaxima = value; }
        }
        public float VelocidadMinima
        {
            get { return velocidadMinima; }
            set { velocidadMinima = value; }
        }
        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }
        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }
        Vehiculo()
        {

        }
        public void Encender()
        {

        }
        public void Apagar()
        {

        }
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