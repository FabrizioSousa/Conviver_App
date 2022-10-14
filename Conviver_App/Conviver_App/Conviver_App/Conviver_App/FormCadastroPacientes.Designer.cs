namespace Conviver_App
{
    partial class FormCadastroPacientes
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
            this.dgvPacientes = new System.Windows.Forms.DataGridView();
            this.btnGravarDados = new System.Windows.Forms.Button();
            this.lblCadastroPacientes = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbNomeCliente = new System.Windows.Forms.ComboBox();
            this.txtNomePaciente = new System.Windows.Forms.TextBox();
            this.txtEnderecoPaciente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbStatusPaciente = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGerenciarClientes
            // 
            this.btnGerenciarClientes.Location = new System.Drawing.Point(881, 146);
            this.btnGerenciarClientes.Name = "btnGerenciarClientes";
            this.btnGerenciarClientes.Size = new System.Drawing.Size(153, 29);
            this.btnGerenciarClientes.TabIndex = 45;
            this.btnGerenciarClientes.Text = "Gerenciar clientes";
            this.btnGerenciarClientes.UseVisualStyleBackColor = true;
            this.btnGerenciarClientes.Click += new System.EventHandler(this.btnGerenciarClientes_Click);
            // 
            // dgvPacientes
            // 
            this.dgvPacientes.AllowUserToAddRows = false;
            this.dgvPacientes.AllowUserToDeleteRows = false;
            this.dgvPacientes.AllowUserToOrderColumns = true;
            this.dgvPacientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPacientes.Location = new System.Drawing.Point(12, 221);
            this.dgvPacientes.MultiSelect = false;
            this.dgvPacientes.Name = "dgvPacientes";
            this.dgvPacientes.ReadOnly = true;
            this.dgvPacientes.RowHeadersWidth = 51;
            this.dgvPacientes.RowTemplate.Height = 24;
            this.dgvPacientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPacientes.Size = new System.Drawing.Size(1225, 244);
            this.dgvPacientes.TabIndex = 44;
            // 
            // btnGravarDados
            // 
            this.btnGravarDados.Enabled = false;
            this.btnGravarDados.Location = new System.Drawing.Point(13, 174);
            this.btnGravarDados.Name = "btnGravarDados";
            this.btnGravarDados.Size = new System.Drawing.Size(335, 29);
            this.btnGravarDados.TabIndex = 43;
            this.btnGravarDados.Text = "Gravar dados";
            this.btnGravarDados.UseVisualStyleBackColor = true;
            this.btnGravarDados.Click += new System.EventHandler(this.btnGravarDados_Click);
            // 
            // lblCadastroPacientes
            // 
            this.lblCadastroPacientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastroPacientes.Location = new System.Drawing.Point(12, 9);
            this.lblCadastroPacientes.Name = "lblCadastroPacientes";
            this.lblCadastroPacientes.Size = new System.Drawing.Size(1225, 58);
            this.lblCadastroPacientes.TabIndex = 42;
            this.lblCadastroPacientes.Text = "Gerência dos pacientes";
            this.lblCadastroPacientes.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 21);
            this.label4.TabIndex = 54;
            this.label4.Text = "Nome do paciente:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(180, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 21);
            this.label1.TabIndex = 56;
            this.label1.Text = "Nome do cliente:";
            // 
            // cbNomeCliente
            // 
            this.cbNomeCliente.FormattingEnabled = true;
            this.cbNomeCliente.Location = new System.Drawing.Point(184, 146);
            this.cbNomeCliente.Name = "cbNomeCliente";
            this.cbNomeCliente.Size = new System.Drawing.Size(164, 24);
            this.cbNomeCliente.TabIndex = 55;
            // 
            // txtNomePaciente
            // 
            this.txtNomePaciente.Location = new System.Drawing.Point(12, 146);
            this.txtNomePaciente.Name = "txtNomePaciente";
            this.txtNomePaciente.Size = new System.Drawing.Size(165, 22);
            this.txtNomePaciente.TabIndex = 57;
            // 
            // txtEnderecoPaciente
            // 
            this.txtEnderecoPaciente.Location = new System.Drawing.Point(362, 146);
            this.txtEnderecoPaciente.Name = "txtEnderecoPaciente";
            this.txtEnderecoPaciente.Size = new System.Drawing.Size(165, 22);
            this.txtEnderecoPaciente.TabIndex = 59;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(359, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 21);
            this.label2.TabIndex = 58;
            this.label2.Text = "Endereço do paciente:";
            // 
            // cbStatusPaciente
            // 
            this.cbStatusPaciente.FormattingEnabled = true;
            this.cbStatusPaciente.Items.AddRange(new object[] {
            "Ativo",
            "Inativo"});
            this.cbStatusPaciente.Location = new System.Drawing.Point(546, 144);
            this.cbStatusPaciente.Name = "cbStatusPaciente";
            this.cbStatusPaciente.Size = new System.Drawing.Size(164, 24);
            this.cbStatusPaciente.TabIndex = 60;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(546, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 21);
            this.label3.TabIndex = 61;
            this.label3.Text = "Status do paciente:";
            // 
            // FormCadastroPacientes
            // 
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1251, 477);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbStatusPaciente);
            this.Controls.Add(this.txtEnderecoPaciente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNomePaciente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbNomeCliente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnGerenciarClientes);
            this.Controls.Add(this.dgvPacientes);
            this.Controls.Add(this.btnGravarDados);
            this.Controls.Add(this.lblCadastroPacientes);
            this.Name = "FormCadastroPacientes";
            this.Text = "Conviver Sênior";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGerenciarClientes;
        private System.Windows.Forms.DataGridView dgvPacientes;
        private System.Windows.Forms.Button btnGravarDados;
        private System.Windows.Forms.Label lblCadastroPacientes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbNomeCliente;
        private System.Windows.Forms.TextBox txtNomePaciente;
        private System.Windows.Forms.TextBox txtEnderecoPaciente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbStatusPaciente;
        private System.Windows.Forms.Label label3;
    }
}