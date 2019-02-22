using System;

namespace BilletLibrary
{
    public class Bil
    {
        public string Nummerplade { get; set; }
        public DateTime dato { get; set; }

        /// <summary>
        /// en metode som skal retunere pris på en bil
        /// </summary>
        /// <returns>decimal 240</returns>
        public decimal Pris()
        {
            decimal pris = 240;

            return pris;
        }
        /// <summary>
        /// en metode som skal retunere navnet på køretøjet
        /// </summary>
        /// <returns>string bil</returns>
        public string Køretøj()
        {
            string køretøj = "Bil";

            return køretøj;
        }
    }
}
