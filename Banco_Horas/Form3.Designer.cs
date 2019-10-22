namespace Banco_Horas
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btSalvaNovoRegistro = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txthora = new System.Windows.Forms.NumericUpDown();
            this.txtminuto = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.txthora)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtminuto)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(95, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "O arquivo de registro não existe.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(360, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Para criar digite o saldo do banco de horas que deseja iniciar:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btSalvaNovoRegistro
            // 
            this.btSalvaNovoRegistro.Location = new System.Drawing.Point(104, 136);
            this.btSalvaNovoRegistro.Name = "btSalvaNovoRegistro";
            this.btSalvaNovoRegistro.Size = new System.Drawing.Size(101, 23);
            this.btSalvaNovoRegistro.TabIndex = 8;
            this.btSalvaNovoRegistro.Text = "Salvar Dados";
            this.btSalvaNovoRegistro.UseVisualStyleBackColor = true;
            this.btSalvaNovoRegistro.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(148, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = ":";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(104, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 24);
            this.label4.TabIndex = 12;
            this.label4.Text = "HH   :   mm";
            // 
            // txthora
            // 
            this.txthora.Location = new System.Drawing.Point(104, 95);
            this.txthora.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.txthora.Minimum = new decimal(new int[] {
            60,
            0,
            0,
            -2147483648});
            this.txthora.Name = "txthora";
            this.txthora.Size = new System.Drawing.Size(43, 20);
            this.txthora.TabIndex = 13;
            // 
            // txtminuto
            // 
            this.txtminuto.Location = new System.Drawing.Point(166, 95);
            this.txtminuto.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.txtminuto.Name = "txtminuto";
            this.txtminuto.Size = new System.Drawing.Size(43, 20);
            this.txtminuto.TabIndex = 14;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 198);
            this.Controls.Add(this.txtminuto);
            this.Controls.Add(this.txthora);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btSalvaNovoRegistro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.Text = "Iniciar Registro";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form3_FormClosed);
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txthora)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtminuto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btSalvaNovoRegistro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown txthora;
        private System.Windows.Forms.NumericUpDown txtminuto;
    }
}