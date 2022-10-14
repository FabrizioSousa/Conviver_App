namespace Conviver_App
{
    partial class FormCadastroPagamento
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGerenciarClientes = new System.Windows.Forms.Button();
            this.btnCadastroCuidador = new System.Windows.Forms.Button();
            this.dgvPagamentos = new System.Windows.Forms.DataGridView();
            this.btnBuscarDados = new System.Windows.Forms.Button();
            this.lblNomePaciente = new System.Windows.Forms.Label();
            this.lblCadastroCliente = new System.Windows.Forms.Label();
            this.cbPacientes = new System.Windows.Forms.ComboBox();
            this.btnMudarStsPag = new System.Windows.Forms.Button();
            this.cbStsPag = new System.Windows.Forms.ComboBox();
            this.cbFormaPagamento = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpDataPagamento = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagamentos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGerenciarClientes
            // 
            this.btnGerenciarClientes.Location = new System.Drawing.Point(183, 176);
            this.btnGerenciarClientes.Name = "btnGerenciarClientes";
            this.btnGerenciarClientes.Size = new System.Drawing.Size(153, 29);
            this.btnGerenciarClientes.TabIndex = 32;
            this.btnGerenciarClientes.Text = "Gerenciar clientes";
            this.btnGerenciarClientes.UseVisualStyleBackColor = true;
            this.btnGerenciarClientes.Click += new System.EventHandler(this.btnGerenciarClientes_Click);
            // 
            // btnCadastroCuidador
            // 
            this.btnCadastroCuidador.Location = new System.Drawing.Point(183, 140);
            this.btnCadastroCuidador.Name = "btnCadastroCuidador";
            this.btnCadastroCuidador.Size = new System.Drawing.Size(153, 30);
            this.btnCadastroCuidador.TabIndex = 27;
            this.btnCadastroCuidador.Text = "Gerenciar cuidadores";
            this.btnCadastroCuidador.UseVisualStyleBackColor = true;
            this.btnCadastroCuidador.Click += new System.EventHandler(this.btnCadastroCuidador_Click);
            // 
            // dgvPagamentos
            // 
            this.dgvPagamentos.AllowUserToAddRows = false;
            this.dgvPagamentos.AllowUserToDeleteRows = false;
            this.dgvPagamentos.AllowUserToOrderColumns = true;
            this.dgvPagamentos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPagamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPagamentos.Location = new System.Drawing.Point(12, 221);
            this.dgvPagamentos.MultiSelect = false;
            this.dgvPagamentos.Name = "dgvPagamentos";
            this.dgvPagamentos.RowHeadersWidth = 51;
            this.dgvPagamentos.RowTemplate.Height = 24;
            this.dgvPagamentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPagamentos.Size = new System.Drawing.Size(1225, 244);
            this.dgvPagamentos.TabIndex = 25;
            this.dgvPagamentos.DataSourceChanged += new System.EventHandler(this.dgvPagamentos_DataSourceChanged);
            this.dgvPagamentos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPagamentos_CellClick);
            this.dgvPagamentos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPagamentos_CellContentClick);
            // 
            // btnBuscarDados
            // 
            this.btnBuscarDados.Location = new System.Drawing.Point(13, 174);
            this.btnBuscarDados.Name = "btnBuscarDados";
            this.btnBuscarDados.Size = new System.Drawing.Size(164, 29);
            this.btnBuscarDados.TabIndex = 23;
            this.btnBuscarDados.Text = "Buscar dados";
            this.btnBuscarDados.UseVisualStyleBackColor = true;
            this.btnBuscarDados.Click += new System.EventHandler(this.btnBuscarDados_Click);
            // 
            // lblNomePaciente
            // 
            this.lblNomePaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomePaciente.Location = new System.Drawing.Point(13, 122);
            this.lblNomePaciente.Name = "lblNomePaciente";
            this.lblNomePaciente.Size = new System.Drawing.Size(164, 21);
            this.lblNomePaciente.TabIndex = 24;
            this.lblNomePaciente.Text = "Nome do/a PACIENTE:";
            // 
            // lblCadastroCliente
            // 
            this.lblCadastroCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastroCliente.Location = new System.Drawing.Point(12, 9);
            this.lblCadastroCliente.Name = "lblCadastroCliente";
            this.lblCadastroCliente.Size = new System.Drawing.Size(1225, 58);
            this.lblCadastroCliente.TabIndex = 22;
            this.lblCadastroCliente.Text = "Gerência dos pagamentos";
            this.lblCadastroCliente.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cbPacientes
            // 
            this.cbPacientes.FormattingEnabled = true;
            this.cbPacientes.Location = new System.Drawing.Point(13, 146);
            this.cbPacientes.Name = "cbPacientes";
            this.cbPacientes.Size = new System.Drawing.Size(164, 24);
            this.cbPacientes.TabIndex = 33;
            // 
            // btnMudarStsPag
            // 
            this.btnMudarStsPag.Enabled = false;
            this.btnMudarStsPag.Location = new System.Drawing.Point(1033, 178);
            this.btnMudarStsPag.Name = "btnMudarStsPag";
            this.btnMudarStsPag.Size = new System.Drawing.Size(204, 29);
            this.btnMudarStsPag.TabIndex = 34;
            this.btnMudarStsPag.Text = "Mudar pagamento";
            this.btnMudarStsPag.UseVisualStyleBackColor = true;
            this.btnMudarStsPag.Click += new System.EventHandler(this.btnMudarStsPag_Click);
            // 
            // cbStsPag
            // 
            this.cbStsPag.FormattingEnabled = true;
            this.cbStsPag.Items.AddRange(new object[] {
            "Pago",
            "Em aberto",
            "Cancelado"});
            this.cbStsPag.Location = new System.Drawing.Point(863, 181);
            this.cbStsPag.Name = "cbStsPag";
            this.cbStsPag.Size = new System.Drawing.Size(164, 24);
            this.cbStsPag.TabIndex = 35;
            // 
            // cbFormaPagamento
            // 
            this.cbFormaPagamento.FormattingEnabled = true;
            this.cbFormaPagamento.Items.AddRange(new object[] {
            "Transferência",
            "Pix",
            "Boleto",
            "Dinheiro",
            "Cheque"});
            this.cbFormaPagamento.Location = new System.Drawing.Point(693, 181);
            this.cbFormaPagamento.Name = "cbFormaPagamento";
            this.cbFormaPagamento.Size = new System.Drawing.Size(164, 24);
            this.cbFormaPagamento.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(690, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 21);
            this.label1.TabIndex = 38;
            this.label1.Text = "Forma de pagamento:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(863, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 21);
            this.label2.TabIndex = 39;
            this.label2.Text = "Status do pagamento";
            // 
            // dtpDataPagamento
            // 
            this.dtpDataPagamento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDataPagamento.Location = new System.Drawing.Point(487, 181);
            this.dtpDataPagamento.MaxDate = new System.DateTime(2090, 12, 31, 0, 0, 0, 0);
            this.dtpDataPagamento.MinDate = new System.DateTime(2022, 1, 10, 0, 0, 0, 0);
            this.dtpDataPagamento.Name = "dtpDataPagamento";
            this.dtpDataPagamento.Size = new System.Drawing.Size(200, 22);
            this.dtpDataPagamento.TabIndex = 40;
            this.dtpDataPagamento.Value = new System.DateTime(2022, 10, 12, 19, 17, 12, 0);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(484, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 21);
            this.label3.TabIndex = 41;
            this.label3.Text = "Data do pagamento:";
            // 
            // FormCadastroPagamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1251, 477);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpDataPagamento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbFormaPagamento);
            this.Controls.Add(this.cbStsPag);
            this.Controls.Add(this.btnMudarStsPag);
            this.Controls.Add(this.cbPacientes);
            this.Controls.Add(this.btnGerenciarClientes);
            this.Controls.Add(this.btnCadastroCuidador);
            this.Controls.Add(this.dgvPagamentos);
            this.Controls.Add(this.btnBuscarDados);
            this.Controls.Add(this.lblNomePaciente);
            this.Controls.Add(this.lblCadastroCliente);
            this.Name = "FormCadastroPagamento";
            this.Text = "FormCadastroPagamento";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPagamentos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGerenciarClientes;
        private System.Windows.Forms.Button btnCadastroCuidador;
        private System.Windows.Forms.DataGridView dgvPagamentos;
        private System.Windows.Forms.Button btnBuscarDados;
        private System.Windows.Forms.Label lblNomePaciente;
        private System.Windows.Forms.Label lblCadastroCliente;
        private System.Windows.Forms.ComboBox cbPacientes;
        private System.Windows.Forms.Button btnMudarStsPag;
        private System.Windows.Forms.ComboBox cbStsPag;
        private System.Windows.Forms.ComboBox cbFormaPagamento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpDataPagamento;
        private System.Windows.Forms.Label label3;
    }
}