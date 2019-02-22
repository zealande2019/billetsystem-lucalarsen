using System;
using System.Collections.Generic;
using System.Text;

namespace BilletLibrary
{
    public class MC
    {
        public string Nummerplade { get; set; }
        public DateTime dato { get; set; }

        /// <summary>
        /// en metode som skal retunere pris på en MC
        /// </summary>
        /// <returns>decimal 240</returns>
        public decimal Pris()
        {
            decimal pris = 125;

            return pris;
        }
        /// <summary>
        /// en metode som skal retunere navnet på køretøjet
        /// </summary>
        /// <returns>string MC</returns>
        public string Køretøj()
        {
            string køretøj = "MC";

            return køretøj;
        }
    }
}
