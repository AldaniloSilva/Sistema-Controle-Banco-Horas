using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco_Horas
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string hora = txthora.Text + ":" + txtminuto.Text;
            if (Convert.ToInt32(txtminuto.Text) <= 9 && Convert.ToInt32(txtminuto.Text) >= 0)
                hora += "0";

            TrocaDeDados.saldoatual = hora;
            TrocaDeDados.saldoanterior = hora;
            StreamWriter escrita;
            escrita = File.CreateText("bancos.txt");
            escrita.Close();
            Close();
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (TrocaDeDados.saldoatual == null && !File.Exists("bancos.txt"))
                TrocaDeDados.saldoatual = "Fechar";
        }
    }
}
