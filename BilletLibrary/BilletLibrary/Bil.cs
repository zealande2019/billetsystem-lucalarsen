using System;

namespace BilletLibrary
{
    public class Bil : TransportMiddel
    {

        /// <summary>
        /// default constructor
        /// </summary>
        public Bil() :
            base()
        {

        }

        /// <summary>
        /// constructor med nummerplade og dato parametre
        /// </summary>
        /// <param name="Nummerplade"></param>
        /// <param name="dato"></param>
        public Bil(string Nummerplade, DateTime dato) : 
            base(Nummerplade, dato)
        {

        }

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

        /// <summary>
        /// en override på metoden til brobizz rabat
        /// </summary>
        /// <returns></returns>
        public override decimal BroBizz()
        {
            decimal rabat = 240 * 5 / 100;

            decimal brobizz = 240 - rabat;

            return brobizz;
        }

    }
}
