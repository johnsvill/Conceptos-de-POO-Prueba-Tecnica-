using System.Collections.Generic;
using System;
namespace PrimerJonathanPrimerVilleda.Model
{
    public class Avion : Vehiculo
    {
        private float alturaMaxima;
        private float alturaMinima;
        public float AlturaMaxima
        {
            get { return alturaMaxima; }
            set { alturaMaxima = value; }
        }
        public float AlturaMinima
        {
            get{ return alturaMinima;}
            set{ alturaMinima = value;}
        }
        public void DisminuirAltura(float pie)
        {

        }
        public Avion() : base()
        {
            
        }
        public Avion(string modelo, string marca, float alturaMaxima, float alturaminima ) =>
           (base.Modelo, base.Marca, base.AlturaMaxima, base.AlturaMinima) =
            (modelo,marca,alturaMaxima,AlturaMinima);
    }
}