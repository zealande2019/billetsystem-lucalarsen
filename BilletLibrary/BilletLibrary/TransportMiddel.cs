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
        public string Nummerplade { get; set; }
        public DateTime dato { get; set; }

        public abstract decimal Pris();

        public abstract string Køretøj();
    }
}
