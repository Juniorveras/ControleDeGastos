using ControleDeGastos.Entidades;
using ControleDeGastos.Models;
using ControleDeGastos.Report;
using ControleDeGastos.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleDeGastos
{
    public partial class Principal : Form
    {
        CadastroLancamentos obj = new CadastroLancamentos();
        LancamentoModels models = new LancamentoModels();

        public Principal()
        {
            InitializeComponent();   

            Listar();
            cbBuscarMes.SelectedIndex = DateTime.Now.Month - 1;
            Totalizar();
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        private void lançamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastroAno_Click(object sender, EventArgs e)
        {
            frmCadAno cadAno = new frmCadAno();
            cadAno.ShowDialog();
        }

        private void btnCadastroLancamento_Click(object sender, EventArgs e)
        {
            frmCadLancamento cadastroLancamento = new frmCadLancamento();
            cadastroLancamento.ShowDialog();
        }
        private void cbBuscarMes_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        private void cbBuscarMes_SelectedValueChanged(object sender, EventArgs e)
        {
            BuscarporMes();
        }
        public void BuscarporMes()
        {
            obj.mes = Convert.ToString(cbBuscarMes.SelectedItem);
            obj.enumtipo = Tipo.Entradas;
            List<CadastroLancamentos> listaEntradas = new List<CadastroLancamentos>();
            listaEntradas = models.BuscarDataEntradaMes(obj);
            dgEntradas.AutoGenerateColumns = false;
            dgEntradas.DataSource = listaEntradas;

            List<CadastroLancamentos> listaSaidas = new List<CadastroLancamentos>();
            listaSaidas = models.BuscarDataSaidaMes(obj);
            dgSaidas.AutoGenerateColumns = false;
            dgSaidas.DataSource = listaSaidas;

            Totalizar();
        } 
        private void dtPrincipal_ValueChanged(object sender, EventArgs e)
        {
            ListarTela();
        }
        public void ListarTela()
        {
            obj.data = Convert.ToDateTime(dtPrincipal.Text);
            obj.enumtipo = Tipo.Entradas;
            List<CadastroLancamentos> listaEntradas = new List<CadastroLancamentos>();
            listaEntradas = models.BuscarDataTipoEntrada(obj);
            dgEntradas.AutoGenerateColumns = false;
            dgEntradas.DataSource = listaEntradas;

            List<CadastroLancamentos> listaSaidas = new List<CadastroLancamentos>();
            listaSaidas = models.BuscarDataTipoSaida(obj);
            dgSaidas.AutoGenerateColumns = false;
            dgSaidas.DataSource = listaSaidas;


            Totalizar();
        }
        public void Listar()
        {
            try
            {
                List<CadastroLancamentos> lista = new List<CadastroLancamentos>();
                
                dgEntradas.DataSource = lista;
                dgEntradas.Columns[0].Visible = false;
                dgEntradas.Columns[4].Visible = false;
                dgEntradas.Columns[5].Visible = false;
                dgEntradas.Columns[1].Visible = false;
                dgEntradas.Columns[1].HeaderText = "Tipo";
                dgEntradas.Columns[2].HeaderText = "Descrição";
                dgEntradas.Columns[3].HeaderText = "Valor";
                dgEntradas.Columns[6].HeaderText = "Data";

                dgEntradas.Columns[2].Width = 175;


                dgSaidas.DataSource = lista;
                dgSaidas.Columns[0].Visible = false;
                dgSaidas.Columns[4].Visible = false;
                dgSaidas.Columns[5].Visible = false;
                dgSaidas.Columns[1].Visible = false;
                dgSaidas.Columns[1].HeaderText = "Tipo";
                dgSaidas.Columns[2].HeaderText = "Descrição";
                dgSaidas.Columns[3].HeaderText = "Valor";
                dgSaidas.Columns[6].HeaderText = "Data";

                dgSaidas.Columns[2].Width = 175;
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Não foi possivel listar as informações " + ex);
            }
        }
        private void ListarTodosEntradas()
        {
            try
            {
                List<CadastroLancamentos> lista = new List<CadastroLancamentos>();
                lista = new LancamentoModels().ListarTodosEntradas();

                dgEntradas.DataSource = lista;
                dgEntradas.Columns[0].Visible = false;
                dgEntradas.Columns[4].Visible = false;
                dgEntradas.Columns[5].Visible = false;
                dgEntradas.Columns[1].Visible = false;
                dgEntradas.Columns[1].HeaderText = "Tipo";
                dgEntradas.Columns[2].HeaderText = "Descrição";
                dgEntradas.Columns[3].HeaderText = "Valor";
                dgEntradas.Columns[6].HeaderText = "Data";

                dgEntradas.Columns[2].Width = 175;

                Totalizar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Não foi possivel listar as informações " + ex);
            }
        }
        private void ListarTodosSaidas()
        {
            try
            {
                List<CadastroLancamentos> lista = new List<CadastroLancamentos>();
                lista = new LancamentoModels().ListarTodosSaidas();

                dgSaidas.DataSource = lista;
                dgSaidas.Columns[0].Visible = false;
                dgSaidas.Columns[4].Visible = false;
                dgSaidas.Columns[5].Visible = false;
                dgSaidas.Columns[1].Visible = false;
                dgSaidas.Columns[1].HeaderText = "Tipo";
                dgSaidas.Columns[2].HeaderText = "Descrição";
                dgSaidas.Columns[3].HeaderText = "Valor";
                dgSaidas.Columns[6].HeaderText = "Data";

                dgSaidas.Columns[2].Width = 175;

                Totalizar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Não foi possivel listar as informações " + ex);
            }
        }
        private void Totalizar()
        {
            decimal total = ValorTotalEntradas() - ValorTotalSaidas();

            lblTotalEntradas.Text = ValorTotalEntradas().ToString();
            lblTotalSaidas.Text = ValorTotalSaidas().ToString();
            lblTotalGeral.Text = total.ToString();

            if (Convert.ToDecimal(lblTotalGeral.Text) < 0)
            {
                lblTotalGeral.ForeColor = Color.Red;
            }
            else
            {
                lblTotalGeral.ForeColor = Color.Green;
            }
        }
        private decimal ValorTotalEntradas()
        {
            decimal totalEntradas = 0;
            
            int i = 0;
            for (i = 0; i < dgEntradas.Rows.Count; i++)
            {                
                    totalEntradas = totalEntradas + Convert.ToDecimal(dgEntradas.Rows[i].Cells[3].Value);              
            }
            return totalEntradas;
        }        
        private decimal ValorTotalSaidas()
        {
            decimal totalSaidas = 0;

            int i = 0;
            for (i = 0; i < dgSaidas.Rows.Count; i++)
            {                
                totalSaidas = totalSaidas + Convert.ToDecimal(dgSaidas.Rows[i].Cells[3].Value);
            }
            return totalSaidas;
        }
        private void dtPrincipal_Enter(object sender, EventArgs e)
        {
            dtPrincipal.Text = DateTime.Now.ToString();
        }
        private void refreshSaidas_Click(object sender, EventArgs e)
        {
            refreshSaidas.Enabled = true;
            ListarTodosSaidas();
            Totalizar();
        }
        private void refresh_Click(object sender, EventArgs e)
        {
            refreshEntradas.Enabled = true;
            ListarTodosEntradas();
            Totalizar();
        }  
        private void Principal_Click(object sender, EventArgs e)
        {
            ListarTela();
        }
        private void Principal_Activated(object sender, EventArgs e)
        {
           ListarTela();
        }
        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRelMensal_Click(object sender, EventArgs e)
        {
            FrmRelMensal frm = new FrmRelMensal();
            frm.ShowDialog();
        }

        private void btnRelAnual_Click(object sender, EventArgs e)
        {
            FrmRelAno frmRelAno = new FrmRelAno();
            frmRelAno.ShowDialog();
        }
    }
}
