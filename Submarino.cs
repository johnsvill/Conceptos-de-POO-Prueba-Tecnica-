using System.Collections.Generic;
using System;
namespace PrimerJonathanPrimerVilleda.Model
{
    public class Submarino : Vehiculo
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
          public Submarino(string modelo, string marca, float profundidadMaxima) =>
           (base.Modelo, base.Marca, base.ProfundidadMaxima) =
            (modelo,marca,profundidadMaxima);
    }
}