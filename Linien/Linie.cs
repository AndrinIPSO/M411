using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linien
{
    public class Linie
    {
        public double lenght { get; set; }
        private Linientyp typ;

        public enum Linientyp
        {
            durchgezogen,
            gestrichelt,
            gepunktet,
            strichpunkt
        }
    }
}
