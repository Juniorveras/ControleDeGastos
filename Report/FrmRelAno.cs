using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleDeGastos.Report
{
    public partial class FrmRelAno : Form
    {
        public FrmRelAno()
        {
            InitializeComponent();
        }

        private void FrmRelAno_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'controleGastosDataSet.TotalSaidasPorAno'. Você pode movê-la ou removê-la conforme necessário.
            this.totalSaidasPorAnoTableAdapter.Fill(this.controleGastosDataSet.TotalSaidasPorAno);
            // TODO: esta linha de código carrega dados na tabela 'controleGastosDataSet.TotalEntradasPorAno'. Você pode movê-la ou removê-la conforme necessário.
            this.totalEntradasPorAnoTableAdapter.Fill(this.controleGastosDataSet.TotalEntradasPorAno);
            // TODO: esta linha de código carrega dados na tabela 'controleGastosDataSet.TotalSaidas'. Você pode movê-la ou removê-la conforme necessário.
            this.totalSaidasTableAdapter.Fill(this.controleGastosDataSet.TotalSaidas);
            // TODO: esta linha de código carrega dados na tabela 'controleGastosDataSet.TotalEntradas'. Você pode movê-la ou removê-la conforme necessário.
            this.totalEntradasTableAdapter.Fill(this.controleGastosDataSet.TotalEntradas);
            // TODO: esta linha de código carrega dados na tabela 'controleGastosDataSet.LancamentosPorAnoeMes'. Você pode movê-la ou removê-la conforme necessário.
            //this.lancamentosPorAnoeMesTableAdapter.Fill(this.controleGastosDataSet.LancamentosPorAnoeMes, Convert.ToInt32(cbAnoRel.SelectedItem));

            //this.reportViewer1.RefreshReport();
        }

        private void cbAnoRel_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbAnoRel_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.lancamentosPorAnoeMesTableAdapter.Fill(this.controleGastosDataSet.LancamentosPorAnoeMes, Convert.ToInt32(cbAnoRel.SelectedItem));

            this.reportViewer1.RefreshReport();
        }
    }
}
