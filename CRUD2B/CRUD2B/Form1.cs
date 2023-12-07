using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CRUD_de_Música.Model;
using CRUD_de_Música.BLL;

namespace CRUD_de_Música
{
    public partial class Form1 : Form
    {
      public Form1()
      {
            InitializeComponent();
      }
        
        //Método para Alterar
        private void Alterar(Musica musica)
        {
            MusicaBLL musicaBLL = new MusicaBLL();

            if (txtTitulo.Text.Trim() == String.Empty || txtTitulo.Text.Trim().Length < 3)
            {
                MessageBox.Show("O campo TÍTULO não pode ser vazio!", "Alerta",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtTitulo.BackColor = Color.LightCoral;
                txtISRC.BackColor = Color.White;
                txtAutor.BackColor = Color.White;
            }
            else if (txtISRC.Text.Trim() == String.Empty)
            {
                MessageBox.Show("O campo ISRC não pode ser vazio!", "Alerta",
                   MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtISRC.BackColor = Color.LightCoral;
                txtTitulo.BackColor = Color.White;
                txtAutor.BackColor = Color.White;
            }
            else if (txtAutor.Text == String.Empty)
            {
                MessageBox.Show("O campo AUTOR não pode ser vazio!", "Alerta",
                   MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtAutor.BackColor = Color.LightCoral;
                txtTitulo.BackColor = Color.White;
                txtISRC.BackColor = Color.White;
            }
            else
            {
                musica.Id = Convert.ToInt32(txtCodigo.Text);
                musica.Titulo = txtTitulo.Text;
                musica.Lancamento = dtLanca.Text;
                musica.ISRC = txtISRC.Text;
                musica.Autor = txtAutor.Text;
                musica.Interprete = txtInter.Text;
                musica.Produtor = txtProd.Text;
                musica.Editora = txtEdit.Text;
                musica.Genero = txtGen.Text;

                musicaBLL.Alterar(musica);
                MessageBox.Show("Atualizado com sucesso!", "Aviso",
                  MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                Limpar();
            }
        }
        //Método para salvar
        private void Salvar(Musica musica)
        {
            MusicaBLL musicaBLL = new MusicaBLL();

            if (txtTitulo.Text.Trim() == String.Empty || txtTitulo.Text.Trim().Length < 3)
            {
                MessageBox.Show("O campo TÍTULO não pode ser vazio!", "Alerta",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtTitulo.BackColor = Color.LightCoral;
                txtISRC.BackColor = Color.White;
                txtAutor.BackColor = Color.White;
            }
            else if (txtISRC.Text.Trim() == String.Empty)
            {
                MessageBox.Show("O campo ISRC não pode ser vazio!", "Alerta",
                   MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtISRC.BackColor = Color.LightCoral;
                txtTitulo.BackColor = Color.White;
                txtAutor.BackColor = Color.White;
            }
            else if (txtAutor.Text == String.Empty)
            {
                MessageBox.Show("O campo AUTOR não pode ser vazio!", "Alerta",
                   MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtAutor.BackColor = Color.LightCoral;
                txtTitulo.BackColor = Color.White;
                txtISRC.BackColor = Color.White;
            }
            else
            {
                musica.Titulo = txtTitulo.Text;
                musica.Lancamento = dtLanca.Text;
                musica.ISRC = txtISRC.Text;
                musica.Autor = txtAutor.Text;
                musica.Interprete = txtInter.Text;
                musica.Produtor = txtProd.Text;
                musica.Editora = txtEdit.Text;
                musica.Genero = txtGen.Text;

                musicaBLL.Salvar(musica);
                MessageBox.Show("Cadastro realizado com sucesso!", "Aviso",
                  MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                Limpar();
            }
        }
        //Método para limpar os campos do formulário

        public void Limpar()
        {
            txtCodigo.Clear();
            txtTitulo.Clear();
            txtInter.Clear();
            txtProd.Clear();
            txtEdit.Clear();
            txtISRC.Clear();
            txtAutor.Clear();
            txtGen.Clear();
            dtLanca.ResetText();
            txtTitulo.BackColor = Color.White;
            txtISRC.BackColor = Color.White;
            txtAutor.BackColor = Color.White;
        }
        //Métodos para exibir os dados na tela
        private void Listar()
        {
            MusicaBLL MusicaBLL = new MusicaBLL();
            dataGridView1.DataSource = MusicaBLL.Listar();

            //Renomear os cabeçalhos das colunas
            dataGridView1.Columns[0].HeaderText = "Código";
            dataGridView1.Columns[1].HeaderText = "Título";
            dataGridView1.Columns[2].HeaderText = "Lançamento";
            dataGridView1.Columns[3].HeaderText = "ISRC";
            dataGridView1.Columns[4].HeaderText = "Autor";
            dataGridView1.Columns[5].HeaderText = "Intérprete";
            dataGridView1.Columns[6].HeaderText = "Produtor";
            dataGridView1.Columns[7].HeaderText = "Editora";
            dataGridView1.Columns[8].HeaderText = "Gênero";

            //Ajustar largura das colunas
            dataGridView1.Columns[0].Width = 50;
            dataGridView1.Columns[1].Width = 200;
            dataGridView1.Columns[2].Width = 75;
            dataGridView1.Columns[3].Width = 50;
            dataGridView1.Columns[4].Width = 85;
            dataGridView1.Columns[5].Width = 85;
            dataGridView1.Columns[6].Width = 85;
            dataGridView1.Columns[7].Width = 80;
            dataGridView1.Columns[8].Width = 70;
        }

        //Métodos dos botões do formulário
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Musica musica = new Musica();
            Salvar(musica);
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Limpar();
            Listar();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //Método duplo clique na linha do DataGrid
        private void dataGridView1_DoubleClick_1(object sender, EventArgs e)
        {
            txtCodigo.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtISRC.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            dtLanca.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtTitulo.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtAutor.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtInter.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtProd.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txtEdit.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            txtGen.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
        }

        //Método para cancelar as informações nos campos
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Musica musica = new Musica();
            Alterar(musica);
        }
    }
}