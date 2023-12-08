using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Quasar_CRUD.Model;
using Quasar_CRUD.BLL;
using MySql.Data.MySqlClient;

namespace Quasar_CRUD
{
    public partial class Form1 : Form
    {
      public Form1()
      {
            InitializeComponent();
      }
        //Método para Excluir
        private void Excluir(Quasar quasar)
        {
            QuasarBLL quasarBLL = new QuasarBLL();
            if (txtCodigo.Text == string.Empty)
            {
                MessageBox.Show("Selecione um cadastro para ser excluído!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (MessageBox.Show("Deseja excluir o cadastro selecionado?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                quasar.Id = Convert.ToInt32(txtCodigo.Text);

                quasarBLL.Excluir(quasar);

                MessageBox.Show("Excluído com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpar();
            }
        }

        //Método para Alterar
        private void Alterar(Quasar quasar)
        {
            QuasarBLL quasarBLL = new QuasarBLL();

            if (txtRed.Text.Trim() == String.Empty || txtRed.Text.Trim().Length < 3)
            {
                MessageBox.Show("O campo RED não pode ser vazio!", "Alerta",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtRed.BackColor = Color.LightCoral;
                txtNome.BackColor = Color.White;
                txtMassa.BackColor = Color.White;
            }
            else if (txtNome.Text.Trim() == String.Empty)
            {
                MessageBox.Show("O campo NOME não pode ser vazio!", "Alerta",
                   MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNome.BackColor = Color.LightCoral;
                txtRed.BackColor = Color.White;
                txtMassa.BackColor = Color.White;
            }
            else if (txtMassa.Text == String.Empty)
            {
                MessageBox.Show("O campo MASSA não pode ser vazio!", "Alerta",
                   MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtMassa.BackColor = Color.LightCoral;
                txtRed.BackColor = Color.White;
                txtNome.BackColor = Color.White;
            }
            else
            {
                quasar.Id = Convert.ToInt32(txtCodigo.Text);
                quasar.Red = txtRed.Text;
                quasar.Descoberta = dtDesco.Text;
                quasar.Nome = txtNome.Text;
                quasar.Massa = txtMassa.Text;
                quasar.Lumi = txtLumi.Text;
                quasar.Gala = txtGala.Text;

                quasarBLL.Alterar(quasar);
                MessageBox.Show("Atualizado com sucesso!", "Aviso",
                  MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                Limpar();
            }
        }
        //Método para salvar
        private void Salvar(Quasar quasar)
        {
            QuasarBLL quasarBLL = new QuasarBLL();

            if (txtRed.Text.Trim() == String.Empty || txtRed.Text.Trim().Length < 3)
            {
                MessageBox.Show("O campo RED não pode ser vazio!", "Alerta",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtRed.BackColor = Color.LightCoral;
                txtNome.BackColor = Color.White;
                txtMassa.BackColor = Color.White;
            }
            else if (txtNome.Text.Trim() == String.Empty)
            {
                MessageBox.Show("O campo NOME não pode ser vazio!", "Alerta",
                   MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNome.BackColor = Color.LightCoral;
                txtRed.BackColor = Color.White;
                txtMassa.BackColor = Color.White;
            }
            else if (txtMassa.Text == String.Empty)
            {
                MessageBox.Show("O campo MASSA não pode ser vazio!", "Alerta",
                   MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtMassa.BackColor = Color.LightCoral;
                txtRed.BackColor = Color.White;
                txtNome.BackColor = Color.White;
            }
            else
            {
                quasar.Red = txtRed.Text;
                quasar.Descoberta = dtDesco.Text;
                quasar.Nome = txtNome.Text;
                quasar.Massa = txtMassa.Text;
                quasar.Lumi = txtLumi.Text;
                quasar.Gala = txtGala.Text;

                quasarBLL.Salvar(quasar);
                MessageBox.Show("Cadastro realizado com sucesso!", "Aviso",
                  MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                Limpar();
            }
        }
        //Método para limpar os campos do formulário

        public void Limpar()
        {
            txtCodigo.Clear();
            txtRed.Clear();
            txtLumi.Clear();
            txtGala.Clear();
            txtNome.Clear();
            txtMassa.Clear();
            dtDesco.ResetText();
            txtRed.BackColor = Color.White;
            txtNome.BackColor = Color.White;
            txtMassa.BackColor = Color.White;
        }
        //Métodos para exibir os dados na tela
        private void Listar()
        {
            QuasarBLL quasarBLL = new QuasarBLL();
            try
            {
                dataGridView1.DataSource = quasarBLL.Listar();
            }
            catch (Exception erro)
            {
                throw erro;
            }
            //Renomear os cabeçalhos das colunas
            dataGridView1.Columns[0].HeaderText = "Código";
            dataGridView1.Columns[1].HeaderText = "Nome";
            dataGridView1.Columns[2].HeaderText = "Descoberta";
            dataGridView1.Columns[3].HeaderText = "Redshift";
            dataGridView1.Columns[4].HeaderText = "Massa";
            dataGridView1.Columns[5].HeaderText = "Luminosidade";
            dataGridView1.Columns[6].HeaderText = "Galáxia";

            //Ajustar largura das colunas
            dataGridView1.Columns[0].Width = 50;
            dataGridView1.Columns[1].Width = 150;
            dataGridView1.Columns[2].Width = 75;
            dataGridView1.Columns[3].Width = 50;
            dataGridView1.Columns[4].Width = 85;
            dataGridView1.Columns[5].Width = 85;
            dataGridView1.Columns[6].Width = 85;
        }

        //Métodos dos botões do formulário
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Quasar quasar = new Quasar();
            Salvar(quasar);
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Listar();
            Limpar();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //Eu não cliquei duas vezes na tela, eu juro.
        }

        //Método duplo clique na linha do DataGrid
        private void dataGridView1_DoubleClick_1(object sender, EventArgs e)
        {
            txtCodigo.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtNome.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            dtDesco.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtRed.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtMassa.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtLumi.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtGala.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
        }

        //Método para cancelar as informações nos campos
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Quasar quasar = new Quasar();
            Alterar(quasar);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Quasar quasar = new Quasar();
            Excluir(quasar);
        }
    }
}