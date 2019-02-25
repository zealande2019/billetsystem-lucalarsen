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
            return 240;
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

        public override decimal BroBizz()
        {
            decimal rabat = 240 / 100 * 5;

            decimal brobizz = 240 - rabat;

            return brobizz;
        }

    }
}
