using System.Collections.Generic;
using System;
using static System.Console;
namespace JonathanVilleda.Model
{
    public abstract class Vehiculo
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
        public abstract void Encender();//Se hace referencia en la clase Avión y Submarino       
        public abstract void Apagar();//Se hace referencia en la clase Avión y Submarino     
    }
}