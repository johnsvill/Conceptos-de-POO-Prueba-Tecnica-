using System.Collections.Generic;
using System;
namespace PrimerJonathanPrimerVilleda.Model
{
    public class IBitacora 
    {
        public interface IBitacora
        {
            string StarToSee(string alturaMaximaI);
            string StarToSee(string profundidadMaximaI);
            void StopToSee(string alturaMaximaI, string profundidadMaximaF); 
            public float MostrarDetalle(float alturaMaximaI, float profundidadMaximaF)
            {
                return alturaMaximaI || profundidadMaximaF;
            }
        }

    }
}