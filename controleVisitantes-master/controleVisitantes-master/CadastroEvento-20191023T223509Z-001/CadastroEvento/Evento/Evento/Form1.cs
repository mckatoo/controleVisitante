using Evento.Tabelas;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Evento
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        private void BtnSalvar_Click(object sender, EventArgs e)
        {
           if (txtNome.Text == "")
            {
                MessageBox.Show("Prencha o nome");
            }
            else if (txtEmail.Text == "")
            {
                MessageBox.Show("Prencha o E-mail");
            }
            else if (txtTelefone.Text == "")
            {
                MessageBox.Show("Prencha o Telefone");
            }
            else { 
                MessageBox.Show(txtNome.Text);

            Conexao con = new Conexao();

            try
            {
                new Alunos().DbInserir(txtRA.Text, txtTelefone.Text, txtNome.Text, txtEmail.Text, txtCarteirinha.Text, 2);

                    MessageBox.Show("Cadastro salvo com sucesso!");
                    
                    txtRA.Clear();
                    txtTelefone.Clear();
                    txtNome.Clear();
                    txtEmail.Clear();
                    txtCarteirinha.Clear();
                    cbTipo.Refresh();

                    //aLUNOTableAdapter.Fill(this.eVENTODataSet.ALUNO);
                }
                catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            }
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(" Deseja mesmo sair? ", "Mensagem do sistema ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void BtnVisitante_CheckedChanged(object sender, EventArgs e)
        {
            if (btnVisitante.Checked == true)
            {

                txtCarteirinha.Enabled = false;
                txtRA.Enabled = false;
            }
            else
            {
                if (btnAluno.Checked == true)
                {
                    txtCarteirinha.Enabled = true;
                    txtRA.Enabled = true;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'eVENTODataSet.TIPO'. Você pode movê-la ou removê-la conforme necessário.
            //this.tIPOTableAdapter.Fill(this.eVENTODataSet.TIPO);
            // TODO: esta linha de código carrega dados na tabela 'eVENTODataSet.ALUNO'. Você pode movê-la ou removê-la conforme necessário.
            //this.aLUNOTableAdapter.Fill(this.eVENTODataSet.ALUNO);
            //txtIdTipo.Hide();
            cbTipo.Text = "[SELECIONE...]";

            List<Alunos> listaDeAlunos = new Alunos().ListarAlunos();
            dgvAlunos.DataSource = listaDeAlunos;

            List<Tipos> listaDeTipos = new Tipos().ListarTipos();
            cbTipo.DataSource = listaDeTipos;
        }

        private void DataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}