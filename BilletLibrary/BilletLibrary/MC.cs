using System;
using System.Collections.Generic;
using System.Text;

namespace BilletLibrary
{
    public class MC : TransportMiddel
    {
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

        public override decimal BroBizz()
        {
            decimal brobizz = 125 - (125 / 100 * 5);

            return brobizz;
        }
    }
}
