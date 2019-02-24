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
        /// abstract metode til pris på et køretøj
        /// </summary>
        /// <returns>retunere pris</returns>
        public abstract decimal Pris();

        /// <summary>
        /// abstract metode til navn på et køretøj
        /// </summary>
        /// <returns></returns>
        public abstract string Køretøj();
    }
}
