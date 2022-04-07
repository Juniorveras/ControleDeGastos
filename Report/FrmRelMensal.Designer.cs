
namespace ControleDeGastos.Report
{
    partial class FrmRelMensal
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource5 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.cbMes = new System.Windows.Forms.ComboBox();
            this.txtMes = new System.Windows.Forms.Label();
            this.lancamentoAnoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.controleGastosDataSet = new ControleDeGastos.ControleGastosDataSet();
            this.totalEntradasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.totalSaidasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.somaDiasPorMesEntradasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.somaDiasPorMesSaidasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lancamentoPorMesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lancamentosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lancamentosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lancamentosTableAdapter = new ControleDeGastos.ControleGastosDataSetTableAdapters.LancamentosTableAdapter();
            this.lancamento_AnoTableAdapter = new ControleDeGastos.ControleGastosDataSetTableAdapters.Lancamento_AnoTableAdapter();
            this.totalEntradasTableAdapter = new ControleDeGastos.ControleGastosDataSetTableAdapters.TotalEntradasTableAdapter();
            this.totalSaidasTableAdapter = new ControleDeGastos.ControleGastosDataSetTableAdapters.TotalSaidasTableAdapter();
            this.lancamentoPorMesTableAdapter = new ControleDeGastos.ControleGastosDataSetTableAdapters.LancamentoPorMesTableAdapter();
            this.lancamentoPorMesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.controleGastosDataSet1 = new ControleDeGastos.ControleGastosDataSet();
            this.lancamentoPorMesBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.somaDiasPorMesEntradasTableAdapter = new ControleDeGastos.ControleGastosDataSetTableAdapters.SomaDiasPorMesEntradasTableAdapter();
            this.somaDiasPorMesSaidasTableAdapter = new ControleDeGastos.ControleGastosDataSetTableAdapters.SomaDiasPorMesSaidasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.lancamentoAnoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.controleGastosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalEntradasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalSaidasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.somaDiasPorMesEntradasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.somaDiasPorMesSaidasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lancamentoPorMesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lancamentosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lancamentosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lancamentoPorMesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.controleGastosDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lancamentoPorMesBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.lancamentoAnoBindingSource;
            reportDataSource2.Name = "DataSet2";
            reportDataSource2.Value = this.totalEntradasBindingSource;
            reportDataSource3.Name = "DataSet3";
            reportDataSource3.Value = this.totalSaidasBindingSource;
            reportDataSource4.Name = "DataSetMesEntradas";
            reportDataSource4.Value = this.somaDiasPorMesEntradasBindingSource;
            reportDataSource5.Name = "DataSetMesSaidas";
            reportDataSource5.Value = this.somaDiasPorMesSaidasBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource5);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ControleDeGastos.Report.RelMensal.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 46);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(776, 392);
            this.reportViewer1.TabIndex = 0;
            // 
            // cbMes
            // 
            this.cbMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.cbMes.Location = new System.Drawing.Point(53, 12);
            this.cbMes.Name = "cbMes";
            this.cbMes.Size = new System.Drawing.Size(162, 26);
            this.cbMes.TabIndex = 22;
            this.cbMes.SelectedIndexChanged += new System.EventHandler(this.cbMes_SelectedIndexChanged);
            this.cbMes.SelectionChangeCommitted += new System.EventHandler(this.cbMes_SelectionChangeCommitted);
            // 
            // txtMes
            // 
            this.txtMes.AutoSize = true;
            this.txtMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMes.Location = new System.Drawing.Point(16, 15);
            this.txtMes.Name = "txtMes";
            this.txtMes.Size = new System.Drawing.Size(41, 18);
            this.txtMes.TabIndex = 21;
            this.txtMes.Text = "Mês:";
            // 
            // lancamentoAnoBindingSource
            // 
            this.lancamentoAnoBindingSource.DataMember = "Lancamento_Ano";
            this.lancamentoAnoBindingSource.DataSource = this.controleGastosDataSet;
            // 
            // controleGastosDataSet
            // 
            this.controleGastosDataSet.DataSetName = "ControleGastosDataSet";
            this.controleGastosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // totalEntradasBindingSource
            // 
            this.totalEntradasBindingSource.DataMember = "TotalEntradas";
            this.totalEntradasBindingSource.DataSource = this.controleGastosDataSet;
            // 
            // totalSaidasBindingSource
            // 
            this.totalSaidasBindingSource.DataMember = "TotalSaidas";
            this.totalSaidasBindingSource.DataSource = this.controleGastosDataSet;
            // 
            // somaDiasPorMesEntradasBindingSource
            // 
            this.somaDiasPorMesEntradasBindingSource.DataMember = "SomaDiasPorMesEntradas";
            this.somaDiasPorMesEntradasBindingSource.DataSource = this.controleGastosDataSet;
            // 
            // somaDiasPorMesSaidasBindingSource
            // 
            this.somaDiasPorMesSaidasBindingSource.DataMember = "SomaDiasPorMesSaidas";
            this.somaDiasPorMesSaidasBindingSource.DataSource = this.controleGastosDataSet;
            // 
            // lancamentoPorMesBindingSource
            // 
            this.lancamentoPorMesBindingSource.DataMember = "LancamentoPorMes";
            this.lancamentoPorMesBindingSource.DataSource = this.controleGastosDataSet;
            // 
            // lancamentosBindingSource1
            // 
            this.lancamentosBindingSource1.DataMember = "Lancamentos";
            this.lancamentosBindingSource1.DataSource = this.controleGastosDataSet;
            // 
            // lancamentosBindingSource
            // 
            this.lancamentosBindingSource.DataMember = "Lancamentos";
            this.lancamentosBindingSource.DataSource = this.controleGastosDataSet;
            // 
            // lancamentosTableAdapter
            // 
            this.lancamentosTableAdapter.ClearBeforeFill = true;
            // 
            // lancamento_AnoTableAdapter
            // 
            this.lancamento_AnoTableAdapter.ClearBeforeFill = true;
            // 
            // totalEntradasTableAdapter
            // 
            this.totalEntradasTableAdapter.ClearBeforeFill = true;
            // 
            // totalSaidasTableAdapter
            // 
            this.totalSaidasTableAdapter.ClearBeforeFill = true;
            // 
            // lancamentoPorMesTableAdapter
            // 
            this.lancamentoPorMesTableAdapter.ClearBeforeFill = true;
            // 
            // lancamentoPorMesBindingSource1
            // 
            this.lancamentoPorMesBindingSource1.DataMember = "LancamentoPorMes";
            this.lancamentoPorMesBindingSource1.DataSource = this.controleGastosDataSet;
            // 
            // controleGastosDataSet1
            // 
            this.controleGastosDataSet1.DataSetName = "ControleGastosDataSet";
            this.controleGastosDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lancamentoPorMesBindingSource2
            // 
            this.lancamentoPorMesBindingSource2.DataMember = "LancamentoPorMes";
            this.lancamentoPorMesBindingSource2.DataSource = this.controleGastosDataSet1;
            // 
            // somaDiasPorMesEntradasTableAdapter
            // 
            this.somaDiasPorMesEntradasTableAdapter.ClearBeforeFill = true;
            // 
            // somaDiasPorMesSaidasTableAdapter
            // 
            this.somaDiasPorMesSaidasTableAdapter.ClearBeforeFill = true;
            // 
            // FrmRelMensal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbMes);
            this.Controls.Add(this.txtMes);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmRelMensal";
            this.Text = "FrmRelMensal";
            this.Load += new System.EventHandler(this.FrmRelMensal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lancamentoAnoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.controleGastosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalEntradasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.totalSaidasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.somaDiasPorMesEntradasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.somaDiasPorMesSaidasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lancamentoPorMesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lancamentosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lancamentosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lancamentoPorMesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.controleGastosDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lancamentoPorMesBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private ControleGastosDataSet controleGastosDataSet;
        private System.Windows.Forms.BindingSource lancamentosBindingSource;
        private ControleGastosDataSetTableAdapters.LancamentosTableAdapter lancamentosTableAdapter;
        private System.Windows.Forms.BindingSource lancamentosBindingSource1;
        private System.Windows.Forms.BindingSource lancamentoAnoBindingSource;
        private ControleGastosDataSetTableAdapters.Lancamento_AnoTableAdapter lancamento_AnoTableAdapter;
        private System.Windows.Forms.ComboBox cbMes;
        private System.Windows.Forms.Label txtMes;
        private System.Windows.Forms.BindingSource totalEntradasBindingSource;
        private ControleGastosDataSetTableAdapters.TotalEntradasTableAdapter totalEntradasTableAdapter;
        private System.Windows.Forms.BindingSource totalSaidasBindingSource;
        private ControleGastosDataSetTableAdapters.TotalSaidasTableAdapter totalSaidasTableAdapter;
        private System.Windows.Forms.BindingSource lancamentoPorMesBindingSource;
        private ControleGastosDataSetTableAdapters.LancamentoPorMesTableAdapter lancamentoPorMesTableAdapter;
        private System.Windows.Forms.BindingSource lancamentoPorMesBindingSource1;
        private System.Windows.Forms.BindingSource lancamentoPorMesBindingSource2;
        private ControleGastosDataSet controleGastosDataSet1;
        private System.Windows.Forms.BindingSource somaDiasPorMesEntradasBindingSource;
        private ControleGastosDataSetTableAdapters.SomaDiasPorMesEntradasTableAdapter somaDiasPorMesEntradasTableAdapter;
        private System.Windows.Forms.BindingSource somaDiasPorMesSaidasBindingSource;
        private ControleGastosDataSetTableAdapters.SomaDiasPorMesSaidasTableAdapter somaDiasPorMesSaidasTableAdapter;
    }
}