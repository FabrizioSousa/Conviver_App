namespace Conviver_App
{
    partial class FormCadastroCuidador
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtNomeCuidador = new System.Windows.Forms.TextBox();
            this.lblConviverSenior = new System.Windows.Forms.Label();
            this.lblNomeCuidador = new System.Windows.Forms.Label();
            this.btnGravarDados = new System.Windows.Forms.Button();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.txtEnderecoCuidador = new System.Windows.Forms.TextBox();
            this.dgvCuidadores = new System.Windows.Forms.DataGridView();
            this.btnCadastroClientes = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuidadores)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNomeCuidador
            // 
            this.txtNomeCuidador.Location = new System.Drawing.Point(15, 151);
            this.txtNomeCuidador.Multiline = true;
            this.txtNomeCuidador.Name = "txtNomeCuidador";
            this.txtNomeCuidador.Size = new System.Drawing.Size(193, 22);
            this.txtNomeCuidador.TabIndex = 0;
            this.txtNomeCuidador.TextChanged += new System.EventHandler(this.txtNomeCuidador_TextChanged);
            // 
            // lblConviverSenior
            // 
            this.lblConviverSenior.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConviverSenior.Location = new System.Drawing.Point(14, 9);
            this.lblConviverSenior.Name = "lblConviverSenior";
            this.lblConviverSenior.Size = new System.Drawing.Size(1225, 58);
            this.lblConviverSenior.TabIndex = 1;
            this.lblConviverSenior.Text = "Gerência dos cuidadores";
            this.lblConviverSenior.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblNomeCuidador
            // 
            this.lblNomeCuidador.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeCuidador.Location = new System.Drawing.Point(15, 127);
            this.lblNomeCuidador.Name = "lblNomeCuidador";
            this.lblNomeCuidador.Size = new System.Drawing.Size(193, 21);
            this.lblNomeCuidador.TabIndex = 2;
            this.lblNomeCuidador.Text = "Nome do/a cuidador(a):";
            // 
            // btnGravarDados
            // 
            this.btnGravarDados.Enabled = false;
            this.btnGravarDados.Location = new System.Drawing.Point(15, 179);
            this.btnGravarDados.Name = "btnGravarDados";
            this.btnGravarDados.Size = new System.Drawing.Size(403, 23);
            this.btnGravarDados.TabIndex = 2;
            this.btnGravarDados.Text = "Gravar dados";
            this.btnGravarDados.UseVisualStyleBackColor = true;
            this.btnGravarDados.Click += new System.EventHandler(this.btnGravarDadosCuidador_Click);
            // 
            // lblEndereco
            // 
            this.lblEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndereco.Location = new System.Drawing.Point(225, 127);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(193, 21);
            this.lblEndereco.TabIndex = 6;
            this.lblEndereco.Text = "Endereço:";
            // 
            // txtEnderecoCuidador
            // 
            this.txtEnderecoCuidador.Location = new System.Drawing.Point(225, 151);
            this.txtEnderecoCuidador.Multiline = true;
            this.txtEnderecoCuidador.Name = "txtEnderecoCuidador";
            this.txtEnderecoCuidador.Size = new System.Drawing.Size(193, 22);
            this.txtEnderecoCuidador.TabIndex = 1;
            this.txtEnderecoCuidador.TextChanged += new System.EventHandler(this.txtNomeCuidador_TextChanged);
            // 
            // dgvCuidadores
            // 
            this.dgvCuidadores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCuidadores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCuidadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCuidadores.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCuidadores.Location = new System.Drawing.Point(14, 226);
            this.dgvCuidadores.MultiSelect = false;
            this.dgvCuidadores.Name = "dgvCuidadores";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCuidadores.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCuidadores.RowHeadersWidth = 51;
            this.dgvCuidadores.RowTemplate.Height = 24;
            this.dgvCuidadores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCuidadores.Size = new System.Drawing.Size(1225, 327);
            this.dgvCuidadores.TabIndex = 4;
            // 
            // btnCadastroClientes
            // 
            this.btnCadastroClientes.Location = new System.Drawing.Point(424, 150);
            this.btnCadastroClientes.Name = "btnCadastroClientes";
            this.btnCadastroClientes.Size = new System.Drawing.Size(193, 23);
            this.btnCadastroClientes.TabIndex = 7;
            this.btnCadastroClientes.Text = "Gerenciar clientes";
            this.btnCadastroClientes.UseVisualStyleBackColor = true;
            this.btnCadastroClientes.Click += new System.EventHandler(this.btnCadastroClientes_Click);
            // 
            // FormCadastroCuidador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1251, 681);
            this.Controls.Add(this.btnCadastroClientes);
            this.Controls.Add(this.lblEndereco);
            this.Controls.Add(this.txtEnderecoCuidador);
            this.Controls.Add(this.dgvCuidadores);
            this.Controls.Add(this.btnGravarDados);
            this.Controls.Add(this.lblNomeCuidador);
            this.Controls.Add(this.lblConviverSenior);
            this.Controls.Add(this.txtNomeCuidador);
            this.Name = "FormCadastroCuidador";
            this.Text = "Conviver Sênior";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuidadores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNomeCuidador;
        private System.Windows.Forms.Label lblConviverSenior;
        private System.Windows.Forms.Label lblNomeCuidador;
        private System.Windows.Forms.Button btnGravarDados;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.TextBox txtEnderecoCuidador;
        private System.Windows.Forms.DataGridView dgvCuidadores;
        private System.Windows.Forms.Button btnCadastroClientes;
    }
}

