using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Banco_Horas
{//Versão 1.0

    public partial class Form1 : Form
    {

        public TimeSpan totaldebito;
        public TimeSpan totalcredito;
        public TimeSpan totaltrabalho;
        public TimeSpan saldo;
        public DateTime periododata = Convert.ToDateTime(Convert.ToDateTime("15" + "/" + (DateTime.Now.Month).ToString() + "/" + (DateTime.Now.Year).ToString()));
        public List<Infobanco> Lista;
        public string linha;
        public ComparadorData compData = new ComparadorData();
        public Form1()
        {
            InitializeComponent();



            rbMesAtual.Checked = true;
            cbAlmoco.Checked = true;
            cbVerificaDados.Checked = true;
            dtpDataCadastro.Text = DateTime.Now.AddDays(-1).ToString();
            dtpDataPesquisa1.Text = DateTime.Now.AddDays(-1).ToString();
            dtpDataPesquisa2.Text = DateTime.Now.ToString();

            EnviaCartaoPonto(); // Primeiro Carrega os dados da tela do cartão de ponto

            #region CARREGA OS DADOS DO DATAGRIDVIEW
            LeituraArquivo();
            ConfiguraDataGrid();

            #endregion

            #region MOSTRA SALDO ATUAL

            CalculaSaldoAtual();


            #endregion





            CalculaTempo();




            if (rbMesAtual.Checked)
            {
                dtpDataPesquisa1.Enabled = false;
                dtpDataPesquisa2.Enabled = false;
                btCarregarPesquisa.Enabled = false;
                lbSaldoMesAtual.Text = lbSaldoAtual.Text;
                lbSaldoMesAtual.ForeColor = lbSaldoAtual.ForeColor;
            }


        }
        #region MÉTODO CONTROI DADOS - CARREGA OS DADOS DO ARQUIVO TXT NA CLASSE INFOBANCO
        public Infobanco ConstroiDados(string linha)
        {
            Infobanco dados = new Infobanco();

            dados.Data = Convert.ToDateTime(linha.Substring(0, linha.IndexOf('|')));
            linha = linha.Substring(linha.IndexOf('|') + 1);
            dados.Semana = linha.Substring(0, linha.IndexOf('|'));
            linha = linha.Substring(linha.IndexOf('|') + 1);
            dados.Entrada = linha.Substring(0, linha.IndexOf('|'));
            linha = linha.Substring(linha.IndexOf('|') + 1);
            dados.Almoco = linha.Substring(0, linha.IndexOf('|'));
            linha = linha.Substring(linha.IndexOf('|') + 1);
            dados.Saida = linha.Substring(0, linha.IndexOf('|'));
            linha = linha.Substring(linha.IndexOf('|') + 1);
            dados.Total = linha.Substring(0, linha.IndexOf('|'));
            linha = linha.Substring(linha.IndexOf('|') + 1);
            dados.Credito = linha.Substring(0, linha.IndexOf('|'));
            linha = linha.Substring(linha.IndexOf('|') + 1);
            dados.Debito = linha.Substring(0, linha.IndexOf('|'));
            linha = linha.Substring(linha.IndexOf('|') + 1);
            TrocaDeDados.saldoatual = linha.Substring(0, linha.IndexOf('|'));
            linha = linha.Substring(linha.IndexOf('|') + 1);
            TrocaDeDados.saldoanterior = linha.Substring(linha.IndexOf('|') + 1);

            int horadebito = Convert.ToInt16(dados.Debito.Substring(0, dados.Debito.IndexOf(':')));
            int minutodebito = Convert.ToInt16(dados.Debito.Substring(dados.Debito.IndexOf(':') + 1));
            int horacredito = Convert.ToInt16(dados.Credito.Substring(0, dados.Credito.IndexOf(':')));
            int minutocredito = Convert.ToInt16(dados.Credito.Substring(dados.Credito.IndexOf(':') + 1));
            int horatrabalhada = Convert.ToInt16(dados.Total.Substring(0, dados.Total.IndexOf(':')));
            int minutotrabalhado = Convert.ToInt16(dados.Total.Substring(dados.Total.IndexOf(':') + 1));


            saldo = new TimeSpan(horadebito, minutodebito, 0);
            totaldebito = totaldebito.Add(saldo);
            saldo = new TimeSpan(horacredito, minutocredito, 0);
            totalcredito = totalcredito.Add(saldo);
            saldo = new TimeSpan(horatrabalhada, minutotrabalhado, 0);
            totaltrabalho = totaltrabalho.Add(saldo);
            return dados;
        }
        #endregion

        #region MÉTODO PARA LEITURA DO ARQUIVO DE TEXTO
        public void LeituraArquivo()
        {
            Lista = new List<Infobanco>();
            totaldebito = new TimeSpan();
            totalcredito = new TimeSpan();
            totaltrabalho = new TimeSpan();

            if (File.Exists("bancos.txt"))
            {
                StreamReader leitura = new StreamReader("bancos.txt");

                //Se o Mês for o Atual salva os dados do mês (15/MêsAnterior à 15/MêsAtual
                if (rbMesAtual.Checked)
                {
                    while ((linha = leitura.ReadLine()) != null)
                    {

                        if (DateTime.Now.Day <= 15)
                        {
                            if (Convert.ToDateTime(linha.Substring(0, linha.IndexOf('|'))) >= periododata.AddMonths(-1).AddDays(1) &&
                              Convert.ToDateTime(linha.Substring(0, linha.IndexOf('|'))) <= periododata)
                                Lista.Add(ConstroiDados(linha));
                        }
                        else
                        {
                            if (Convert.ToDateTime(linha.Substring(0, linha.IndexOf('|'))) >= periododata.AddDays(1) &&
                                Convert.ToDateTime(linha.Substring(0, linha.IndexOf('|'))) <= periododata.AddMonths(1))
                                Lista.Add(ConstroiDados(linha));
                        }
                    }
                }

                //Se o Mês não for Atual salva os dados do período desejado
                else if (rbEscolherPeriodo.Checked)
                {
                    while ((linha = leitura.ReadLine()) != null)
                    {

                        if (Convert.ToDateTime(linha.Substring(0, linha.IndexOf('|'))) >= Convert.ToDateTime(dtpDataPesquisa1.Text) &&
                            Convert.ToDateTime(linha.Substring(0, linha.IndexOf('|'))) <= Convert.ToDateTime(dtpDataPesquisa2.Text))
                            Lista.Add(ConstroiDados(linha));
                    }
                }

                leitura.Close();

            }

            else //(!File.Exists("bancos.txt"))
            {
                Form3 FrmRegistroBanco = new Form3();
                FrmRegistroBanco.ShowDialog();
            }

            if (TrocaDeDados.saldoatual == "Fechar")
            {

                Environment.Exit(0);

            }



        }
        #endregion

        #region MÉTODO PINTA LABEL
        //public Color PintaLabel(TimeSpan tempo)
        //{
        //    if (24 * tempo.Days + tempo.Hours < 0)
        //        return Color.Red;
        //    else
        //        return Color.Green;
        //}
        #endregion

        #region MÉTODO CONFIGURA DATAGRID
        public void ConfiguraDataGrid()
        {

            dataGridView1.DataSource = null;
            Lista.Sort(compData);
            dataGridView1.DataSource = Lista;


            for (int n = 0; n <= 7; n++)
            {
                dataGridView1.Columns[n].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridView1.Columns[n].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView1.Columns[n].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridView1.Columns[n].SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            dataGridView1.Refresh();
        }
        #endregion

        #region MÉTODO CALCULA TEMPO
        public void CalculaTempo()
        {
            //MOSTRA TOTAL CREDITO            
            lbTotalCredito.Text = (24 * totalcredito.Days + totalcredito.Hours) + ":" + Math.Abs(totalcredito.Minutes).ToString("00");

            //MOSTRA TOTAL DEBITO
            lbTotalDebito.Text = (24 * totaldebito.Days + totaldebito.Hours) + ":" + Math.Abs(totaldebito.Minutes).ToString("00");

            //MOSTRA TOTAL HORAS TRABALHADAS
            lbHorasTrabalhadas.Text = (24 * totaltrabalho.Days + totaltrabalho.Hours) + ":" + Math.Abs(totaltrabalho.Minutes).ToString("00");

        }
        #endregion

        #region MÉTODO ANALISA ENTRADA

        public TimeSpan AnalisaEntrada(TimeSpan entrada)
        {
            TimeSpan tempo1; //Tempo como referencia Entrada
            TimeSpan tempo2; //Tempo como referencia Entrada

            tempo1 = new TimeSpan(7, 55, 0);
            tempo2 = new TimeSpan(8, 5, 0);


            if (entrada >= tempo1 && entrada <= tempo2)
                return entrada = new TimeSpan(8, 0, 0);
            else
                return entrada;
        }

        #endregion

        #region MÉTODO ANALISA SAIDA

        public TimeSpan AnalisaSaida(TimeSpan saida)
        {
            TimeSpan tempo1; //Tempo como referencia Entrada
            TimeSpan tempo2; //Tempo como referencia Entrada

            tempo1 = new TimeSpan(17, 25, 0);
            tempo2 = new TimeSpan(17, 35, 0);


            if (saida >= tempo1 && saida <= tempo2)
                return saida = new TimeSpan(17, 30, 0);
            else
                return saida;
        }

        #endregion

        #region MÉTODO ANALISA TOTAL

        public TimeSpan AnalisaTotal(TimeSpan entrada, TimeSpan saida, TimeSpan almoco)
        {
            TimeSpan comeco = new TimeSpan(8, 0, 0);
            TimeSpan fim = new TimeSpan(17, 30, 0);
            TimeSpan periodo = new TimeSpan(8, 30, 0);

            if (entrada.TotalMinutes == 0 && saida.TotalMinutes == 0)
                return periodo = new TimeSpan(0, 0, 0);

            else if (entrada <= comeco && saida >= fim)
                return periodo;

            else if (entrada > comeco && saida < fim)
                return saida - entrada - almoco;

            else if (entrada > comeco && saida >= fim)
                return periodo - (entrada - comeco);

            else //(entrada <= comeco && saida < fim);
                return periodo - (fim - saida);
        }

        #endregion

        #region MÉTODO DEVOLVE DIA DA SEMANA

        public string ConverteDiaSemana(int numero)
        {
            if (numero == 0)
                return "Domingo";

            else if (numero == 1)
                return "Segunda-Feira";

            else if (numero == 2)
                return "Terca-Feira";


            else if (numero == 3)
                return "Quarta-Feira";

            else if (numero == 4)
                return "Quinta-Feira";


            else if (numero == 5)
                return "Sexta-Feira";

            else if (numero == 6)
                return "Sabado";

            else
                return ("Invalido");
        }

        #endregion

        #region ENVIA DADOS ATÉ DIA 15 PARA TELA CARTÃO DE PONTO
        public void EnviaCartaoPonto()
        {
            Lista = new List<Infobanco>();
            totaldebito = new TimeSpan();
            totalcredito = new TimeSpan();
            totaltrabalho = new TimeSpan();

            if (File.Exists("bancos.txt"))
            {
                StreamReader leitura = new StreamReader("bancos.txt");

                //Se o Mês for o Atual salva os dados do mês (15/MêsAnterior à 15/MêsAtual
                if (rbMesAtual.Checked)
                {
                    while ((linha = leitura.ReadLine()) != null)
                    {

                        if (Convert.ToDateTime(linha.Substring(0, linha.IndexOf('|'))) > periododata.AddMonths(-1) &&
                            Convert.ToDateTime(linha.Substring(0, linha.IndexOf('|'))) <= periododata)
                            Lista.Add(ConstroiDados(linha));
                    }
                }


                TrocaDeDados.totaldebito = (24 * totaldebito.Days + totaldebito.Hours) + ":" + Math.Abs(totaldebito.Minutes).ToString("00");
                TrocaDeDados.totalcredito = (24 * totalcredito.Days + totalcredito.Hours) + ":" + Math.Abs(totalcredito.Minutes).ToString("00");
                TrocaDeDados.horastrabalhadas = (24 * totaltrabalho.Days + totaltrabalho.Hours) + ":" + Math.Abs(totaltrabalho.Minutes).ToString("00");            
                TrocaDeDados.horasbancomes = (24 * (totalcredito - totaldebito).Days + (totalcredito - totaldebito).Hours) + ":" + Math.Abs((totalcredito - totaldebito).Minutes).ToString("00");
                //A Variavél TrocadeDados.saldohoje representa o valor do banco de horas HOJE no CARTÃO DE PONTOS
                TrocaDeDados.saldohoje = TrocaDeDados.saldoanterior;
                leitura.Close();
            }
            
            
        }
        #endregion

        #region MÉTODO CONVERTE TEMPO PARA STRING

        public string TempoParaString(TimeSpan tempo)
        {
            string resposta;

            if(tempo.Minutes < 0 && tempo.Hours >= 0)//Se os minutos forem negativos coloca o sinal negativo "-" na frente do horário
            resposta = "-" + tempo.Hours + ":";

            else//Caso controrário a hora vai ficar positiva
            resposta = tempo.Hours + ":";

            if (tempo.Minutes == 0)
                resposta += "00";
            else if (Math.Abs(tempo.Minutes) > 0 && Math.Abs(tempo.Minutes) < 10)
                resposta += "0" + Math.Abs(tempo.Minutes);
            else if (tempo.Minutes < 0)
                resposta += Math.Abs(tempo.Minutes);

            else
                resposta += tempo.Minutes;
            return resposta;

        }
        #endregion

        #region MÉTODO VERIFICA SE O ARQUIVO ESTÁ TEXTO VAZIO
        public bool ArquivoTextoVazio()
        {
            if (new FileInfo("bancos.txt").Length == 0)
            {
                return true;
            }

            else
                return false;
        }
        #endregion

        #region MÉTODO CALCULA SALDO ATUAL
        public void CalculaSaldoAtual()
        {

            /*Caso o primeiro dia do arquivo texto não estiver dentro do mês atual
            A lista chegará aqui sem conter nenhum elemento, então será necessário
            Pegar uma referencia de saldo atual que será da última linha do arquivo*/
            if (Lista.Count == 0 && TrocaDeDados.saldoatual == null)
            {
                int n = 8;
                string ultimalinha = File.ReadLines("bancos.txt").Last();
                while (n > 0)
                {
                    ultimalinha = ultimalinha.Substring(ultimalinha.IndexOf('|') + 1);
                    n--;
                }

                TrocaDeDados.saldoatual = ultimalinha.Substring(0, ultimalinha.IndexOf('|'));


            }


            int hora = Convert.ToInt16(TrocaDeDados.saldoatual.Substring(0, TrocaDeDados.saldoatual.IndexOf(':')));
            int minuto = Convert.ToInt16(TrocaDeDados.saldoatual.Substring(TrocaDeDados.saldoatual.IndexOf(':') + 1));

            if (hora < 0 || TrocaDeDados.saldoatual.Substring(0, 2) == "-0")//Quando a hora for negativa 0 o "-" aparece automaticamente 1...
                minuto = minuto * -1;
            saldo = new TimeSpan(hora, minuto, 0);

            if(TrocaDeDados.saldoatual.Substring(0, 2) == "-0")
                //Quando a hora for '00:MM' por não enxergar que a hora é < 0
                // É nessário fazer esse if para colocar como negativo
            lbSaldoAtual.Text = "-" + (24 * saldo.Days + saldo.Hours) + ":" + Math.Abs(saldo.Minutes).ToString("00");

            else
                lbSaldoAtual.Text = (24 * saldo.Days + saldo.Hours) + ":" + Math.Abs(saldo.Minutes).ToString("00");

            lbSaldoAtual.ForeColor = (Metodos.PintaLabel(saldo));
        }
        #endregion

        #region MÉTODO CALCULA PRÓXIMO SALDO
        public TimeSpan ProximoSaldo(TimeSpan saldoatual, TimeSpan debito, TimeSpan credito)
        {
            if (saldoatual.Hours < 0 || saldoatual.Minutes < 0)
            {
                saldoatual = new TimeSpan(-1 * saldoatual.Hours, -1 * saldoatual.Minutes, 0);
                saldoatual = saldoatual + debito;
                // if(TrocaDeDados.saldoatual.Substring(0, 2) != "-0")
                saldoatual = new TimeSpan(-1 * saldoatual.Hours, -1 * saldoatual.Minutes, 0);
            }

            else if (TrocaDeDados.saldoatual.Substring(0, 2) == "-0")
            {
                saldoatual = new TimeSpan(-1 * saldoatual.Hours, -1 * saldoatual.Minutes, 0);
                saldoatual = saldoatual + debito;
                
            }

            else
                saldoatual = saldoatual - debito;

            saldoatual = saldoatual.Add(credito);
            return saldoatual;


        }
        #endregion

        #region MÉTODO PARA FAZER A BUSCA DE DATA
        public bool VerificaDia(DateTime data)
        {
            Infobanco b = new Infobanco(data);
            if (Lista.BinarySearch(b, compData) != -1)
            {
                return true;
            }
            else
                return false;
        }
        #endregion

        #region MÉTODO REGISTRA SALDO ANTERIOR DO ÚLTIMO PERÍODO
        public string EscreveSaldo()
        {
            if (TrocaDeDados.saldoanterior == null)
                return TrocaDeDados.saldoatual;
            else
                return TrocaDeDados.saldoanterior;
        }
        #endregion

        private void rbEscolherPeriodo_CheckedChanged(object sender, EventArgs e)
        {
            dtpDataPesquisa1.Enabled = true;
            dtpDataPesquisa2.Enabled = true;
            btCarregarPesquisa.Enabled = true;
            label14.Enabled = false;
            label16.Enabled = false;
            label18.Enabled = false;
            label9.Enabled = false;
            lbHorasTrabalhadas.Enabled = false;
            lbTotalCredito.Enabled = false;
            lbTotalDebito.Enabled = false;
            lbSaldoMesAtual.Enabled = false;

        }

        private void rbMesAtual_CheckedChanged(object sender, EventArgs e)
        {

            dtpDataPesquisa1.Enabled = false;
            dtpDataPesquisa2.Enabled = false;
            btCarregarPesquisa.Enabled = false;


            label14.Enabled = true;
            label16.Enabled = true;
            label18.Enabled = true;
            label9.Enabled = true;
            lbHorasTrabalhadas.Enabled = true;
            lbTotalCredito.Enabled = true;
            lbTotalDebito.Enabled = true;
            lbSaldoMesAtual.Enabled = true;


            dataGridView1.Enabled = false;
            LeituraArquivo();
            dataGridView1.Enabled = true;
            ConfiguraDataGrid();
            CalculaSaldoAtual();
            CalculaTempo();
            lbSaldoMesAtual.Text = lbSaldoAtual.Text;
            lbSaldoMesAtual.ForeColor = (Metodos.PintaLabel(saldo));
        }



        private void btCarregarPesquisa_Click(object sender, EventArgs e)
        {
            label14.Enabled = true;
            label16.Enabled = true;
            label18.Enabled = true;
            label9.Enabled = true;
            lbHorasTrabalhadas.Enabled = true;
            lbTotalCredito.Enabled = true;
            lbTotalDebito.Enabled = true;
            lbSaldoMesAtual.Enabled = true;

            dataGridView1.Enabled = false;
            btCarregarPesquisa.Enabled = false;
            btCarregarPesquisa.Text = "Processando...";

            LeituraArquivo();

            dataGridView1.Enabled = true;
            btCarregarPesquisa.Text = "Carregar Pesquisa";
            btCarregarPesquisa.Enabled = true;
            ConfiguraDataGrid();
            CalculaTempo();


            //Calcula tempo exclusivo do periodo escolhido da pesquisa
            saldo = totalcredito - totaldebito;

            lbSaldoMesAtual.Text = (24 * saldo.Days + saldo.Hours) + ":" + Math.Abs(saldo.Minutes).ToString("00");
            lbSaldoMesAtual.ForeColor = (Metodos.PintaLabel(saldo));

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 FrmCartaoPonto = new Form2();
            FrmCartaoPonto.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            if (!ArquivoTextoVazio())
            {
                int n = 8;
                string ultimalinha = File.ReadLines("bancos.txt").Last();
                while (n > 0)
                {
                    ultimalinha = ultimalinha.Substring(ultimalinha.IndexOf('|') + 1);
                    n--;
                }

                TrocaDeDados.saldoatual = ultimalinha.Substring(0, ultimalinha.IndexOf('|'));
                int hora = Convert.ToInt16(TrocaDeDados.saldoatual.Substring(0, TrocaDeDados.saldoatual.IndexOf(':')));
                int minuto = Convert.ToInt16(TrocaDeDados.saldoatual.Substring(TrocaDeDados.saldoatual.IndexOf(':') + 1));

               // if (hora < 0) 
                if(saldo.Minutes < 0)//----> Alterado em 02/04/2018 para tentar resolver o problema da conta com minutos negativos 
                minuto = minuto * -1;
                saldo = new TimeSpan(hora, minuto, 0);
                lbSaldoMesAtual.Text = (24 * saldo.Days + saldo.Hours) + ":" + Math.Abs(saldo.Minutes).ToString("00");
                lbSaldoMesAtual.ForeColor = (Metodos.PintaLabel(saldo));
            }







            try
            {

                if (Convert.ToDateTime(dtpDataCadastro.Text).Date >= DateTime.Now.Date)
                {
                    MessageBox.Show("Não foi possível cadastrar os dados." + Environment.NewLine + "Escolha uma data finalizada.",
                        "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }



                string diasemana;

                TimeSpan almoco;
                TimeSpan total;
                TimeSpan credito;
                TimeSpan debito;
                //TimeSpan debitonegativo; //transforma o valor do debito para negativo necessário para fazer a conta do saldo
                TimeSpan tempo; //Tempo como referencia Entrada e Saida
                TimeSpan entrada = TimeSpan.Parse(txtEntrada.Text);
                TimeSpan saida = TimeSpan.Parse(txtSaida.Text);





                #region MÉTODO SALVA DADOS NO ARQUIVO TXT

                void SalvaDados()
                {

                    File.AppendAllText("bancos.txt", dtpDataCadastro.Text + "|" + diasemana + "|" + TempoParaString(entrada) + "|" +
                          TempoParaString(almoco) + "|" + TempoParaString(saida) + "|" + TempoParaString(total) + "|"
                          + TempoParaString(credito) + "|" + TempoParaString(debito) + "|" + TempoParaString(ProximoSaldo(saldo, debito, credito)) + "|" + TrocaDeDados.saldoanterior + Environment.NewLine);
                }


                #endregion



                if (cbAlmoco.Checked)
                    almoco = new TimeSpan(1, 0, 0);
                else
                    almoco = new TimeSpan(0, 0, 0);


                total = AnalisaTotal(AnalisaEntrada(entrada), AnalisaSaida(saida), almoco);

                

                tempo = new TimeSpan(8, 0, 0); //Tempo como referencia de entrada
                diasemana = ConverteDiaSemana((int)DateTime.Parse(dtpDataCadastro.Text).DayOfWeek);

                #region AQUI DEFINE OS VALORES DO DEBITO E DO CREDITO

                if (diasemana == "Sabado" || diasemana == "Domingo")
                {
                    debito = new TimeSpan(0, 0, 0);
                    credito = AnalisaSaida(saida) - AnalisaEntrada(entrada);
                    if (cbAlmoco.Checked)
                        credito = credito - almoco;
                }

                else
                {
                    if (entrada.TotalMinutes != 0 && saida.TotalMinutes != 0)
                    {
                        if ((tempo - AnalisaEntrada(entrada)).TotalHours < 0)
                        {
                            credito = new TimeSpan(0, 0, 0);
                            debito = AnalisaEntrada(entrada) - tempo;//inverte valor para ficar negativo
                        }

                        else
                        {
                            credito = tempo - AnalisaEntrada(entrada);
                            debito = new TimeSpan(0, 0, 0);
                        }

                        tempo = new TimeSpan(17, 30, 0);//Tempo como referencia de entrada


                        if ((tempo - AnalisaSaida(saida)).TotalHours < 0)
                            credito = credito + (AnalisaSaida(saida) - tempo);//inverte valor para ficar negativo
                        else
                            debito = debito + (tempo - AnalisaSaida(saida));
                    }

                    else
                    {
                        debito = new TimeSpan(8, 30, 0);
                        credito = new TimeSpan(0, 0, 0);
                    }
                }
                #endregion






                #region AQUI TROCA O SALDO ANTERIOR DO MÊS ANTERIOR PARA O MÊS ATUAL

                int numerolinhas = File.ReadAllLines("bancos.txt").Length;

                //Verifica se o dia é 16
                if (Convert.ToDateTime(dtpDataCadastro.Text).Day == 16 && numerolinhas > 1)
                    TrocaDeDados.saldoanterior = TrocaDeDados.saldoatual;


                else//Se não...
                {
                    if ((Convert.ToDateTime(dtpDataCadastro.Text).Day == 17 && numerolinhas > 1))
                    //Verifica se é dia 17
                    {
                        //Se for dia 17 verifica se o dia 16 já está cadastrado
                        if (!VerificaDia(Convert.ToDateTime(dtpDataCadastro.Text).AddDays(-1)))
                            TrocaDeDados.saldoanterior = TrocaDeDados.saldoatual;
                        /*else//Caso negativo o saldoanterior será o mesmo do saldo anterior do mês atual
                              TrocaDeDados.saldoanterior = TrocaDeDados.horasbancomes;*/
                           
                    }

                    else//Se não for dia 17...
                    {
                        if ((Convert.ToDateTime(dtpDataCadastro.Text).Day == 18 && numerolinhas > 1))
                        {//Verifica se é dia 18
                            if (!VerificaDia(Convert.ToDateTime(dtpDataCadastro.Text).AddDays(-2)))

                            {//Se for dia 18 e dia 16  não tiver cadastrado, verifica se o dia 17 já tinha sido cadastrado;
                                if (!VerificaDia(Convert.ToDateTime(dtpDataCadastro.Text).AddDays(-1)))
                                    //Caso negativo realiza mudança
                                    TrocaDeDados.saldoanterior = TrocaDeDados.saldoatual;
                               /* else// Caso negativo o saldoanterior será o mesmo do saldo anterior do mês atual 
                                    TrocaDeDados.saldoanterior = TrocaDeDados.horasbancomes;*/
                            }
                            /*else// Caso negativo o saldoanterior será o mesmo do saldo anterior do mês atual 
                                TrocaDeDados.saldoanterior = TrocaDeDados.horasbancomes;*/
                        }
                        /*else// Caso negativo o saldoanterior será o mesmo do saldo anterior do mês atual 
                            TrocaDeDados.saldoanterior = TrocaDeDados.horasbancomes;*/
                    }
                }
                #endregion


                if (File.Exists("bancos.txt") && !cbVerificaDados.Checked)
                {
                    SalvaDados();
                }

                else if (File.Exists("bancos.txt") && cbVerificaDados.Checked)
                {
                    string msg = "Confirma os dados: " + Environment.NewLine + dtpDataCadastro.Text +
                        " - Entrada: " + TempoParaString(entrada) + " e Saida: " + TempoParaString(saida) + " ?";
                    if (MessageBox.Show(msg, "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (Lista.Count != 0 && Convert.ToDateTime(dtpDataCadastro.Text) == Lista[Lista.Count - 1].Data)
                        {
                            msg = "O último registro salvo já contém essa data. Deseja salvar mesmo assim?";
                            if (MessageBox.Show(msg, "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                                return;
                        }
                        SalvaDados();
                    }

                    else
                        return;
                }

            }

            catch
            {
                MessageBox.Show("Verifique se o formato da hora está correto.",
                        "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }





        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (ArquivoTextoVazio())
            {
                File.Delete("bancos.txt");
            }


        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (e.KeyChar == Convert.ToChar(Keys.F5))
            //{
            //    LeituraArquivo();
            //    ConfiguraDataGrid();
            //    CalculaSaldoAtual();
            //    CalculaTempo();
            //    lbSaldoMesAtual.Text = lbSaldoAtual.Text;
            //}
        }
    }
}






