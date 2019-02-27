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
        /// nummerpladen på et køretøj, nummerpladen må ikke være mere end 7 tegn
        /// </summary>
        public string Nummerplade
        {
            get { return Nummerplade; }
            set
            {

                if (Nummerplade.Length > 7)
                {
                    throw new Exception();
                }
            }
        }

        /// <summary>
        /// datoen på billet køb
        /// </summary>
        public DateTime dato { get; set; }

        /// <summary>
        /// default constructor
        /// </summary>
        public TransportMiddel()
        {

        }

        /// <summary>
        /// constructor med nummerplade og dato parametre
        /// </summary>
        /// <param name="Nummerplade"></param>
        /// <param name="dato"></param>
        public TransportMiddel(string Nummerplade, DateTime dato)
        {

        }

        /// <summary>
        /// abstract metode til pris på et køretøj
        /// </summary>
        /// <returns></returns>
        public abstract decimal Pris();

        /// <summary>
        /// abstract metode til brobizz rabat
        /// </summary>
        /// <returns></returns>
        public abstract decimal BroBizz();

        /// <summary>
        /// abstract metode til navn på et køretøj
        /// </summary>
        /// <returns></returns>
        public abstract string Køretøj();
    }
}
