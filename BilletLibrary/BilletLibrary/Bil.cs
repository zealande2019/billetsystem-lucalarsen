using System;

namespace BilletLibrary
{
    public class Bil : TransportMiddel
    {


        /// <summary>
        /// en override på metoden pris i TransportMiddel
        /// prisen på en Bil
        /// </summary>
        /// <returns>decimal 240</returns>
        public override decimal Pris()
        {
            decimal prismedrabat = 240 - Rabat;

            return prismedrabat;
        }
        /// <summary>
        /// en override på metoden Køretøj i TransportMiddel
        /// navnet på køretøjet
        /// </summary>
        /// <returns>string bil</returns>
        public override string Køretøj()
        {
            return "Bil";
        }

        /// <summary>
        /// 
        /// </summary>
        public Bil()
            : base()
        {

        }

        public Bil(decimal rabat)
            : base()
        {

        }
    }
}
