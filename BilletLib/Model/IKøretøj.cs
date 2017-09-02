using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletLib.Model
{
    public interface IKøretøj
    {
        string Nummerplade { get; set; }
        DateTime Dato { get; set; }
        
        int Pris();
        string Køretøj();
    }
}
