namespace SoccerManager
{
    partial class FormUsuario
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
            this.Masked_Telefone = new System.Windows.Forms.MaskedTextBox();
            this.Txt_NomeUsuario = new System.Windows.Forms.TextBox();
            this.Label_NomeUsuario = new System.Windows.Forms.Label();
            this.Btn_ListarUsuario = new System.Windows.Forms.Button();
            this.Btn_SalvarUsuario = new System.Windows.Forms.Button();
            this.Txt_TelefoneUsuario = new System.Windows.Forms.Label();
            this.Txt_EmailUsuario = new System.Windows.Forms.TextBox();
            this.Label_EmailUsuario = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Masked_Telefone
            // 
            this.Masked_Telefone.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Masked_Telefone.Location = new System.Drawing.Point(170, 78);
            this.Masked_Telefone.Mask = "(##) # ####-####";
            this.Masked_Telefone.Name = "Masked_Telefone";
            this.Masked_Telefone.Size = new System.Drawing.Size(199, 21);
            this.Masked_Telefone.TabIndex = 3;
            this.Masked_Telefone.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.Masked_Telefone_MaskInputRejected);
            // 
            // Txt_NomeUsuario
            // 
            this.Txt_NomeUsuario.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_NomeUsuario.Location = new System.Drawing.Point(170, 12);
            this.Txt_NomeUsuario.Name = "Txt_NomeUsuario";
            this.Txt_NomeUsuario.Size = new System.Drawing.Size(199, 21);
            this.Txt_NomeUsuario.TabIndex = 1;
            this.Txt_NomeUsuario.TextChanged += new System.EventHandler(this.Txt_NomeUsuario_TextChanged);
            // 
            // Label_NomeUsuario
            // 
            this.Label_NomeUsuario.AutoSize = true;
            this.Label_NomeUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_NomeUsuario.Location = new System.Drawing.Point(65, 14);
            this.Label_NomeUsuario.Name = "Label_NomeUsuario";
            this.Label_NomeUsuario.Size = new System.Drawing.Size(104, 15);
            this.Label_NomeUsuario.TabIndex = 6;
            this.Label_NomeUsuario.Text = "Nome do Usuário";
            this.Label_NomeUsuario.Click += new System.EventHandler(this.Label_NomeUsuario_Click);
            // 
            // Btn_ListarUsuario
            // 
            this.Btn_ListarUsuario.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Btn_ListarUsuario.Cursor = System.Windows.Forms.Cursors.No;
            this.Btn_ListarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ListarUsuario.Location = new System.Drawing.Point(48, 119);
            this.Btn_ListarUsuario.Name = "Btn_ListarUsuario";
            this.Btn_ListarUsuario.Size = new System.Drawing.Size(121, 38);
            this.Btn_ListarUsuario.TabIndex = 5;
            this.Btn_ListarUsuario.Text = "Listar";
            this.Btn_ListarUsuario.UseVisualStyleBackColor = false;
            this.Btn_ListarUsuario.Click += new System.EventHandler(this.Btn_ListarUsuario_Click);
            // 
            // Btn_SalvarUsuario
            // 
            this.Btn_SalvarUsuario.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Btn_SalvarUsuario.Cursor = System.Windows.Forms.Cursors.No;
            this.Btn_SalvarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_SalvarUsuario.Location = new System.Drawing.Point(248, 118);
            this.Btn_SalvarUsuario.Name = "Btn_SalvarUsuario";
            this.Btn_SalvarUsuario.Size = new System.Drawing.Size(121, 39);
            this.Btn_SalvarUsuario.TabIndex = 4;
            this.Btn_SalvarUsuario.Text = "Salvar";
            this.Btn_SalvarUsuario.UseVisualStyleBackColor = false;
            this.Btn_SalvarUsuario.Click += new System.EventHandler(this.Btn_SalvarUsuario_Click);
            // 
            // Txt_TelefoneUsuario
            // 
            this.Txt_TelefoneUsuario.AutoSize = true;
            this.Txt_TelefoneUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_TelefoneUsuario.Location = new System.Drawing.Point(109, 80);
            this.Txt_TelefoneUsuario.Name = "Txt_TelefoneUsuario";
            this.Txt_TelefoneUsuario.Size = new System.Drawing.Size(55, 15);
            this.Txt_TelefoneUsuario.TabIndex = 8;
            this.Txt_TelefoneUsuario.Text = "Telefone";
            this.Txt_TelefoneUsuario.Click += new System.EventHandler(this.Txt_TelefoneUsuario_Click);
            // 
            // Txt_EmailUsuario
            // 
            this.Txt_EmailUsuario.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_EmailUsuario.Location = new System.Drawing.Point(170, 46);
            this.Txt_EmailUsuario.Name = "Txt_EmailUsuario";
            this.Txt_EmailUsuario.Size = new System.Drawing.Size(199, 21);
            this.Txt_EmailUsuario.TabIndex = 2;
            this.Txt_EmailUsuario.TextChanged += new System.EventHandler(this.Txt_EmailUsuario_TextChanged);
            // 
            // Label_EmailUsuario
            // 
            this.Label_EmailUsuario.AutoSize = true;
            this.Label_EmailUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_EmailUsuario.Location = new System.Drawing.Point(121, 46);
            this.Label_EmailUsuario.Name = "Label_EmailUsuario";
            this.Label_EmailUsuario.Size = new System.Drawing.Size(43, 15);
            this.Label_EmailUsuario.TabIndex = 7;
            this.Label_EmailUsuario.Text = "E-mail";
            this.Label_EmailUsuario.Click += new System.EventHandler(this.Label_EmailUsuario_Click);
            // 
            // FormUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 174);
            this.Controls.Add(this.Masked_Telefone);
            this.Controls.Add(this.Txt_NomeUsuario);
            this.Controls.Add(this.Label_NomeUsuario);
            this.Controls.Add(this.Btn_ListarUsuario);
            this.Controls.Add(this.Btn_SalvarUsuario);
            this.Controls.Add(this.Txt_TelefoneUsuario);
            this.Controls.Add(this.Txt_EmailUsuario);
            this.Controls.Add(this.Label_EmailUsuario);
            this.Name = "FormUsuario";
            this.Text = "Usuarios";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox Masked_Telefone;
        private System.Windows.Forms.TextBox Txt_NomeUsuario;
        private System.Windows.Forms.Label Label_NomeUsuario;
        private System.Windows.Forms.Button Btn_ListarUsuario;
        private System.Windows.Forms.Button Btn_SalvarUsuario;
        private System.Windows.Forms.Label Txt_TelefoneUsuario;
        private System.Windows.Forms.TextBox Txt_EmailUsuario;
        private System.Windows.Forms.Label Label_EmailUsuario;
    }
}