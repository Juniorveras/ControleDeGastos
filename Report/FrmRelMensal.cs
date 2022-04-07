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
    public partial class FrmRelMensal : Form
    {
        public FrmRelMensal()
        {
            InitializeComponent();
        }

        private void FrmRelMensal_Load(object sender, EventArgs e)
        {            
            // TODO: esta linha de código carrega dados na tabela 'controleGastosDataSet.TotalSaidas'. Você pode movê-la ou removê-la conforme necessário.
            this.totalSaidasTableAdapter.Fill(this.controleGastosDataSet.TotalSaidas);
            // TODO: esta linha de código carrega dados na tabela 'controleGastosDataSet.TotalEntradas'. Você pode movê-la ou removê-la conforme necessário.
            this.totalEntradasTableAdapter.Fill(this.controleGastosDataSet.TotalEntradas);
        }

        private void cbMes_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
        }

        private void cbMes_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.somaDiasPorMesSaidasTableAdapter.Fill(this.controleGastosDataSet.SomaDiasPorMesSaidas, cbMes.Text);
            this.somaDiasPorMesEntradasTableAdapter.Fill(this.controleGastosDataSet.SomaDiasPorMesEntradas, cbMes.Text);
            this.lancamento_AnoTableAdapter.Fill(this.controleGastosDataSet.Lancamento_Ano, cbMes.Text);
            this.reportViewer1.RefreshReport();
        }
    }
}
