
namespace ControleDeGastos.View
{
    partial class frmCadLancamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadLancamento));
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.dgLancamento = new System.Windows.Forms.DataGridView();
            this.txtDescrição = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtTipo = new System.Windows.Forms.Label();
            this.txtMes = new System.Windows.Forms.Label();
            this.txtAnoLancamento = new System.Windows.Forms.Label();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.cbMes = new System.Windows.Forms.ComboBox();
            this.cbAno = new System.Windows.Forms.ComboBox();
            this.lebalBuscar = new System.Windows.Forms.Label();
            this.dtBuscar = new System.Windows.Forms.DateTimePicker();
            this.dtData = new System.Windows.Forms.DateTimePicker();
            this.txtData = new System.Windows.Forms.Label();
            this.rdBuscarData = new System.Windows.Forms.RadioButton();
            this.rdBuscarTipo = new System.Windows.Forms.RadioButton();
            this.cbBuscarTipo = new System.Windows.Forms.ComboBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.refresh = new System.Windows.Forms.Button();
            this.rdMes = new System.Windows.Forms.RadioButton();
            this.cbBuscarMes = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgLancamento)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(323, 401);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 29);
            this.btnExcluir.TabIndex = 13;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(242, 401);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 29);
            this.btnSalvar.TabIndex = 12;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(161, 401);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 29);
            this.btnEditar.TabIndex = 11;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(80, 401);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 29);
            this.btnNovo.TabIndex = 10;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // dgLancamento
            // 
            this.dgLancamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgLancamento.Location = new System.Drawing.Point(80, 179);
            this.dgLancamento.Name = "dgLancamento";
            this.dgLancamento.Size = new System.Drawing.Size(659, 213);
            this.dgLancamento.TabIndex = 9;
            this.dgLancamento.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgLancamento_CellClick);
            // 
            // txtDescrição
            // 
            this.txtDescrição.Location = new System.Drawing.Point(145, 120);
            this.txtDescrição.Name = "txtDescrição";
            this.txtDescrição.Size = new System.Drawing.Size(332, 20);
            this.txtDescrição.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Descrição:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(524, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Valor:";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(564, 120);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(110, 20);
            this.txtValor.TabIndex = 15;
            // 
            // txtTipo
            // 
            this.txtTipo.AutoSize = true;
            this.txtTipo.Location = new System.Drawing.Point(81, 85);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(31, 13);
            this.txtTipo.TabIndex = 16;
            this.txtTipo.Text = "Tipo:";
            // 
            // txtMes
            // 
            this.txtMes.AutoSize = true;
            this.txtMes.Location = new System.Drawing.Point(300, 85);
            this.txtMes.Name = "txtMes";
            this.txtMes.Size = new System.Drawing.Size(30, 13);
            this.txtMes.TabIndex = 17;
            this.txtMes.Text = "Mês:";
            // 
            // txtAnoLancamento
            // 
            this.txtAnoLancamento.AutoSize = true;
            this.txtAnoLancamento.Location = new System.Drawing.Point(524, 85);
            this.txtAnoLancamento.Name = "txtAnoLancamento";
            this.txtAnoLancamento.Size = new System.Drawing.Size(29, 13);
            this.txtAnoLancamento.TabIndex = 18;
            this.txtAnoLancamento.Text = "Ano:";
            // 
            // cbTipo
            // 
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Items.AddRange(new object[] {
            "Entradas",
            "Saidas"});
            this.cbTipo.Location = new System.Drawing.Point(118, 82);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(162, 21);
            this.cbTipo.TabIndex = 19;
            // 
            // cbMes
            // 
            this.cbMes.FormattingEnabled = true;
            this.cbMes.Items.AddRange(new object[] {
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
            this.cbMes.Location = new System.Drawing.Point(336, 82);
            this.cbMes.Name = "cbMes";
            this.cbMes.Size = new System.Drawing.Size(162, 21);
            this.cbMes.TabIndex = 20;
            // 
            // cbAno
            // 
            this.cbAno.FormattingEnabled = true;
            this.cbAno.Items.AddRange(new object[] {
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030",
            "2031",
            "2032",
            "2033",
            "2034",
            "2035"});
            this.cbAno.Location = new System.Drawing.Point(564, 77);
            this.cbAno.Name = "cbAno";
            this.cbAno.Size = new System.Drawing.Size(110, 21);
            this.cbAno.TabIndex = 21;
            // 
            // lebalBuscar
            // 
            this.lebalBuscar.AutoSize = true;
            this.lebalBuscar.Location = new System.Drawing.Point(515, 18);
            this.lebalBuscar.Name = "lebalBuscar";
            this.lebalBuscar.Size = new System.Drawing.Size(43, 13);
            this.lebalBuscar.TabIndex = 22;
            this.lebalBuscar.Text = "Buscar:";
            // 
            // dtBuscar
            // 
            this.dtBuscar.CalendarForeColor = System.Drawing.SystemColors.Info;
            this.dtBuscar.CalendarTitleBackColor = System.Drawing.SystemColors.HotTrack;
            this.dtBuscar.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtBuscar.Enabled = false;
            this.dtBuscar.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtBuscar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtBuscar.Location = new System.Drawing.Point(564, 12);
            this.dtBuscar.Name = "dtBuscar";
            this.dtBuscar.Size = new System.Drawing.Size(139, 20);
            this.dtBuscar.TabIndex = 23;
            this.dtBuscar.Tag = "";
            this.dtBuscar.Value = new System.DateTime(2022, 2, 20, 0, 0, 0, 0);
            this.dtBuscar.ValueChanged += new System.EventHandler(this.dtBuscar_ValueChanged);
            this.dtBuscar.Enter += new System.EventHandler(this.dtBuscar_Enter);
            // 
            // dtData
            // 
            this.dtData.CalendarForeColor = System.Drawing.SystemColors.Info;
            this.dtData.CalendarTitleBackColor = System.Drawing.SystemColors.HotTrack;
            this.dtData.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtData.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtData.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtData.Location = new System.Drawing.Point(118, 147);
            this.dtData.Name = "dtData";
            this.dtData.Size = new System.Drawing.Size(139, 20);
            this.dtData.TabIndex = 25;
            this.dtData.Tag = "";
            this.dtData.Value = new System.DateTime(2022, 2, 20, 0, 0, 0, 0);
            // 
            // txtData
            // 
            this.txtData.AutoSize = true;
            this.txtData.Location = new System.Drawing.Point(81, 153);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(33, 13);
            this.txtData.TabIndex = 24;
            this.txtData.Text = "Data:";
            // 
            // rdBuscarData
            // 
            this.rdBuscarData.AutoSize = true;
            this.rdBuscarData.Location = new System.Drawing.Point(398, 13);
            this.rdBuscarData.Name = "rdBuscarData";
            this.rdBuscarData.Size = new System.Drawing.Size(102, 17);
            this.rdBuscarData.TabIndex = 26;
            this.rdBuscarData.TabStop = true;
            this.rdBuscarData.Text = "Buscar por Data";
            this.rdBuscarData.UseVisualStyleBackColor = true;
            this.rdBuscarData.CheckedChanged += new System.EventHandler(this.rdBuscarData_CheckedChanged);
            // 
            // rdBuscarTipo
            // 
            this.rdBuscarTipo.AutoSize = true;
            this.rdBuscarTipo.Location = new System.Drawing.Point(290, 13);
            this.rdBuscarTipo.Name = "rdBuscarTipo";
            this.rdBuscarTipo.Size = new System.Drawing.Size(100, 17);
            this.rdBuscarTipo.TabIndex = 27;
            this.rdBuscarTipo.TabStop = true;
            this.rdBuscarTipo.Text = "Buscar por Tipo";
            this.rdBuscarTipo.UseVisualStyleBackColor = true;
            this.rdBuscarTipo.CheckedChanged += new System.EventHandler(this.rdBuscarTipo_SelectedIndexChanged);
            // 
            // cbBuscarTipo
            // 
            this.cbBuscarTipo.FormattingEnabled = true;
            this.cbBuscarTipo.Items.AddRange(new object[] {
            "Entradas",
            "Saidas"});
            this.cbBuscarTipo.Location = new System.Drawing.Point(564, 11);
            this.cbBuscarTipo.Name = "cbBuscarTipo";
            this.cbBuscarTipo.Size = new System.Drawing.Size(139, 21);
            this.cbBuscarTipo.TabIndex = 28;
            this.cbBuscarTipo.Visible = false;
            this.cbBuscarTipo.SelectedIndexChanged += new System.EventHandler(this.cbBuscarTipo_SelectedIndexChanged);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(719, 15);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(60, 20);
            this.txtId.TabIndex = 29;
            this.txtId.Visible = false;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.lblTotal.Location = new System.Drawing.Point(475, 406);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(101, 20);
            this.lblTotal.TabIndex = 30;
            this.lblTotal.Text = "Valor Total:";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(582, 404);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(21, 22);
            this.lblResultado.TabIndex = 31;
            this.lblResultado.Text = "0";
            // 
            // refresh
            // 
            this.refresh.Location = new System.Drawing.Point(12, 18);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(143, 29);
            this.refresh.TabIndex = 32;
            this.refresh.Text = "Listar Todos os Registros";
            this.refresh.UseVisualStyleBackColor = true;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // rdMes
            // 
            this.rdMes.AutoSize = true;
            this.rdMes.Location = new System.Drawing.Point(185, 15);
            this.rdMes.Name = "rdMes";
            this.rdMes.Size = new System.Drawing.Size(99, 17);
            this.rdMes.TabIndex = 33;
            this.rdMes.TabStop = true;
            this.rdMes.Text = "Buscar por Mês";
            this.rdMes.UseVisualStyleBackColor = true;
            this.rdMes.CheckedChanged += new System.EventHandler(this.rdMes_CheckedChanged);
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
            this.cbBuscarMes.Location = new System.Drawing.Point(564, 10);
            this.cbBuscarMes.Name = "cbBuscarMes";
            this.cbBuscarMes.Size = new System.Drawing.Size(139, 21);
            this.cbBuscarMes.TabIndex = 34;
            this.cbBuscarMes.Visible = false;
            this.cbBuscarMes.SelectedIndexChanged += new System.EventHandler(this.cbBuscarMes_SelectedIndexChanged);
            // 
            // frmCadLancamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 443);
            this.Controls.Add(this.cbBuscarMes);
            this.Controls.Add(this.rdMes);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.cbBuscarTipo);
            this.Controls.Add(this.rdBuscarTipo);
            this.Controls.Add(this.rdBuscarData);
            this.Controls.Add(this.dtData);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.dtBuscar);
            this.Controls.Add(this.lebalBuscar);
            this.Controls.Add(this.cbAno);
            this.Controls.Add(this.cbMes);
            this.Controls.Add(this.cbTipo);
            this.Controls.Add(this.txtAnoLancamento);
            this.Controls.Add(this.txtMes);
            this.Controls.Add(this.txtTipo);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.dgLancamento);
            this.Controls.Add(this.txtDescrição);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCadLancamento";
            this.Text = "Cadastro de Lançamento";
            this.Load += new System.EventHandler(this.frmCadLancamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgLancamento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.DataGridView dgLancamento;
        private System.Windows.Forms.TextBox txtDescrição;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label txtTipo;
        private System.Windows.Forms.Label txtMes;
        private System.Windows.Forms.Label txtAnoLancamento;
        private System.Windows.Forms.ComboBox cbTipo;
        private System.Windows.Forms.ComboBox cbMes;
        private System.Windows.Forms.ComboBox cbAno;
        private System.Windows.Forms.Label lebalBuscar;
        private System.Windows.Forms.DateTimePicker dtBuscar;
        private System.Windows.Forms.DateTimePicker dtData;
        private System.Windows.Forms.Label txtData;
        private System.Windows.Forms.RadioButton rdBuscarData;
        private System.Windows.Forms.RadioButton rdBuscarTipo;
        private System.Windows.Forms.ComboBox cbBuscarTipo;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button refresh;
        private System.Windows.Forms.RadioButton rdMes;
        private System.Windows.Forms.ComboBox cbBuscarMes;
    }
}