using ControleDeGastos.Controllers;
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
    public partial class frmCadAno : Form
    {
        CadastroAno obj = new CadastroAno();
        public frmCadAno()
        {
            InitializeComponent();
            Listar();
        }
        private void Listar()
        {
            try
            {
                //Listar as entidades CadastroAno - Id_Ano e Ano
                List<CadastroAno> lista = new List<CadastroAno>();
                lista = new AnoModels().Listar(obj);

                dataGridView1.DataSource = lista;
                dataGridView1.ReadOnly = true;
                dataGridView1.AllowUserToAddRows = false;
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[1].HeaderText = "Ano";
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Não foi possivel listar as informações " + ex);
            }
        }

        private void txtAno_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = new DialogResult();
            dialogResult = MessageBox.Show("Deseja adicionar um novo ANO ? ", " Atenção !!! ", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.OK)
            {
                btnSalvar.Enabled = true;
                txtAno.Enabled = true;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtAno.Text == "")
            {
                MessageBox.Show(" Por Favor inserir um ANO !!! ");
                return;
            }
            Salvar();

            btnSalvar.Enabled = false;
            txtAno.Enabled = false;
            txtAno.Text = "";
            Listar();
        }

        public void Salvar()
        {
            try
            {
                obj.ano = Convert.ToInt32(txtAno.Text);
                int anox = AnoModels.Inserir(obj);
                if (anox >= 1)
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

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "")
            {
                Listar();
                return;
            }
            else
            {
                obj.ano = Convert.ToInt32(txtBuscar.Text);
                List<CadastroAno> lista = new List<CadastroAno>();
                lista = new AnoModels().Buscar(obj);
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = lista;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtAno.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();

            txtAno.Enabled = true;

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = new DialogResult();
            dialogResult = MessageBox.Show("Deseja continuar com a edição do ANO ? ", " Atenção !!! ", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.OK)
            {
                if (txtAno.Text == "")
                {
                    MessageBox.Show(" Deseja realmete EDITAR ? Selecione um ANO por favor ");
                    return;
                }
                Editar();

                btnSalvar.Enabled = false;
                txtAno.Enabled = false;
                txtAno.Text = "";
                Listar();
            }
        }

        private void Editar()
        {
            try
            {
                obj.ano = Convert.ToInt32(txtAno.Text);
                obj.id_Ano = Convert.ToInt32(txtId.Text);
                int anox = AnoModels.Editar(obj);
                if (anox > 0)
                {
                    MessageBox.Show("Hehe Editado com Sucesso ! ");
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

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = new DialogResult();
            dialogResult = MessageBox.Show("Deseja realmente excluir o ANO selecionado ? ", " Atenção !!! ", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.OK)
            {
                if (txtAno.Text == "")
                {
                    MessageBox.Show(" Selecione um REGISTRO para excluir !!! ");
                    return;
                }
                Excluir();

                btnSalvar.Enabled = false;
                txtAno.Enabled = false;
                txtAno.Text = "";
                Listar();
            }
        }
    

        private void Excluir()
        {
            try
            {
                obj.ano = Convert.ToInt32(txtAno.Text);
                int anox = AnoModels.Excluir(obj);
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
    }  
}
