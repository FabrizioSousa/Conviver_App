using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Conviver_App
{
    public partial class FormCadastroPagamento : Form
    {
        public FormCadastroPagamento()
        {
            InitializeComponent();
            Pegar_Clientes();
            cbStsPag.SelectedIndex = 0;
            cbFormaPagamento.SelectedIndex = 0;
            dtpDataPagamento.CustomFormat = "dd/MM/yyyy";
        }

        private void Pegar_Clientes()
        {
            Conexao.Conexao conexao = new Conexao.Conexao();
            cbPacientes.DataSource = conexao.Mostra_Clientes();
            cbPacientes.DisplayMember = "Nome do paciente";
            cbPacientes.ValueMember = "Código do paciente";
        }

        private void btnBuscarDados_Click(object sender, EventArgs e)
        {            
            int id_paciente = Convert.ToInt32(cbPacientes.SelectedValue);
            Conexao.Conexao conexao = new Conexao.Conexao();
            dgvPagamentos.DataSource = conexao.Mostra_Pagamentos_Por_Id(id_paciente);

        }

        private void btnMudarStsPag_Click(object sender, EventArgs e)
        {
            string novo_status_pagamento = cbStsPag.Text;
            string novo_forma_pagamento = cbFormaPagamento.Text;
            DateTime novo_data_pagamento = Convert.ToDateTime(dtpDataPagamento.Text);
            int id_selecionado = 0;
            string status_antigo = "";
            string forma_antigo = "";
            DateTime data_pagamento_antigo = Convert.ToDateTime("01/01/1900");
            if (dgvPagamentos.SelectedCells.Count > 0)
            {
                int selectedrowindex = dgvPagamentos.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgvPagamentos.Rows[selectedrowindex];
                id_selecionado = Convert.ToInt32(selectedRow.Cells[0].Value);
                if(selectedRow.Cells["Status do pagamento"].Value != null)
                    status_antigo = selectedRow.Cells["Status do pagamento"].Value.ToString();
                if (selectedRow.Cells["Forma do pagamento"].Value != null)
                    forma_antigo = selectedRow.Cells["Forma do pagamento"].Value.ToString();
                if (selectedRow.Cells["Data do pagamento"].Value != null)
                    data_pagamento_antigo = Convert.ToDateTime(selectedRow.Cells["Data do pagamento"].Value.ToString());
                if (status_antigo != novo_status_pagamento 
                    || forma_antigo != novo_forma_pagamento
                    || data_pagamento_antigo != novo_data_pagamento)
                {
                    Conexao.Conexao conexao = new Conexao.Conexao();
                    conexao.Atualiza_Status_Pagamento(id_selecionado, novo_status_pagamento, novo_forma_pagamento);
                    selectedRow.Cells["Status do pagamento"].Value = novo_status_pagamento;
                    selectedRow.Cells["Forma do pagamento"].Value = novo_forma_pagamento;
                    selectedRow.Cells["Data do pagamento"].Value = novo_data_pagamento;
                }
            }
            

        }

        private void dgvPagamentos_DataSourceChanged(object sender, EventArgs e)
        {
            if (dgvPagamentos.SelectedCells.Count > 0)
            {
                btnMudarStsPag.Enabled = true;
            }
            else
                btnMudarStsPag.Enabled = false;
        }        

        private void dgvPagamentos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPagamentos.SelectedCells.Count > 0)
            {
                int selectedrowindex = dgvPagamentos.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgvPagamentos.Rows[selectedrowindex];
                string forma_pagamento = selectedRow.Cells["Forma do pagamento"].Value.ToString();
                string status_pagamento = selectedRow.Cells["Status do pagamento"].Value.ToString();
                cbStsPag.SelectedItem = status_pagamento;
                cbFormaPagamento.SelectedItem = forma_pagamento;

            }
        }

      
    }
}
