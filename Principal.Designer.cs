
namespace ControleDeGastos
{
    partial class Principal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCadastroAno = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCadastroLancamento = new System.Windows.Forms.ToolStripMenuItem();
            this.lançamentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRelMensal = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRelAnual = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSair = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.dtPrincipal = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgEntradas = new System.Windows.Forms.DataGridView();
            this.dgSaidas = new System.Windows.Forms.DataGridView();
            this.lblSaldoTotal = new System.Windows.Forms.Label();
            this.lblTotalGeral = new System.Windows.Forms.Label();
            this.lblTotalEntrada = new System.Windows.Forms.Label();
            this.lblTotalEntradas = new System.Windows.Forms.Label();
            this.lblTotalSaida = new System.Windows.Forms.Label();
            this.lblTotalSaidas = new System.Windows.Forms.Label();
            this.refreshEntradas = new System.Windows.Forms.Button();
            this.refreshSaidas = new System.Windows.Forms.Button();
            this.cbBuscarMes = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgEntradas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgSaidas)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrosToolStripMenuItem,
            this.lançamentosToolStripMenuItem,
            this.btnSair});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(849, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            this.cadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCadastroAno,
            this.btnCadastroLancamento});
            this.cadastrosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cadastrosToolStripMenuItem.Image")));
            this.cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            this.cadastrosToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // btnCadastroAno
            // 
            this.btnCadastroAno.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastroAno.Image")));
            this.btnCadastroAno.Name = "btnCadastroAno";
            this.btnCadastroAno.Size = new System.Drawing.Size(145, 22);
            this.btnCadastroAno.Text = "Ano";
            this.btnCadastroAno.Click += new System.EventHandler(this.btnCadastroAno_Click);
            // 
            // btnCadastroLancamento
            // 
            this.btnCadastroLancamento.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastroLancamento.Image")));
            this.btnCadastroLancamento.Name = "btnCadastroLancamento";
            this.btnCadastroLancamento.Size = new System.Drawing.Size(145, 22);
            this.btnCadastroLancamento.Text = "Lançamentos";
            this.btnCadastroLancamento.Click += new System.EventHandler(this.btnCadastroLancamento_Click);
            // 
            // lançamentosToolStripMenuItem
            // 
            this.lançamentosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnRelMensal,
            this.btnRelAnual});
            this.lançamentosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("lançamentosToolStripMenuItem.Image")));
            this.lançamentosToolStripMenuItem.Name = "lançamentosToolStripMenuItem";
            this.lançamentosToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.lançamentosToolStripMenuItem.Text = "Relatórios";
            this.lançamentosToolStripMenuItem.Click += new System.EventHandler(this.lançamentosToolStripMenuItem_Click);
            // 
            // btnRelMensal
            // 
            this.btnRelMensal.Image = ((System.Drawing.Image)(resources.GetObject("btnRelMensal.Image")));
            this.btnRelMensal.Name = "btnRelMensal";
            this.btnRelMensal.Size = new System.Drawing.Size(180, 22);
            this.btnRelMensal.Text = "Mensal ";
            this.btnRelMensal.Click += new System.EventHandler(this.btnRelMensal_Click);
            // 
            // btnRelAnual
            // 
            this.btnRelAnual.Image = ((System.Drawing.Image)(resources.GetObject("btnRelAnual.Image")));
            this.btnRelAnual.Name = "btnRelAnual";
            this.btnRelAnual.Size = new System.Drawing.Size(180, 22);
            this.btnRelAnual.Text = "Anual";
            this.btnRelAnual.Click += new System.EventHandler(this.btnRelAnual_Click);
            // 
            // btnSair
            // 
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(54, 20);
            this.btnSair.Text = "Sair";
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lançamentos do Dia:";
            // 
            // dtPrincipal
            // 
            this.dtPrincipal.CalendarForeColor = System.Drawing.SystemColors.Info;
            this.dtPrincipal.CalendarTitleBackColor = System.Drawing.SystemColors.HotTrack;
            this.dtPrincipal.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtPrincipal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPrincipal.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtPrincipal.Location = new System.Drawing.Point(15, 61);
            this.dtPrincipal.Name = "dtPrincipal";
            this.dtPrincipal.Size = new System.Drawing.Size(139, 20);
            this.dtPrincipal.TabIndex = 2;
            this.dtPrincipal.Tag = "";
            this.dtPrincipal.Value = new System.DateTime(2022, 2, 20, 0, 0, 0, 0);
            this.dtPrincipal.ValueChanged += new System.EventHandler(this.dtPrincipal_ValueChanged);
            this.dtPrincipal.Enter += new System.EventHandler(this.dtPrincipal_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Entradas:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(434, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Saidas:";
            // 
            // dgEntradas
            // 
            this.dgEntradas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgEntradas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEntradas.Location = new System.Drawing.Point(12, 133);
            this.dgEntradas.Name = "dgEntradas";
            this.dgEntradas.Size = new System.Drawing.Size(400, 305);
            this.dgEntradas.TabIndex = 5;
            // 
            // dgSaidas
            // 
            this.dgSaidas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgSaidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSaidas.Location = new System.Drawing.Point(437, 133);
            this.dgSaidas.Name = "dgSaidas";
            this.dgSaidas.Size = new System.Drawing.Size(400, 305);
            this.dgSaidas.TabIndex = 6;
            // 
            // lblSaldoTotal
            // 
            this.lblSaldoTotal.AutoSize = true;
            this.lblSaldoTotal.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSaldoTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldoTotal.Location = new System.Drawing.Point(418, 490);
            this.lblSaldoTotal.Name = "lblSaldoTotal";
            this.lblSaldoTotal.Size = new System.Drawing.Size(105, 20);
            this.lblSaldoTotal.TabIndex = 7;
            this.lblSaldoTotal.Text = "Saldo Total:";
            // 
            // lblTotalGeral
            // 
            this.lblTotalGeral.AutoSize = true;
            this.lblTotalGeral.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTotalGeral.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalGeral.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalGeral.ForeColor = System.Drawing.Color.Blue;
            this.lblTotalGeral.Location = new System.Drawing.Point(529, 488);
            this.lblTotalGeral.Name = "lblTotalGeral";
            this.lblTotalGeral.Size = new System.Drawing.Size(31, 22);
            this.lblTotalGeral.TabIndex = 8;
            this.lblTotalGeral.Text = "00";
            // 
            // lblTotalEntrada
            // 
            this.lblTotalEntrada.AutoSize = true;
            this.lblTotalEntrada.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTotalEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalEntrada.Location = new System.Drawing.Point(41, 461);
            this.lblTotalEntrada.Name = "lblTotalEntrada";
            this.lblTotalEntrada.Size = new System.Drawing.Size(132, 20);
            this.lblTotalEntrada.TabIndex = 9;
            this.lblTotalEntrada.Text = "Total Entradas:";
            // 
            // lblTotalEntradas
            // 
            this.lblTotalEntradas.AutoSize = true;
            this.lblTotalEntradas.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTotalEntradas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalEntradas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalEntradas.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblTotalEntradas.Location = new System.Drawing.Point(179, 459);
            this.lblTotalEntradas.Name = "lblTotalEntradas";
            this.lblTotalEntradas.Size = new System.Drawing.Size(31, 22);
            this.lblTotalEntradas.TabIndex = 10;
            this.lblTotalEntradas.Text = "00";
            // 
            // lblTotalSaida
            // 
            this.lblTotalSaida.AutoSize = true;
            this.lblTotalSaida.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTotalSaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSaida.Location = new System.Drawing.Point(409, 461);
            this.lblTotalSaida.Name = "lblTotalSaida";
            this.lblTotalSaida.Size = new System.Drawing.Size(114, 20);
            this.lblTotalSaida.TabIndex = 11;
            this.lblTotalSaida.Text = "Total Saidas:";
            // 
            // lblTotalSaidas
            // 
            this.lblTotalSaidas.AutoSize = true;
            this.lblTotalSaidas.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTotalSaidas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalSaidas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSaidas.ForeColor = System.Drawing.Color.Red;
            this.lblTotalSaidas.Location = new System.Drawing.Point(529, 459);
            this.lblTotalSaidas.Name = "lblTotalSaidas";
            this.lblTotalSaidas.Size = new System.Drawing.Size(31, 22);
            this.lblTotalSaidas.TabIndex = 12;
            this.lblTotalSaidas.Text = "00";
            // 
            // refreshEntradas
            // 
            this.refreshEntradas.Location = new System.Drawing.Point(96, 97);
            this.refreshEntradas.Name = "refreshEntradas";
            this.refreshEntradas.Size = new System.Drawing.Size(221, 20);
            this.refreshEntradas.TabIndex = 33;
            this.refreshEntradas.Text = "Listar Todos os Registros de Entrada";
            this.refreshEntradas.UseVisualStyleBackColor = true;
            this.refreshEntradas.Click += new System.EventHandler(this.refresh_Click);
            // 
            // refreshSaidas
            // 
            this.refreshSaidas.Location = new System.Drawing.Point(502, 97);
            this.refreshSaidas.Name = "refreshSaidas";
            this.refreshSaidas.Size = new System.Drawing.Size(221, 20);
            this.refreshSaidas.TabIndex = 34;
            this.refreshSaidas.Text = "Listar Todos os Registros de Saida";
            this.refreshSaidas.UseVisualStyleBackColor = true;
            this.refreshSaidas.Click += new System.EventHandler(this.refreshSaidas_Click);
            // 
            // cbBuscarMes
            // 
            this.cbBuscarMes.FormattingEnabled = true;
            this.cbBuscarMes.Items.AddRange(new object[] {
            "Janeiro",
            "Fevereiro",
            "Março",
            "Abril ",
            "Maio",
            "Junho",
            "Julho",
            "Agosto",
            "Setembro",
            "Outubro",
            "Novembro",
            "Dezembro"});
            this.cbBuscarMes.Location = new System.Drawing.Point(263, 60);
            this.cbBuscarMes.Name = "cbBuscarMes";
            this.cbBuscarMes.Size = new System.Drawing.Size(149, 21);
            this.cbBuscarMes.TabIndex = 35;
            this.cbBuscarMes.SelectedIndexChanged += new System.EventHandler(this.cbBuscarMes_SelectedIndexChanged);
            this.cbBuscarMes.SelectedValueChanged += new System.EventHandler(this.cbBuscarMes_SelectedValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(260, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 17);
            this.label4.TabIndex = 36;
            this.label4.Text = "Lançamentos por Mês:";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(849, 536);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbBuscarMes);
            this.Controls.Add(this.refreshSaidas);
            this.Controls.Add(this.refreshEntradas);
            this.Controls.Add(this.lblTotalSaidas);
            this.Controls.Add(this.lblTotalSaida);
            this.Controls.Add(this.lblTotalEntradas);
            this.Controls.Add(this.lblTotalEntrada);
            this.Controls.Add(this.lblTotalGeral);
            this.Controls.Add(this.lblSaldoTotal);
            this.Controls.Add(this.dgSaidas);
            this.Controls.Add(this.dgEntradas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtPrincipal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle de Gastos";
            this.Activated += new System.EventHandler(this.Principal_Activated);
            this.Load += new System.EventHandler(this.Principal_Load);
            this.Click += new System.EventHandler(this.Principal_Click);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgEntradas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgSaidas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnCadastroAno;
        private System.Windows.Forms.ToolStripMenuItem btnCadastroLancamento;
        private System.Windows.Forms.ToolStripMenuItem lançamentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnRelMensal;
        private System.Windows.Forms.ToolStripMenuItem btnRelAnual;
        private System.Windows.Forms.ToolStripMenuItem btnSair;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtPrincipal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgEntradas;
        private System.Windows.Forms.DataGridView dgSaidas;
        private System.Windows.Forms.Label lblSaldoTotal;
        private System.Windows.Forms.Label lblTotalGeral;
        private System.Windows.Forms.Label lblTotalEntrada;
        private System.Windows.Forms.Label lblTotalEntradas;
        private System.Windows.Forms.Label lblTotalSaida;
        private System.Windows.Forms.Label lblTotalSaidas;
        private System.Windows.Forms.Button refreshEntradas;
        private System.Windows.Forms.Button refreshSaidas;
        private System.Windows.Forms.ComboBox cbBuscarMes;
        private System.Windows.Forms.Label label4;
    }
}

