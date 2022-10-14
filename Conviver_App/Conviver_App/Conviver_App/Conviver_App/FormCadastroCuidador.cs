using Conviver_App.Conexao;
using Conviver_App.VO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conviver_App
{
    public partial class FormCadastroCuidador : Form
    {
        public FormCadastroCuidador()
        {
            InitializeComponent();
            MostraDgv();
        }
        private void MostraDgv()
        {
            Conexao.Conexao conexao = new Conexao.Conexao();
            dgvCuidadores.DataSource = conexao.Mostra_Cuidadores(); ;
        }

        private bool Textboxs_Com_Texto()
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    TextBox textBox = c as TextBox;
                    if (textBox.Text == string.Empty)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        private void btnGravarDadosCuidador_Click(object sender, EventArgs e)
        {
            string nome = txtNomeCuidador.Text;
            string endereco = txtEnderecoCuidador.Text;
            Conexao.Conexao conexao = new Conexao.Conexao();
            conexao.Insere_Cuidador(nome,endereco);
            MessageBox.Show(string.Format("Cuidador salvo!\nNome: {0}", nome));
            MostraDgv();
        }

        private void btnCadastroClientes_Click(object sender, EventArgs e)
        {
            FormCadastroCuidador formCadastroCliente = new FormCadastroCuidador();
            formCadastroCliente.ShowDialog();

        }

        private void txtNomeCuidador_TextChanged(object sender, EventArgs e)
        {
            if (Textboxs_Com_Texto())
                btnGravarDados.Enabled = true;
            else
                btnGravarDados.Enabled = false;
        }
    }
}
