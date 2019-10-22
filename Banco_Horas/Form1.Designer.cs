namespace Banco_Horas
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbVerificaDados = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtSaida = new System.Windows.Forms.MaskedTextBox();
            this.txtEntrada = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbAlmoco = new System.Windows.Forms.CheckBox();
            this.dtpDataCadastro = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbTotalDebito = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lbSaldoMesAtual = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbTotalCredito = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lbHorasTrabalhadas = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btCarregarPesquisa = new System.Windows.Forms.Button();
            this.dtpDataPesquisa2 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpDataPesquisa1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.rbEscolherPeriodo = new System.Windows.Forms.RadioButton();
            this.rbMesAtual = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.lbSaldoAtual = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(376, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(456, 505);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbVerificaDados);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtSaida);
            this.groupBox1.Controls.Add(this.txtEntrada);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbAlmoco);
            this.groupBox1.Controls.Add(this.dtpDataCadastro);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(25, 108);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(335, 137);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastrar Ponto";
            // 
            // cbVerificaDados
            // 
            this.cbVerificaDados.AutoSize = true;
            this.cbVerificaDados.Location = new System.Drawing.Point(37, 73);
            this.cbVerificaDados.Name = "cbVerificaDados";
            this.cbVerificaDados.Size = new System.Drawing.Size(96, 17);
            this.cbVerificaDados.TabIndex = 9;
            this.cbVerificaDados.Text = "Verificar dados";
            this.cbVerificaDados.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(118, 107);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 24);
            this.button1.TabIndex = 8;
            this.button1.Text = "Cadastrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtSaida
            // 
            this.txtSaida.Location = new System.Drawing.Point(253, 51);
            this.txtSaida.Mask = "00:00";
            this.txtSaida.Name = "txtSaida";
            this.txtSaida.Size = new System.Drawing.Size(54, 20);
            this.txtSaida.TabIndex = 7;
            this.txtSaida.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtSaida.ValidatingType = typeof(System.DateTime);
            // 
            // txtEntrada
            // 
            this.txtEntrada.Location = new System.Drawing.Point(253, 19);
            this.txtEntrada.Mask = "00:00";
            this.txtEntrada.Name = "txtEntrada";
            this.txtEntrada.Size = new System.Drawing.Size(54, 20);
            this.txtEntrada.TabIndex = 6;
            this.txtEntrada.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtEntrada.ValidatingType = typeof(System.DateTime);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(211, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Saída";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(203, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Entrada";
            // 
            // cbAlmoco
            // 
            this.cbAlmoco.AutoSize = true;
            this.cbAlmoco.Location = new System.Drawing.Point(37, 50);
            this.cbAlmoco.Name = "cbAlmoco";
            this.cbAlmoco.Size = new System.Drawing.Size(113, 17);
            this.cbAlmoco.TabIndex = 3;
            this.cbAlmoco.Text = "Horário de Almoço";
            this.cbAlmoco.UseVisualStyleBackColor = true;
            // 
            // dtpDataCadastro
            // 
            this.dtpDataCadastro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataCadastro.Location = new System.Drawing.Point(48, 19);
            this.dtpDataCadastro.Name = "dtpDataCadastro";
            this.dtpDataCadastro.Size = new System.Drawing.Size(102, 20);
            this.dtpDataCadastro.TabIndex = 2;
            this.dtpDataCadastro.Value = new System.DateTime(2018, 12, 20, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Data";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbTotalDebito);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.lbSaldoMesAtual);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.lbTotalCredito);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.lbHorasTrabalhadas);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.btCarregarPesquisa);
            this.groupBox2.Controls.Add(this.dtpDataPesquisa2);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.dtpDataPesquisa1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.rbEscolherPeriodo);
            this.groupBox2.Controls.Add(this.rbMesAtual);
            this.groupBox2.Location = new System.Drawing.Point(25, 252);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(328, 265);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pesquisar";
            // 
            // lbTotalDebito
            // 
            this.lbTotalDebito.AutoSize = true;
            this.lbTotalDebito.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalDebito.Location = new System.Drawing.Point(203, 205);
            this.lbTotalDebito.Name = "lbTotalDebito";
            this.lbTotalDebito.Size = new System.Drawing.Size(48, 18);
            this.lbTotalDebito.TabIndex = 17;
            this.lbTotalDebito.Text = "00:00";
            this.lbTotalDebito.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(95, 205);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(91, 18);
            this.label18.TabIndex = 16;
            this.label18.Text = "Total Débito";
            this.label18.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbSaldoMesAtual
            // 
            this.lbSaldoMesAtual.AutoSize = true;
            this.lbSaldoMesAtual.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSaldoMesAtual.Location = new System.Drawing.Point(203, 239);
            this.lbSaldoMesAtual.Name = "lbSaldoMesAtual";
            this.lbSaldoMesAtual.Size = new System.Drawing.Size(48, 18);
            this.lbSaldoMesAtual.TabIndex = 11;
            this.lbSaldoMesAtual.Text = "00:00";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(95, 239);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 18);
            this.label9.TabIndex = 10;
            this.label9.Text = "Saldo ";
            // 
            // lbTotalCredito
            // 
            this.lbTotalCredito.AutoSize = true;
            this.lbTotalCredito.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalCredito.Location = new System.Drawing.Point(211, 169);
            this.lbTotalCredito.Name = "lbTotalCredito";
            this.lbTotalCredito.Size = new System.Drawing.Size(48, 18);
            this.lbTotalCredito.TabIndex = 15;
            this.lbTotalCredito.Text = "00:00";
            this.lbTotalCredito.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(98, 169);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(96, 18);
            this.label16.TabIndex = 14;
            this.label16.Text = "Total Crédito";
            this.label16.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbHorasTrabalhadas
            // 
            this.lbHorasTrabalhadas.AutoSize = true;
            this.lbHorasTrabalhadas.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHorasTrabalhadas.Location = new System.Drawing.Point(203, 134);
            this.lbHorasTrabalhadas.Name = "lbHorasTrabalhadas";
            this.lbHorasTrabalhadas.Size = new System.Drawing.Size(48, 18);
            this.lbHorasTrabalhadas.TabIndex = 13;
            this.lbHorasTrabalhadas.Text = "00:00";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(52, 131);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(140, 18);
            this.label14.TabIndex = 12;
            this.label14.Text = "Horas Trabalhadas";
            // 
            // btCarregarPesquisa
            // 
            this.btCarregarPesquisa.Location = new System.Drawing.Point(98, 87);
            this.btCarregarPesquisa.Name = "btCarregarPesquisa";
            this.btCarregarPesquisa.Size = new System.Drawing.Size(118, 24);
            this.btCarregarPesquisa.TabIndex = 9;
            this.btCarregarPesquisa.Text = "Carregar Pesquisa";
            this.btCarregarPesquisa.UseVisualStyleBackColor = true;
            this.btCarregarPesquisa.Click += new System.EventHandler(this.btCarregarPesquisa_Click);
            // 
            // dtpDataPesquisa2
            // 
            this.dtpDataPesquisa2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataPesquisa2.Location = new System.Drawing.Point(199, 60);
            this.dtpDataPesquisa2.Name = "dtpDataPesquisa2";
            this.dtpDataPesquisa2.Size = new System.Drawing.Size(102, 20);
            this.dtpDataPesquisa2.TabIndex = 6;
            this.dtpDataPesquisa2.Value = new System.DateTime(2018, 12, 20, 0, 0, 0, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(163, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Data";
            // 
            // dtpDataPesquisa1
            // 
            this.dtpDataPesquisa1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataPesquisa1.Location = new System.Drawing.Point(199, 28);
            this.dtpDataPesquisa1.Name = "dtpDataPesquisa1";
            this.dtpDataPesquisa1.Size = new System.Drawing.Size(102, 20);
            this.dtpDataPesquisa1.TabIndex = 4;
            this.dtpDataPesquisa1.Value = new System.DateTime(2018, 12, 20, 0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(163, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Data";
            // 
            // rbEscolherPeriodo
            // 
            this.rbEscolherPeriodo.AutoSize = true;
            this.rbEscolherPeriodo.Location = new System.Drawing.Point(31, 64);
            this.rbEscolherPeriodo.Name = "rbEscolherPeriodo";
            this.rbEscolherPeriodo.Size = new System.Drawing.Size(107, 17);
            this.rbEscolherPeriodo.TabIndex = 1;
            this.rbEscolherPeriodo.TabStop = true;
            this.rbEscolherPeriodo.Text = "Escolher Período";
            this.rbEscolherPeriodo.UseVisualStyleBackColor = true;
            this.rbEscolherPeriodo.CheckedChanged += new System.EventHandler(this.rbEscolherPeriodo_CheckedChanged);
            // 
            // rbMesAtual
            // 
            this.rbMesAtual.AutoSize = true;
            this.rbMesAtual.Location = new System.Drawing.Point(31, 28);
            this.rbMesAtual.Name = "rbMesAtual";
            this.rbMesAtual.Size = new System.Drawing.Size(119, 17);
            this.rbMesAtual.TabIndex = 0;
            this.rbMesAtual.TabStop = true;
            this.rbMesAtual.Text = "Mês em Andamento";
            this.rbMesAtual.UseVisualStyleBackColor = true;
            this.rbMesAtual.CheckedChanged += new System.EventHandler(this.rbMesAtual_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(152, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 24);
            this.label6.TabIndex = 3;
            this.label6.Text = "Saldo Atual";
            // 
            // lbSaldoAtual
            // 
            this.lbSaldoAtual.AutoSize = true;
            this.lbSaldoAtual.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSaldoAtual.Location = new System.Drawing.Point(295, 42);
            this.lbSaldoAtual.Name = "lbSaldoAtual";
            this.lbSaldoAtual.Size = new System.Drawing.Size(65, 24);
            this.lbSaldoAtual.TabIndex = 4;
            this.lbSaldoAtual.Text = "00:00";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(25, 32);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 49);
            this.button2.TabIndex = 9;
            this.button2.Text = "Dados Cartão de Ponto";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 523);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lbSaldoAtual);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Registro Banco de Horas";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDataCadastro;
        private System.Windows.Forms.MaskedTextBox txtSaida;
        private System.Windows.Forms.MaskedTextBox txtEntrada;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbAlmoco;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btCarregarPesquisa;
        private System.Windows.Forms.DateTimePicker dtpDataPesquisa2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpDataPesquisa1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbEscolherPeriodo;
        private System.Windows.Forms.RadioButton rbMesAtual;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbSaldoAtual;
        private System.Windows.Forms.Label lbSaldoMesAtual;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbTotalDebito;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lbTotalCredito;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lbHorasTrabalhadas;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox cbVerificaDados;
    }
}

