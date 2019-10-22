using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco_Horas
{
    public class ComparadorData : IComparer <Infobanco>
    {
        public int Compare(Infobanco x, Infobanco y)
        {
            return x.Data.CompareTo(y.Data);
        }
    }
}
