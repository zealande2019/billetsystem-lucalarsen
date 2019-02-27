using System;
using System.Collections.Generic;
using System.Text;

namespace BilletLibrary
{
    public class MC : TransportMiddel
    {
        public MC() : 
            base()
        {

        }

        public MC(string Nummerplade, DateTime dato) :
            base(Nummerplade, dato)
        {

        }

        /// <summary>
        /// en override på metoden pris i TransportMiddel
        /// prisen på en MC
        /// </summary>
        /// <returns>decimal 125</returns>
        public override decimal Pris()
        {
            return 125;
        }
        /// <summary>
        /// en override på metoden Køretøj i TransportMiddel
        /// navnet på køretøjet
        /// </summary>
        /// <returns>string MC</returns>
        public override string Køretøj()
        {
            return "MC";
        }


        /// <summary>
        /// en override på metoden til brobizz rabat
        /// </summary>
        /// <returns></returns>
        public override decimal BroBizz()
        {
            decimal brobizz = 125 - (125 * 5 / 100);

            return brobizz;
        }
    }
}
