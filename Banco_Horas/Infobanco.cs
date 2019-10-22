using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco_Horas
{
   public class Infobanco
    {
        public Infobanco()
        {

        }


        public Infobanco(DateTime data)
        {
            Data = data;
        }


        public DateTime Data { get; set; }
        public string Semana { get; set; }
        public string Entrada { get; set; }
        public string Almoco { get; set; }
        public string Saida { get; set; }
        public string Total { get; set; }
        public string Credito { get; set; }
        public string Debito { get; set; }
        //public string Saldo { get; set; }
    }
        
}
