using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco_Horas
{
    public partial class Form2 : Form
    {
        public Form2()
        {           
            InitializeComponent();
            lbHorasTrabalhadas.Text = TrocaDeDados.horastrabalhadas;
            lbTotalCredito.Text = TrocaDeDados.totalcredito;
            lbTotalDebito.Text = TrocaDeDados.totaldebito;
            //lbSaldoAtual.Text = TrocaDeDados.saldohoje;//
            lbSaldoAtual.Text = TrocaDeDados.saldohoje;
            lbSaldoAnterior.Text = TrocaDeDados.saldoanterior;
            lbHorasBancoMes.Text = TrocaDeDados.horasbancomes;

        }
    }
}
