using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

        public string Restrict()
        {
                if (Nummerplade.Length > 0 && Nummerplade.Length < 7)
                {
                    return Nummerplade;
                }
                throw new ArgumentException("Antal tegn i nummerpladen skal være højere end 0 og mindre end 7");           
        }
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
