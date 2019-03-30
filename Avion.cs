using System.Collections.Generic;
using System;
using JonathanVilleda.Interfaz;
namespace JonathanVilleda.Model
{
    public abstract class Avion : Vehiculo, IBitacora
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
            get { return alturaMinima; }
            set { alturaMinima = value; }
        }
        public void Despegar()
        {

        }
        public void Aterrizar()
        {

        }
        public void DisminuirAltura(float pie)
        {

        }
        public override void Encender()//Viene de la clase Vehiculo
        {

        }
        public override void Apagar()//Viene de la clase Vehiculo
        {

        }
        public Avion()
        {

        }
        public Avion(string modelo, string marca, float alturaMaxima, float alturaminima) =>
           (base.Modelo, base.Marca, base.AlturaMaxima, base.AlturaMinima) =
            (modelo, marca, alturaMaxima, AlturaMinima);

        public override void MostrarDetalle()
        {
              this.ToString();
        }
    }
}