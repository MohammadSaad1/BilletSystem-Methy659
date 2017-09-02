using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using Xunit.Sdk;

namespace BilletLib.Model
{
    public class Bil: IKøretøj
    {
        
        public string Nummerplade { get; set; }
        public DateTime Dato { get; set; }
        public bool BroBizz { get; set; }
        public int fastRetur = 240;

        public string Restrict()
        {
                if (Nummerplade.Length > 0 && Nummerplade.Length < 7)
                {
                    return Nummerplade;
                }
                throw new ArgumentException("Antal tegn i nummerpladen skal være højere end 0 og mindre end 7");           
        }

        public int PrisRabatWeekend()
        {

            if (Dato.DayOfWeek == DayOfWeek.Saturday || Dato.DayOfWeek == DayOfWeek.Sunday)
            {
                fastRetur = (int) (fastRetur / 1.20);
                return fastRetur;
            }
            else
            {
                return fastRetur;
            }
        }

        public int Pris()
        {


            if (Dato.DayOfWeek == DayOfWeek.Saturday && BroBizz == true)
            {
                return fastRetur = (int)((int)(fastRetur / 1.20) / (1.05));
            }
            else if (Dato.DayOfWeek == DayOfWeek.Sunday && BroBizz == true)
            {
                return fastRetur =(int) ((int)(fastRetur / 1.20) / (1.05));
            }
            else if (Dato.DayOfWeek == DayOfWeek.Saturday)
            {
                return fastRetur = (int) (fastRetur / 1.20);
            }
            else if (Dato.DayOfWeek == DayOfWeek.Sunday)
            {
                return fastRetur = (int)(fastRetur / 1.20);
            }
            else if (BroBizz == true)
            {
                fastRetur = (int)((fastRetur / 1.05));
            }
           
            
            return fastRetur;
        }

        public string Køretøj()
        {
            return "Bil";
        }





    }
}
