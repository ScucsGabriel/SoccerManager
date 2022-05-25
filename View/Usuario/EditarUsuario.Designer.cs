namespace SoccerManager
{
    partial class FormEditarUsuario
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
            this.Masked_TelefoneEdit = new System.Windows.Forms.MaskedTextBox();
            this.Txt_NomeUsuarioEdit = new System.Windows.Forms.TextBox();
            this.Label_NomeUsuarioEdit = new System.Windows.Forms.Label();
            this.Label_CodigoUsuario = new System.Windows.Forms.Label();
            this.Label_CodigoUsuarioEdit = new System.Windows.Forms.Label();
            this.Btn_SalvarEditUsuario = new System.Windows.Forms.Button();
            this.Label_TelefoneEdit = new System.Windows.Forms.Label();
            this.Txt_EmailUsuarioEdit = new System.Windows.Forms.TextBox();
            this.Label_EmailUsuarioEdit = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Masked_TelefoneEdit
            // 
            this.Masked_TelefoneEdit.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Masked_TelefoneEdit.Location = new System.Drawing.Point(147, 120);
            this.Masked_TelefoneEdit.Mask = "(##) # ####-####";
            this.Masked_TelefoneEdit.Name = "Masked_TelefoneEdit";
            this.Masked_TelefoneEdit.Size = new System.Drawing.Size(199, 21);
            this.Masked_TelefoneEdit.TabIndex = 4;
            // 
            // Txt_NomeUsuarioEdit
            // 
            this.Txt_NomeUsuarioEdit.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_NomeUsuarioEdit.Location = new System.Drawing.Point(147, 50);
            this.Txt_NomeUsuarioEdit.Name = "Txt_NomeUsuarioEdit";
            this.Txt_NomeUsuarioEdit.Size = new System.Drawing.Size(199, 21);
            this.Txt_NomeUsuarioEdit.TabIndex = 2;
            // 
            // Label_NomeUsuarioEdit
            // 
            this.Label_NomeUsuarioEdit.AutoSize = true;
            this.Label_NomeUsuarioEdit.Location = new System.Drawing.Point(56, 54);
            this.Label_NomeUsuarioEdit.Name = "Label_NomeUsuarioEdit";
            this.Label_NomeUsuarioEdit.Size = new System.Drawing.Size(89, 13);
            this.Label_NomeUsuarioEdit.TabIndex = 7;
            this.Label_NomeUsuarioEdit.Text = "Nome do Usuário";
            // 
            // Label_CodigoUsuario
            // 
            this.Label_CodigoUsuario.AutoSize = true;
            this.Label_CodigoUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_CodigoUsuario.Location = new System.Drawing.Point(144, 26);
            this.Label_CodigoUsuario.Name = "Label_CodigoUsuario";
            this.Label_CodigoUsuario.Size = new System.Drawing.Size(14, 15);
            this.Label_CodigoUsuario.TabIndex = 1;
            this.Label_CodigoUsuario.Text = "0";
            // 
            // Label_CodigoUsuarioEdit
            // 
            this.Label_CodigoUsuarioEdit.AutoSize = true;
            this.Label_CodigoUsuarioEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_CodigoUsuarioEdit.Location = new System.Drawing.Point(95, 26);
            this.Label_CodigoUsuarioEdit.Name = "Label_CodigoUsuarioEdit";
            this.Label_CodigoUsuarioEdit.Size = new System.Drawing.Size(46, 15);
            this.Label_CodigoUsuarioEdit.TabIndex = 6;
            this.Label_CodigoUsuarioEdit.Text = "Código";
            // 
            // Btn_SalvarEditUsuario
            // 
            this.Btn_SalvarEditUsuario.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Btn_SalvarEditUsuario.Cursor = System.Windows.Forms.Cursors.No;
            this.Btn_SalvarEditUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_SalvarEditUsuario.Location = new System.Drawing.Point(225, 147);
            this.Btn_SalvarEditUsuario.Name = "Btn_SalvarEditUsuario";
            this.Btn_SalvarEditUsuario.Size = new System.Drawing.Size(121, 39);
            this.Btn_SalvarEditUsuario.TabIndex = 5;
            this.Btn_SalvarEditUsuario.Text = "Salvar";
            this.Btn_SalvarEditUsuario.UseVisualStyleBackColor = false;
            this.Btn_SalvarEditUsuario.Click += new System.EventHandler(this.Btn_SalvarEditUsuario_Click);
            // 
            // Label_TelefoneEdit
            // 
            this.Label_TelefoneEdit.AutoSize = true;
            this.Label_TelefoneEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_TelefoneEdit.Location = new System.Drawing.Point(86, 120);
            this.Label_TelefoneEdit.Name = "Label_TelefoneEdit";
            this.Label_TelefoneEdit.Size = new System.Drawing.Size(55, 15);
            this.Label_TelefoneEdit.TabIndex = 9;
            this.Label_TelefoneEdit.Text = "Telefone";
            // 
            // Txt_EmailUsuarioEdit
            // 
            this.Txt_EmailUsuarioEdit.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_EmailUsuarioEdit.Location = new System.Drawing.Point(147, 84);
            this.Txt_EmailUsuarioEdit.Name = "Txt_EmailUsuarioEdit";
            this.Txt_EmailUsuarioEdit.Size = new System.Drawing.Size(199, 21);
            this.Txt_EmailUsuarioEdit.TabIndex = 3;
            // 
            // Label_EmailUsuarioEdit
            // 
            this.Label_EmailUsuarioEdit.AutoSize = true;
            this.Label_EmailUsuarioEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_EmailUsuarioEdit.Location = new System.Drawing.Point(98, 86);
            this.Label_EmailUsuarioEdit.Name = "Label_EmailUsuarioEdit";
            this.Label_EmailUsuarioEdit.Size = new System.Drawing.Size(43, 15);
            this.Label_EmailUsuarioEdit.TabIndex = 8;
            this.Label_EmailUsuarioEdit.Text = "E-mail";
            // 
            // FormEditarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 193);
            this.Controls.Add(this.Masked_TelefoneEdit);
            this.Controls.Add(this.Txt_NomeUsuarioEdit);
            this.Controls.Add(this.Label_NomeUsuarioEdit);
            this.Controls.Add(this.Label_CodigoUsuario);
            this.Controls.Add(this.Label_CodigoUsuarioEdit);
            this.Controls.Add(this.Btn_SalvarEditUsuario);
            this.Controls.Add(this.Label_TelefoneEdit);
            this.Controls.Add(this.Txt_EmailUsuarioEdit);
            this.Controls.Add(this.Label_EmailUsuarioEdit);
            this.Name = "FormEditarUsuario";
            this.Text = "Usuarios";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox Masked_TelefoneEdit;
        private System.Windows.Forms.TextBox Txt_NomeUsuarioEdit;
        private System.Windows.Forms.Label Label_NomeUsuarioEdit;
        private System.Windows.Forms.Label Label_CodigoUsuario;
        private System.Windows.Forms.Label Label_CodigoUsuarioEdit;
        private System.Windows.Forms.Button Btn_SalvarEditUsuario;
        private System.Windows.Forms.Label Label_TelefoneEdit;
        private System.Windows.Forms.TextBox Txt_EmailUsuarioEdit;
        private System.Windows.Forms.Label Label_EmailUsuarioEdit;
    }
}