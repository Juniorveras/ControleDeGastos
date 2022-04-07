
namespace ControleDeGastos.Report
{
    partial class FrmRelAno
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.lancamentosPorAnoeMesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.totalEntradasPorAnoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.totalEntradasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.totalSaidasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lancamentoAnoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.txtBuscarAno = new System.Windows.Forms.Label();
            this.cbAnoRel = new System.Windows.Forms.ComboBox();
            this.totalSaidasPorAnoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.controleGastosDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.controleGastosDataSet = new ControleDeGastos.ControleGastosDataSet();
            this.lancamento_AnoTableAdapter = new ControleDeGastos.ControleGastosDataSetTableAdapters.Lancamento_AnoTableAdapter();
            this.lancamentosPorAnoeMesTableAdapter = new ControleDeGastos.ControleGastosDataSetTableAdapters.LancamentosPorAnoeMesTableAdapter();
            this.totalEntradasTableAdapter = new ControleDeGastos.ControleGastosDataSetTableAdapters.TotalEntradasTableAdapter();
            this.totalSaidasTableAdapter = new ControleDeGastos.ControleGastosDataSetTableAdapters.TotalSaidasTableAdapter();
            this.totalEntradasPorAnoTableAdapter = new ControleDeGastos.ControleGastosDataSetTableAdapters.TotalEntradasPorAnoTableAdapter();
            this.totalSaidasPorAnoTableAdapter = new ControleDeGastos.ControleGastosDataSetTableAdapters.TotalSaidasPorAnoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.lancamentosPorAnoeMesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalEntradasPorAnoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalEntradasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalSaidasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lancamentoAnoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalSaidasPorAnoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.controleGastosDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.controleGastosDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // lancamentosPorAnoeMesBindingSource
            // 
            this.lancamentosPorAnoeMesBindingSource.DataMember = "LancamentosPorAnoeMes";
            this.lancamentosPorAnoeMesBindingSource.DataSource = this.controleGastosDataSetBindingSource;
            // 
            // totalEntradasPorAnoBindingSource
            // 
            this.totalEntradasPorAnoBindingSource.DataMember = "TotalEntradasPorAno";
            this.totalEntradasPorAnoBindingSource.DataSource = this.controleGastosDataSetBindingSource;
            // 
            // totalEntradasBindingSource
            // 
            this.totalEntradasBindingSource.DataMember = "TotalEntradas";
            this.totalEntradasBindingSource.DataSource = this.controleGastosDataSetBindingSource;
            // 
            // totalSaidasBindingSource
            // 
            this.totalSaidasBindingSource.DataMember = "TotalSaidas";
            this.totalSaidasBindingSource.DataSource = this.controleGastosDataSetBindingSource;
            // 
            // lancamentoAnoBindingSource
            // 
            this.lancamentoAnoBindingSource.DataMember = "Lancamento_Ano";
            this.lancamentoAnoBindingSource.DataSource = this.controleGastosDataSetBindingSource;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSetAno";
            reportDataSource1.Value = this.lancamentosPorAnoeMesBindingSource;
            reportDataSource2.Name = "TotalEntradasPorAno";
            reportDataSource2.Value = this.totalEntradasPorAnoBindingSource;
            reportDataSource3.Name = "TotalSaidasPorAno";
            reportDataSource3.Value = this.totalSaidasPorAnoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ControleDeGastos.Report.FrmRelAno.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 60);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(776, 378);
            this.reportViewer1.TabIndex = 0;
            // 
            // txtBuscarAno
            // 
            this.txtBuscarAno.AutoSize = true;
            this.txtBuscarAno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarAno.Location = new System.Drawing.Point(12, 24);
            this.txtBuscarAno.Name = "txtBuscarAno";
            this.txtBuscarAno.Size = new System.Drawing.Size(96, 20);
            this.txtBuscarAno.TabIndex = 9;
            this.txtBuscarAno.Text = "Buscar Ano:";
            // 
            // cbAnoRel
            // 
            this.cbAnoRel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAnoRel.FormattingEnabled = true;
            this.cbAnoRel.Items.AddRange(new object[] {
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030"});
            this.cbAnoRel.Location = new System.Drawing.Point(105, 16);
            this.cbAnoRel.Name = "cbAnoRel";
            this.cbAnoRel.Size = new System.Drawing.Size(121, 28);
            this.cbAnoRel.TabIndex = 10;
            this.cbAnoRel.SelectedIndexChanged += new System.EventHandler(this.cbAnoRel_SelectedIndexChanged);
            // 
            // totalSaidasPorAnoBindingSource
            // 
            this.totalSaidasPorAnoBindingSource.DataMember = "TotalSaidasPorAno";
            this.totalSaidasPorAnoBindingSource.DataSource = this.controleGastosDataSetBindingSource;
            // 
            // controleGastosDataSetBindingSource
            // 
            this.controleGastosDataSetBindingSource.DataSource = this.controleGastosDataSet;
            this.controleGastosDataSetBindingSource.Position = 0;
            // 
            // controleGastosDataSet
            // 
            this.controleGastosDataSet.DataSetName = "ControleGastosDataSet";
            this.controleGastosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lancamento_AnoTableAdapter
            // 
            this.lancamento_AnoTableAdapter.ClearBeforeFill = true;
            // 
            // lancamentosPorAnoeMesTableAdapter
            // 
            this.lancamentosPorAnoeMesTableAdapter.ClearBeforeFill = true;
            // 
            // totalEntradasTableAdapter
            // 
            this.totalEntradasTableAdapter.ClearBeforeFill = true;
            // 
            // totalSaidasTableAdapter
            // 
            this.totalSaidasTableAdapter.ClearBeforeFill = true;
            // 
            // totalEntradasPorAnoTableAdapter
            // 
            this.totalEntradasPorAnoTableAdapter.ClearBeforeFill = true;
            // 
            // totalSaidasPorAnoTableAdapter
            // 
            this.totalSaidasPorAnoTableAdapter.ClearBeforeFill = true;
            // 
            // FrmRelAno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbAnoRel);
            this.Controls.Add(this.txtBuscarAno);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmRelAno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmRelAno";
            this.Load += new System.EventHandler(this.FrmRelAno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lancamentosPorAnoeMesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalEntradasPorAnoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalEntradasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalSaidasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lancamentoAnoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalSaidasPorAnoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.controleGastosDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.controleGastosDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource lancamentoAnoBindingSource;
        private System.Windows.Forms.BindingSource controleGastosDataSetBindingSource;
        private ControleGastosDataSet controleGastosDataSet;
        private ControleGastosDataSetTableAdapters.Lancamento_AnoTableAdapter lancamento_AnoTableAdapter;
        private System.Windows.Forms.BindingSource lancamentosPorAnoeMesBindingSource;
        private ControleGastosDataSetTableAdapters.LancamentosPorAnoeMesTableAdapter lancamentosPorAnoeMesTableAdapter;
        private System.Windows.Forms.Label txtBuscarAno;
        private System.Windows.Forms.ComboBox cbAnoRel;
        private System.Windows.Forms.BindingSource totalEntradasBindingSource;
        private ControleGastosDataSetTableAdapters.TotalEntradasTableAdapter totalEntradasTableAdapter;
        private System.Windows.Forms.BindingSource totalSaidasBindingSource;
        private ControleGastosDataSetTableAdapters.TotalSaidasTableAdapter totalSaidasTableAdapter;
        private System.Windows.Forms.BindingSource totalEntradasPorAnoBindingSource;
        private ControleGastosDataSetTableAdapters.TotalEntradasPorAnoTableAdapter totalEntradasPorAnoTableAdapter;
        private System.Windows.Forms.BindingSource totalSaidasPorAnoBindingSource;
        private ControleGastosDataSetTableAdapters.TotalSaidasPorAnoTableAdapter totalSaidasPorAnoTableAdapter;
    }
}