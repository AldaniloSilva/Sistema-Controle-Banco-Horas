using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace Banco_Horas
{
   abstract public class Metodos
    {
        public static Color PintaLabel(TimeSpan tempo)
        {
            //Quando a hora for '00:MM' por não enxergar que a hora é < 0
            // É nessário fazer esse OU para colocar como negativo
            if (24 * tempo.Days + tempo.Hours < 0 || TrocaDeDados.saldoatual.Substring(0, 1) == "-")
                return Color.Red;
            else
                return Color.Green;
        }
    }
}
