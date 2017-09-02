using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletLib.Model
{
    public class ØresundsMC : IKøretøj
    {
        public string Nummerplade { get; set; }
        public DateTime Dato { get; set; }
        public bool BroBizz { get; set; }
        public int FastPris = 210;
        public int Pris()
        {
            if (BroBizz == true)
            {
                FastPris = 73;
            }
            return FastPris;
        }

        public string Køretøj()
        {
            return "Øresund MC";
        }
    }
}
