using System;
using System.Collections.Generic;
using System.Text;

namespace BilletLibrary
{
    /// <summary>
    /// en abstract klasse som alle køretøjer skal arve fra
    /// </summary>
    public abstract class TransportMiddel
    {
        /// <summary>
        /// nummerpladen på et køretøj
        /// </summary>
        public string Nummerplade { get; set; }

        /// <summary>
        /// datoen på billet køb
        /// </summary>
        public DateTime dato { get; set; }

        /// <summary>
        /// rabat til brobizz
        /// </summary>
        public decimal Rabat { get; set; }



        /// <summary>
        /// abstract metode til pris på et køretøj
        /// </summary>
        /// <returns></returns>
        public abstract decimal Pris();

        public abstract decimal BroBizz();

        /// <summary>
        /// abstract metode til navn på et køretøj
        /// </summary>
        /// <returns></returns>
        public abstract string Køretøj();
    }
}
