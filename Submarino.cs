using System.Collections.Generic;
using System;
using JonathanVilleda.Interfaz;
namespace JonathanVilleda.Model
{
    public abstract class Submarino : Vehiculo, IBitacora
    {
        private float profundidadMaxima;
        public float ProfundidadMaxima
        {
            get { return profundidadMaxima; }
            set { profundidadMaxima = value; }
        }
        public void Sumergir(float metros)
        {

        }
        public Submarino() : base()
        {
            
        }
        public override void Encender()//Viene de la clase Vehiculo
        {

        }
        public override void Apagar()//Viene de la clase Vehiculo
        {

        }
          public Submarino(string modelo, string marca, float profundidadMaxima) =>
           (base.Modelo, base.Marca, base.ProfundidadMaxima) =
            (modelo,marca,profundidadMaxima);
    }
    public override void MostrarDetalle()
        {
              this.ToString();
        }
}