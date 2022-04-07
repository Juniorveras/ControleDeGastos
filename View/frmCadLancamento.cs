using ControleDeGastos.Entidades;
using ControleDeGastos.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleDeGastos.View
{
    public partial class frmCadLancamento : Form
    {
        CadastroLancamentos obj = new CadastroLancamentos();
        CadastroAno cadastroAno = new CadastroAno();
        AnoModels anoModels = new AnoModels();
        public frmCadLancamento()
        {
            InitializeComponent();
            Preencher(cadastroAno);

            dtData.Value = DateTime.Now;

            DesabilitarCampos();
            btnSalvar.Enabled = false;

            Listar();

            Totalizar();
        }

        private void Totalizar()
        {
            lblResultado.Text = valorTotal().ToString();
            if (Convert.ToDecimal(lblResultado.Text) < 0)
            {
                lblResultado.ForeColor = Color.Red;
            }
            else
            {
                lblResultado.ForeColor = Color.Green;
            }
        }

        private void DesabilitarCampos()
        {
            txtDescrição.Enabled = false;
            txtValor.Enabled = false;
            cbTipo.Enabled = false;
            cbAno.Enabled = false;
            cbMes.Enabled = false;
            dtData.Enabled = false;
        }
        private void HabilitarCampos()
        {
            txtDescrição.Enabled = true;
            txtValor.Enabled = true;
            cbTipo.Enabled = true;
            cbAno.Enabled = true;
            cbMes.Enabled = true;
            dtData.Enabled = true;
        }
        private void Limparcampos()
        {
            txtDescrição.Text = "";
            txtValor.Text = "";
            cbBuscarTipo.Text = "";
        }

        private void Preencher(CadastroAno obj)
        {
            cbAno.DataSource = anoModels.Listar(obj);
            cbAno.ValueMember = "Id_ano";
            cbAno.DisplayMember = "Ano";
        }
        private void rdBuscarData_CheckedChanged(object sender, EventArgs e)
        {
            dtBuscar.Value = DateTime.Now;
            dtBuscar.Visible = true;
            dtBuscar.Enabled = true;
            cbBuscarTipo.Visible = false;
            cbBuscarMes.Visible = false;
            cbBuscarMes.Enabled = false;

        }

        private void rdBuscarTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbBuscarTipo.Visible = true;
            cbBuscarTipo.Enabled = true;
            cbBuscarMes.Visible = false;
            cbBuscarMes.Enabled = false;
            dtBuscar.Visible = false;
            dtBuscar.Enabled = false;

        }

        private void rdMes_CheckedChanged(object sender, EventArgs e)
        {
            cbBuscarMes.Visible = true;
            cbBuscarMes.Enabled = true;
            dtBuscar.Visible = false;
            dtBuscar.Enabled = false;
            cbBuscarTipo.Visible = false;
            cbBuscarTipo.Enabled = false;            
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = new DialogResult();
            dialogResult = MessageBox.Show("Deseja incluir um novo registro ? ", " Atenção !!! ", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.OK)
            {
                HabilitarCampos();
                btnSalvar.Enabled = true;
                Limparcampos();
                Totalizar();
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = new DialogResult();
            dialogResult = MessageBox.Show("Deseja realmente adicionar este registro ? ", " Atenção !!! ", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.OK)
            {
                CadastroLancamentos cadastroLancamentos = new CadastroLancamentos();
                if (txtValor.Text == "")
                {
                    MessageBox.Show(" Por Favor inserir um Valor !!! ");
                    return;
                }
                Salvar();
                Limparcampos();
                btnSalvar.Enabled = false;
                Listar();
                Totalizar();
            }
        }
        public void DiaMesAno()
        {
            DateTime dtAtual = DateTime.Today;
            Int32 iDia = DateTime.DaysInMonth(dtAtual.Year, dtAtual.Month);
            DateTime dtUltimoDiaMes = new DateTime(dtAtual.Year, dtAtual.Month, iDia);
        }
        public void Listar()
        {
            try
            {
                List<CadastroLancamentos> lista = new List<CadastroLancamentos>();
                lista = new LancamentoModels().Listar();

                dgLancamento.DataSource = lista;
                dgLancamento.Columns[0].Visible = false;
                dgLancamento.Columns[4].Visible = false;
                dgLancamento.Columns[5].Visible = false;
                dgLancamento.Columns[1].HeaderText = "Tipo";
                dgLancamento.Columns[2].HeaderText = "Descrição";
                dgLancamento.Columns[3].HeaderText = "Valor";
                dgLancamento.Columns[6].HeaderText = "Data";

                dgLancamento.Columns[2].Width = 315;
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Não foi possivel listar as informações " + ex);
            }
        }

        private void Salvar()
        {
            try
            {
                obj.enumtipo = CadastroLancamentos.GetTipoProcessoByString(cbTipo.Text);
                obj.descricao = txtDescrição.Text;
                obj.valor = Convert.ToDecimal(txtValor.Text);
                obj.mes = cbMes.Text;
                obj.id_Ano = Convert.ToInt32(cbAno.SelectedValue);
                obj.data = Convert.ToDateTime(dtData.Text);
                int anox = LancamentoModels.Inserir(obj);
                if (anox >= 0)
                {
                    MessageBox.Show("Hehe Inserido com Sucesso ! ");
                }
                else
                {
                    MessageBox.Show("Ue se não digitou nada ! ");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eita deu algo de errado ai ! " + ex);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = new DialogResult();
            dialogResult = MessageBox.Show("Deseja continuar com a edição ? ", " Atenção !!! ", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.OK)
            {
                CadastroLancamentos cadastroLancamentos = new CadastroLancamentos();
                if (txtValor.Text == "")
                {
                    MessageBox.Show(" Por Favor inserir um Valor !!! ");
                    return;
                }

                Editar();
                Limparcampos();
                btnSalvar.Enabled = false;
                Listar();
                Totalizar();
            }
        }

        private void Editar()
        {
            try
            {
                obj.enumtipo = CadastroLancamentos.GetTipoProcessoByString(cbTipo.Text);
                obj.descricao = txtDescrição.Text;
                obj.valor = Convert.ToDecimal(txtValor.Text);
                obj.mes = cbMes.Text;
                obj.id_Ano = Convert.ToInt32(cbAno.SelectedValue);
                obj.data = Convert.ToDateTime(dtData.Text);
                obj.id_Lancamento = Convert.ToInt32(txtId.Text);
                int anox = LancamentoModels.Editar(obj);
                if (anox >= 0)
                {
                    MessageBox.Show("Hehe Editado com Sucesso ! Ve se para de errar !!! kkk... ");
                }

                else
                {
                    MessageBox.Show("Eita não foi Editado se fez algo de errado ! ");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eita deu algo de errado ai ! " + ex);
            }
        }
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = new DialogResult();
            dialogResult = MessageBox.Show("Deseja continuar com esta opção ? O REGISTRO SERÁ EXCLUIDO. ", " Atenção !!! ", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.OK)
            {
                if (txtValor.Text == "")
                {
                    MessageBox.Show(" Selecione um REGISTRO para excluir !!! ");
                    return;
                }
                Excluir();
                DesabilitarCampos();
                Limparcampos();
                btnSalvar.Enabled = false;


                Listar();
                Totalizar();
            }
        }

        private void Excluir()
        {
            try
            {
            obj.id_Lancamento = Convert.ToInt32(txtId.Text);
            int anox = LancamentoModels.Excluir(obj);
            if (anox >= 1)
            {
                MessageBox.Show("Hehe Deletado com Sucesso ! ");
            }
            else
            {
                MessageBox.Show("Ue se não digitou nada ! ");
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eita deu algo de errado ai ! " + ex);
            }
        }
        private void cbBuscarMes_SelectedIndexChanged(object sender, EventArgs e)
        {
            obj.mes = cbBuscarMes.Text;
            List<CadastroLancamentos> lista = new List<CadastroLancamentos>();
            lista = new LancamentoModels().BuscarMes(obj);
            dgLancamento.AutoGenerateColumns = false;
            dgLancamento.DataSource = lista;
            Totalizar();
        }

        private void cbBuscarTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            obj.enumtipo = CadastroLancamentos.GetTipoProcessoByString(cbBuscarTipo.Text);
            List<CadastroLancamentos> lista = new List<CadastroLancamentos>();
            lista = new LancamentoModels().BuscarTipo(obj);
            dgLancamento.AutoGenerateColumns = false;
            dgLancamento.DataSource = lista;
            Totalizar();
        }

        private void dgLancamento_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            HabilitarCampos();
            txtId.Text = dgLancamento.CurrentRow.Cells[0].Value.ToString();
            cbTipo.Text = dgLancamento.CurrentRow.Cells[1].Value.ToString();
            txtDescrição.Text = dgLancamento.CurrentRow.Cells[2].Value.ToString();
            txtValor.Text = dgLancamento.CurrentRow.Cells[3].Value.ToString();
            cbMes.Text = dgLancamento.CurrentRow.Cells[4].Value.ToString();
            cbAno.SelectedItem = dgLancamento.CurrentRow.Cells[5].Value.ToString();
            dtData.Text = dgLancamento.CurrentRow.Cells[6].Value.ToString();
        }

        private void dtBuscar_ValueChanged(object sender, EventArgs e)
        {
            obj.data = Convert.ToDateTime(dtBuscar.Text);
            List<CadastroLancamentos> lista = new List<CadastroLancamentos>();
            lista = new LancamentoModels().Buscar(obj);
            dgLancamento.AutoGenerateColumns = false;
            dgLancamento.DataSource = lista;
            Totalizar();
        }
        private decimal valorTotal()
        {
            decimal totalEntradas = 0;
            decimal totalSaidas = 0;

            DateTime dtAtual = DateTime.Today;
            Int32 iDia = DateTime.DaysInMonth(dtAtual.Year, dtAtual.Month);
            DateTime dtUltimoDiaMes = new DateTime(dtAtual.Year, dtAtual.Month, iDia);

            iDia = 0;
            for(iDia = 0; iDia < dgLancamento.Rows.Count; iDia++)
            {
                if (dgLancamento.Rows[iDia].Cells[1].Value.ToString() == "Entradas")
                {
                    totalEntradas = totalEntradas + Convert.ToDecimal(dgLancamento.Rows[iDia].Cells[3].Value);
                }
                else
                {
                    totalSaidas = totalSaidas + Convert.ToDecimal(dgLancamento.Rows[iDia].Cells[3].Value);
                }
                
            }
            return totalEntradas - totalSaidas;
        }

        private void refresh_Click(object sender, EventArgs e)
        {            
            refresh.Enabled = true;
            btnSalvar.Enabled = false;
            Limparcampos();            
            Listar();
            Totalizar();
        }

        private void dtBuscar_Enter(object sender, EventArgs e)
        {
            dtBuscar.Text = DateTime.Now.ToString();
        }

        private void frmCadLancamento_Load(object sender, EventArgs e)
        {

        }        
    }
}
