namespace Conviver_App
{
    partial class FormCadastroCliente
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
            this.lblEnderecoPaciente = new System.Windows.Forms.Label();
            this.txtEnderecoPaciente = new System.Windows.Forms.TextBox();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.btnGravarDados = new System.Windows.Forms.Button();
            this.lblNomePaciente = new System.Windows.Forms.Label();
            this.lblCadastroCliente = new System.Windows.Forms.Label();
            this.txtNomePaciente = new System.Windows.Forms.TextBox();
            this.btnCadastroCuidador = new System.Windows.Forms.Button();
            this.lblNomeCliente = new System.Windows.Forms.Label();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.lblEnderecoCliente = new System.Windows.Forms.Label();
            this.txtEnderecoCliente = new System.Windows.Forms.TextBox();
            this.btnGerenciarPagamentos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEnderecoPaciente
            // 
            this.lblEnderecoPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnderecoPaciente.Location = new System.Drawing.Point(418, 122);
            this.lblEnderecoPaciente.Name = "lblEnderecoPaciente";
            this.lblEnderecoPaciente.Size = new System.Drawing.Size(193, 21);
            this.lblEnderecoPaciente.TabIndex = 13;
            this.lblEnderecoPaciente.Text = "Endereço do PACIENTE:";
            // 
            // txtEnderecoPaciente
            // 
            this.txtEnderecoPaciente.Location = new System.Drawing.Point(421, 146);
            this.txtEnderecoPaciente.Multiline = true;
            this.txtEnderecoPaciente.Name = "txtEnderecoPaciente";
            this.txtEnderecoPaciente.Size = new System.Drawing.Size(193, 22);
            this.txtEnderecoPaciente.TabIndex = 8;
            this.txtEnderecoPaciente.TextChanged += new System.EventHandler(this.txtNomePaciente_TextChanged);
            // 
            // dgvClientes
            // 
            this.dgvClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(12, 221);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.RowHeadersWidth = 51;
            this.dgvClientes.RowTemplate.Height = 24;
            this.dgvClientes.Size = new System.Drawing.Size(1225, 327);
            this.dgvClientes.TabIndex = 12;
            // 
            // btnGravarDados
            // 
            this.btnGravarDados.Enabled = false;
            this.btnGravarDados.Location = new System.Drawing.Point(13, 174);
            this.btnGravarDados.Name = "btnGravarDados";
            this.btnGravarDados.Size = new System.Drawing.Size(800, 29);
            this.btnGravarDados.TabIndex = 10;
            this.btnGravarDados.Text = "Gravar dados";
            this.btnGravarDados.UseVisualStyleBackColor = true;
            this.btnGravarDados.Click += new System.EventHandler(this.btnGravarDadosCliente_Click);
            // 
            // lblNomePaciente
            // 
            this.lblNomePaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomePaciente.Location = new System.Drawing.Point(13, 122);
            this.lblNomePaciente.Name = "lblNomePaciente";
            this.lblNomePaciente.Size = new System.Drawing.Size(193, 21);
            this.lblNomePaciente.TabIndex = 11;
            this.lblNomePaciente.Text = "Nome do/a PACIENTE:";
            // 
            // lblCadastroCliente
            // 
            this.lblCadastroCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastroCliente.Location = new System.Drawing.Point(12, 9);
            this.lblCadastroCliente.Name = "lblCadastroCliente";
            this.lblCadastroCliente.Size = new System.Drawing.Size(1225, 58);
            this.lblCadastroCliente.TabIndex = 9;
            this.lblCadastroCliente.Text = "Gerência dos clientes";
            this.lblCadastroCliente.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtNomePaciente
            // 
            this.txtNomePaciente.Location = new System.Drawing.Point(13, 146);
            this.txtNomePaciente.Multiline = true;
            this.txtNomePaciente.Name = "txtNomePaciente";
            this.txtNomePaciente.Size = new System.Drawing.Size(193, 22);
            this.txtNomePaciente.TabIndex = 7;
            this.txtNomePaciente.TextChanged += new System.EventHandler(this.txtNomePaciente_TextChanged);
            // 
            // btnCadastroCuidador
            // 
            this.btnCadastroCuidador.Location = new System.Drawing.Point(819, 138);
            this.btnCadastroCuidador.Name = "btnCadastroCuidador";
            this.btnCadastroCuidador.Size = new System.Drawing.Size(209, 30);
            this.btnCadastroCuidador.TabIndex = 14;
            this.btnCadastroCuidador.Text = "Gerenciar cuidadores";
            this.btnCadastroCuidador.UseVisualStyleBackColor = true;
            this.btnCadastroCuidador.Click += new System.EventHandler(this.btnCadastroCuidador_Click);
            // 
            // lblNomeCliente
            // 
            this.lblNomeCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeCliente.Location = new System.Drawing.Point(216, 122);
            this.lblNomeCliente.Name = "lblNomeCliente";
            this.lblNomeCliente.Size = new System.Drawing.Size(193, 21);
            this.lblNomeCliente.TabIndex = 16;
            this.lblNomeCliente.Text = "Nome do/a CLIENTE:";
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Location = new System.Drawing.Point(216, 146);
            this.txtNomeCliente.Multiline = true;
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(193, 22);
            this.txtNomeCliente.TabIndex = 15;
            this.txtNomeCliente.TextChanged += new System.EventHandler(this.txtNomePaciente_TextChanged);
            // 
            // lblEnderecoCliente
            // 
            this.lblEnderecoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnderecoCliente.Location = new System.Drawing.Point(617, 122);
            this.lblEnderecoCliente.Name = "lblEnderecoCliente";
            this.lblEnderecoCliente.Size = new System.Drawing.Size(193, 21);
            this.lblEnderecoCliente.TabIndex = 18;
            this.lblEnderecoCliente.Text = "Endereço do CLIENTE:";
            // 
            // txtEnderecoCliente
            // 
            this.txtEnderecoCliente.Location = new System.Drawing.Point(620, 146);
            this.txtEnderecoCliente.Multiline = true;
            this.txtEnderecoCliente.Name = "txtEnderecoCliente";
            this.txtEnderecoCliente.Size = new System.Drawing.Size(193, 22);
            this.txtEnderecoCliente.TabIndex = 17;
            this.txtEnderecoCliente.TextChanged += new System.EventHandler(this.txtNomePaciente_TextChanged);
            // 
            // btnGerenciarPagamentos
            // 
            this.btnGerenciarPagamentos.Location = new System.Drawing.Point(819, 174);
            this.btnGerenciarPagamentos.Name = "btnGerenciarPagamentos";
            this.btnGerenciarPagamentos.Size = new System.Drawing.Size(209, 29);
            this.btnGerenciarPagamentos.TabIndex = 19;
            this.btnGerenciarPagamentos.Text = "Gerenciar pagamentos";
            this.btnGerenciarPagamentos.UseVisualStyleBackColor = true;
            this.btnGerenciarPagamentos.Click += new System.EventHandler(this.btnGerenciarPagamentos_Click);
            // 
            // FormCadastroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1251, 681);
            this.Controls.Add(this.btnGerenciarPagamentos);
            this.Controls.Add(this.lblEnderecoCliente);
            this.Controls.Add(this.txtEnderecoCliente);
            this.Controls.Add(this.lblNomeCliente);
            this.Controls.Add(this.txtNomeCliente);
            this.Controls.Add(this.btnCadastroCuidador);
            this.Controls.Add(this.lblEnderecoPaciente);
            this.Controls.Add(this.txtEnderecoPaciente);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.btnGravarDados);
            this.Controls.Add(this.lblNomePaciente);
            this.Controls.Add(this.lblCadastroCliente);
            this.Controls.Add(this.txtNomePaciente);
            this.Name = "FormCadastroCliente";
            this.Text = "Conviver Sênior";
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEnderecoPaciente;
        private System.Windows.Forms.TextBox txtEnderecoPaciente;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Button btnGravarDados;
        private System.Windows.Forms.Label lblNomePaciente;
        private System.Windows.Forms.Label lblCadastroCliente;
        private System.Windows.Forms.TextBox txtNomePaciente;
        private System.Windows.Forms.Button btnCadastroCuidador;
        private System.Windows.Forms.Label lblNomeCliente;
        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.Label lblEnderecoCliente;
        private System.Windows.Forms.TextBox txtEnderecoCliente;
        private System.Windows.Forms.Button btnGerenciarPagamentos;
    }
}