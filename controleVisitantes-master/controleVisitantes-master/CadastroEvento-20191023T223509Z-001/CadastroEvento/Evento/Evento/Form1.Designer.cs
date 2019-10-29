namespace Evento
{
    partial class Form1
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
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtRA = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblRa = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCarteirinha = new System.Windows.Forms.TextBox();
            this.lblCarteirinha = new System.Windows.Forms.Label();
            this.btnAluno = new System.Windows.Forms.RadioButton();
            this.btnVisitante = new System.Windows.Forms.RadioButton();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvAlunos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlunos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNome.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(58, 151);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(269, 21);
            this.txtNome.TabIndex = 3;
            // 
            // txtRA
            // 
            this.txtRA.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRA.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRA.Location = new System.Drawing.Point(58, 120);
            this.txtRA.Name = "txtRA";
            this.txtRA.Size = new System.Drawing.Size(269, 21);
            this.txtRA.TabIndex = 2;
            // 
            // txtEmail
            // 
            this.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEmail.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(508, 120);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(269, 21);
            this.txtEmail.TabIndex = 6;
            // 
            // txtTelefone
            // 
            this.txtTelefone.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTelefone.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefone.Location = new System.Drawing.Point(508, 151);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(269, 21);
            this.txtTelefone.TabIndex = 7;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(7, 153);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(45, 16);
            this.lblNome.TabIndex = 4;
            this.lblNome.Text = "Nome";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefone.Location = new System.Drawing.Point(430, 151);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(72, 16);
            this.lblTelefone.TabIndex = 5;
            this.lblTelefone.Text = "WhatsApp";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(454, 122);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(48, 16);
            this.lblEmail.TabIndex = 6;
            this.lblEmail.Text = "E-mail";
            // 
            // lblRa
            // 
            this.lblRa.AutoSize = true;
            this.lblRa.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRa.Location = new System.Drawing.Point(18, 122);
            this.lblRa.Name = "lblRa";
            this.lblRa.Size = new System.Drawing.Size(34, 16);
            this.lblRa.TabIndex = 7;
            this.lblRa.Text = "R.A.";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(168, 215);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 9;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseMnemonic = false;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(581, 215);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 10;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(242, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(414, 37);
            this.label1.TabIndex = 11;
            this.label1.Text = "Cadastro de Participantes";
            // 
            // txtCarteirinha
            // 
            this.txtCarteirinha.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCarteirinha.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCarteirinha.Location = new System.Drawing.Point(508, 92);
            this.txtCarteirinha.Name = "txtCarteirinha";
            this.txtCarteirinha.Size = new System.Drawing.Size(269, 21);
            this.txtCarteirinha.TabIndex = 5;
            // 
            // lblCarteirinha
            // 
            this.lblCarteirinha.AutoSize = true;
            this.lblCarteirinha.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarteirinha.Location = new System.Drawing.Point(357, 94);
            this.lblCarteirinha.Name = "lblCarteirinha";
            this.lblCarteirinha.Size = new System.Drawing.Size(145, 16);
            this.lblCarteirinha.TabIndex = 13;
            this.lblCarteirinha.Text = "Carteirinha Estudante";
            // 
            // btnAluno
            // 
            this.btnAluno.AutoSize = true;
            this.btnAluno.Location = new System.Drawing.Point(110, 94);
            this.btnAluno.Name = "btnAluno";
            this.btnAluno.Size = new System.Drawing.Size(52, 17);
            this.btnAluno.TabIndex = 0;
            this.btnAluno.TabStop = true;
            this.btnAluno.Text = "Aluno";
            this.btnAluno.UseVisualStyleBackColor = true;
            // 
            // btnVisitante
            // 
            this.btnVisitante.AutoSize = true;
            this.btnVisitante.Location = new System.Drawing.Point(168, 94);
            this.btnVisitante.Name = "btnVisitante";
            this.btnVisitante.Size = new System.Drawing.Size(65, 17);
            this.btnVisitante.TabIndex = 1;
            this.btnVisitante.TabStop = true;
            this.btnVisitante.Text = "Visitante";
            this.btnVisitante.UseVisualStyleBackColor = true;
            this.btnVisitante.CheckedChanged += new System.EventHandler(this.BtnVisitante_CheckedChanged);
            // 
            // cbTipo
            // 
            this.cbTipo.DisplayMember = "TIPO";
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Location = new System.Drawing.Point(508, 178);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(269, 21);
            this.cbTipo.TabIndex = 8;
            this.cbTipo.ValueMember = "TIPO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(395, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 16);
            this.label2.TabIndex = 20;
            this.label2.Text = "Tipo de usuário";
            // 
            // dgvAlunos
            // 
            this.dgvAlunos.AllowUserToAddRows = false;
            this.dgvAlunos.AllowUserToDeleteRows = false;
            this.dgvAlunos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvAlunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlunos.Location = new System.Drawing.Point(10, 255);
            this.dgvAlunos.Name = "dgvAlunos";
            this.dgvAlunos.ReadOnly = true;
            this.dgvAlunos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAlunos.Size = new System.Drawing.Size(767, 179);
            this.dgvAlunos.TabIndex = 11;
            this.dgvAlunos.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_RowEnter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Evento.Properties.Resources.logo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(792, 446);
            this.Controls.Add(this.dgvAlunos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbTipo);
            this.Controls.Add(this.btnVisitante);
            this.Controls.Add(this.btnAluno);
            this.Controls.Add(this.lblCarteirinha);
            this.Controls.Add(this.txtCarteirinha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.lblRa);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtRA);
            this.Controls.Add(this.txtNome);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Cadastro de Alunos";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlunos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtRA;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblRa;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCarteirinha;
        private System.Windows.Forms.Label lblCarteirinha;
        private System.Windows.Forms.RadioButton btnAluno;
        private System.Windows.Forms.RadioButton btnVisitante;
        private System.Windows.Forms.ComboBox cbTipo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvAlunos;
    }
}

