using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace BilletLib.Model
{
    public class Bil: IKøretøj
    {
        public string Nummerplade { get; set; }
        public DateTime Dato { get; set; }
        public int Pris()
        {
            int fastRetur = 240;
            return fastRetur;
        }

        public string Køretøj()
        {
            return "Bil";
        }





    }
}
