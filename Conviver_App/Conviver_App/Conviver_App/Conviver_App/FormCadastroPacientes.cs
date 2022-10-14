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
    public partial class FormCadastroPacientes : Form
    {
        public FormCadastroPacientes()
        {
            InitializeComponent();
            MostraDgv();
            Pegar_Clientes();
        }
        private void MostraDgv()
        {
            Conexao.Conexao conexao = new Conexao.Conexao();
            dgvPacientes.DataSource = conexao.Mostra_Pacientes(); ;
        }

        private void Pegar_Clientes()
        {
            Conexao.Conexao conexao = new Conexao.Conexao();
            cbNomeCliente.DataSource = conexao.Mostra_Pacientes();
            cbNomeCliente.DisplayMember = "Nome do paciente";
            cbNomeCliente.ValueMember = "Código do paciente";
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

        private void txtHoras_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtDiasSemana_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void btnCadastroCuidador_Click(object sender, EventArgs e)
        {
            FormCadastroCuidador formCadastroCuidador = new FormCadastroCuidador();
            formCadastroCuidador.ShowDialog();
        }

        private void txtNomePaciente_TextChanged(object sender, EventArgs e)
        {
            if (Textboxs_Com_Texto())
                btnGravarDados.Enabled = true;
            else
                btnGravarDados.Enabled = false;
        }


        private void btnGravarDados_Click(object sender, EventArgs e)
        {
            try
            {
                string nome_paciente = txtNomePaciente.Text;
                string nome_cliente = cbNomeCliente.Text;
                string endereco_paciente = txtEnderecoPaciente.Text;
                string flg_ativo  = cbStatusPaciente.Text;
                Conexao.Conexao conexao = new Conexao.Conexao();
                bool inseriu_paciente = conexao.Insere_Paciente(nome_paciente, nome_cliente, endereco_paciente, flg_ativo);
                if (inseriu_paciente)
                {
                    MessageBox.Show(string.Format("Novo paciente salvo!\n" +
                                                  "Nome do paciente: {0}\n" +
                                                  "Nome do cliente: {1}", nome_paciente, nome_cliente));
                    MostraDgv();
                }
                else
                    MessageBox.Show("Não foi possível inserir o novo paciente!");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void btnGerenciarClientes_Click(object sender, EventArgs e)
        {
            using (FormCadastroPacientes formCadastroCuidador = new FormCadastroPacientes())
            {
                formCadastroCuidador.ShowDialog();
            }
        }
    }
}
