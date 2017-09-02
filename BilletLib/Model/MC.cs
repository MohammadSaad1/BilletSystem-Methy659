using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletLib.Model
{
    public class MC: IKøretøj
    {
        public string Nummerplade { get; set; }
        public DateTime Dato { get; set; }
        public bool BroBizz { get; set; }
        public int Pris()
        {
            int fastRetur = 125;
            if (BroBizz == true)
            {
                fastRetur = (int)((fastRetur / 1.05));
            }
            return fastRetur;
        }

        public string Køretøj()
        {
            return "Motercykel";
        }
    }
}
