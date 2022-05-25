namespace SoccerManager
{
    partial class FormListarUsuario
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
            this.Btn_BuscarTodosUsuarios = new System.Windows.Forms.Button();
            this.Txt_EmailBusca = new System.Windows.Forms.TextBox();
            this.Label_BuscaEmailUsuario = new System.Windows.Forms.Label();
            this.Btn_EditarUsuario = new System.Windows.Forms.Button();
            this.Btn_ExcluirUsuario = new System.Windows.Forms.Button();
            this.Btn_BuscarPorEmail = new System.Windows.Forms.Button();
            this.Txt_UsuarioBusca = new System.Windows.Forms.TextBox();
            this.Label_BuscaNomeUsuario = new System.Windows.Forms.Label();
            this.LstView_ListaUsuario = new System.Windows.Forms.ListView();
            this.Btn_VoltarCadUsu = new System.Windows.Forms.Button();
            this.Btn_BuscarPorUsuario = new System.Windows.Forms.Button();
            this.Label_CalculaQuantidadeUsu = new System.Windows.Forms.Label();
            this.Label_QuantidadeUsuarios = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Btn_BuscarTodosUsuarios
            // 
            this.Btn_BuscarTodosUsuarios.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Btn_BuscarTodosUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Btn_BuscarTodosUsuarios.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Btn_BuscarTodosUsuarios.Location = new System.Drawing.Point(296, 44);
            this.Btn_BuscarTodosUsuarios.Name = "Btn_BuscarTodosUsuarios";
            this.Btn_BuscarTodosUsuarios.Size = new System.Drawing.Size(134, 34);
            this.Btn_BuscarTodosUsuarios.TabIndex = 5;
            this.Btn_BuscarTodosUsuarios.Text = "Buscar Todos";
            this.Btn_BuscarTodosUsuarios.UseVisualStyleBackColor = false;
            this.Btn_BuscarTodosUsuarios.Click += new System.EventHandler(this.Btn_BuscarTodosUsuarios_Click);
            // 
            // Txt_EmailBusca
            // 
            this.Txt_EmailBusca.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_EmailBusca.Location = new System.Drawing.Point(450, 12);
            this.Txt_EmailBusca.Name = "Txt_EmailBusca";
            this.Txt_EmailBusca.Size = new System.Drawing.Size(237, 21);
            this.Txt_EmailBusca.TabIndex = 2;
            // 
            // Label_BuscaEmailUsuario
            // 
            this.Label_BuscaEmailUsuario.AutoSize = true;
            this.Label_BuscaEmailUsuario.Location = new System.Drawing.Point(409, 16);
            this.Label_BuscaEmailUsuario.Name = "Label_BuscaEmailUsuario";
            this.Label_BuscaEmailUsuario.Size = new System.Drawing.Size(35, 13);
            this.Label_BuscaEmailUsuario.TabIndex = 11;
            this.Label_BuscaEmailUsuario.Text = "E-mail";
            // 
            // Btn_EditarUsuario
            // 
            this.Btn_EditarUsuario.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Btn_EditarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_EditarUsuario.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Btn_EditarUsuario.Location = new System.Drawing.Point(436, 44);
            this.Btn_EditarUsuario.Name = "Btn_EditarUsuario";
            this.Btn_EditarUsuario.Size = new System.Drawing.Size(134, 34);
            this.Btn_EditarUsuario.TabIndex = 6;
            this.Btn_EditarUsuario.Text = "Editar";
            this.Btn_EditarUsuario.UseVisualStyleBackColor = false;
            this.Btn_EditarUsuario.Click += new System.EventHandler(this.Btn_EditarUsuario_Click);
            // 
            // Btn_ExcluirUsuario
            // 
            this.Btn_ExcluirUsuario.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Btn_ExcluirUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ExcluirUsuario.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Btn_ExcluirUsuario.Location = new System.Drawing.Point(576, 44);
            this.Btn_ExcluirUsuario.Name = "Btn_ExcluirUsuario";
            this.Btn_ExcluirUsuario.Size = new System.Drawing.Size(134, 33);
            this.Btn_ExcluirUsuario.TabIndex = 7;
            this.Btn_ExcluirUsuario.Text = "Excluir";
            this.Btn_ExcluirUsuario.UseVisualStyleBackColor = false;
            this.Btn_ExcluirUsuario.Click += new System.EventHandler(this.Btn_ExcluirUsuario_Click);
            // 
            // Btn_BuscarPorEmail
            // 
            this.Btn_BuscarPorEmail.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Btn_BuscarPorEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Btn_BuscarPorEmail.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Btn_BuscarPorEmail.Location = new System.Drawing.Point(156, 46);
            this.Btn_BuscarPorEmail.Name = "Btn_BuscarPorEmail";
            this.Btn_BuscarPorEmail.Size = new System.Drawing.Size(134, 34);
            this.Btn_BuscarPorEmail.TabIndex = 4;
            this.Btn_BuscarPorEmail.Text = "Buscar por E-mail";
            this.Btn_BuscarPorEmail.UseVisualStyleBackColor = false;
            this.Btn_BuscarPorEmail.Click += new System.EventHandler(this.Btn_BuscarPorEmail_Click);
            // 
            // Txt_UsuarioBusca
            // 
            this.Txt_UsuarioBusca.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_UsuarioBusca.Location = new System.Drawing.Point(105, 12);
            this.Txt_UsuarioBusca.Name = "Txt_UsuarioBusca";
            this.Txt_UsuarioBusca.Size = new System.Drawing.Size(237, 21);
            this.Txt_UsuarioBusca.TabIndex = 1;
            // 
            // Label_BuscaNomeUsuario
            // 
            this.Label_BuscaNomeUsuario.AutoSize = true;
            this.Label_BuscaNomeUsuario.Location = new System.Drawing.Point(14, 16);
            this.Label_BuscaNomeUsuario.Name = "Label_BuscaNomeUsuario";
            this.Label_BuscaNomeUsuario.Size = new System.Drawing.Size(89, 13);
            this.Label_BuscaNomeUsuario.TabIndex = 10;
            this.Label_BuscaNomeUsuario.Text = "Nome do Usuário";
            // 
            // LstView_ListaUsuario
            // 
            this.LstView_ListaUsuario.AllowColumnReorder = true;
            this.LstView_ListaUsuario.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LstView_ListaUsuario.HideSelection = false;
            this.LstView_ListaUsuario.Location = new System.Drawing.Point(16, 95);
            this.LstView_ListaUsuario.Name = "LstView_ListaUsuario";
            this.LstView_ListaUsuario.Size = new System.Drawing.Size(1308, 499);
            this.LstView_ListaUsuario.TabIndex = 9;
            this.LstView_ListaUsuario.UseCompatibleStateImageBehavior = false;
            // 
            // Btn_VoltarCadUsu
            // 
            this.Btn_VoltarCadUsu.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Btn_VoltarCadUsu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_VoltarCadUsu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Btn_VoltarCadUsu.Location = new System.Drawing.Point(716, 43);
            this.Btn_VoltarCadUsu.Name = "Btn_VoltarCadUsu";
            this.Btn_VoltarCadUsu.Size = new System.Drawing.Size(134, 34);
            this.Btn_VoltarCadUsu.TabIndex = 8;
            this.Btn_VoltarCadUsu.Text = "Voltar";
            this.Btn_VoltarCadUsu.UseVisualStyleBackColor = false;
            this.Btn_VoltarCadUsu.Click += new System.EventHandler(this.Btn_VoltarCadUsu_Click);
            // 
            // Btn_BuscarPorUsuario
            // 
            this.Btn_BuscarPorUsuario.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Btn_BuscarPorUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Btn_BuscarPorUsuario.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Btn_BuscarPorUsuario.Location = new System.Drawing.Point(16, 46);
            this.Btn_BuscarPorUsuario.Name = "Btn_BuscarPorUsuario";
            this.Btn_BuscarPorUsuario.Size = new System.Drawing.Size(134, 33);
            this.Btn_BuscarPorUsuario.TabIndex = 3;
            this.Btn_BuscarPorUsuario.Text = "Buscar por Usuário";
            this.Btn_BuscarPorUsuario.UseVisualStyleBackColor = false;
            this.Btn_BuscarPorUsuario.Click += new System.EventHandler(this.Btn_BuscarPorUsuario_Click);
            // 
            // Label_CalculaQuantidadeUsu
            // 
            this.Label_CalculaQuantidadeUsu.AutoSize = true;
            this.Label_CalculaQuantidadeUsu.Location = new System.Drawing.Point(13, 640);
            this.Label_CalculaQuantidadeUsu.Name = "Label_CalculaQuantidadeUsu";
            this.Label_CalculaQuantidadeUsu.Size = new System.Drawing.Size(13, 13);
            this.Label_CalculaQuantidadeUsu.TabIndex = 13;
            this.Label_CalculaQuantidadeUsu.Text = "0";
            // 
            // Label_QuantidadeUsuarios
            // 
            this.Label_QuantidadeUsuarios.AutoSize = true;
            this.Label_QuantidadeUsuarios.Location = new System.Drawing.Point(13, 609);
            this.Label_QuantidadeUsuarios.Name = "Label_QuantidadeUsuarios";
            this.Label_QuantidadeUsuarios.Size = new System.Drawing.Size(121, 13);
            this.Label_QuantidadeUsuarios.TabIndex = 12;
            this.Label_QuantidadeUsuarios.Text = "Quantidade de Usuários";
            // 
            // FormListarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1360, 684);
            this.Controls.Add(this.Label_CalculaQuantidadeUsu);
            this.Controls.Add(this.Label_QuantidadeUsuarios);
            this.Controls.Add(this.Btn_BuscarTodosUsuarios);
            this.Controls.Add(this.Txt_EmailBusca);
            this.Controls.Add(this.Label_BuscaEmailUsuario);
            this.Controls.Add(this.Btn_EditarUsuario);
            this.Controls.Add(this.Btn_ExcluirUsuario);
            this.Controls.Add(this.Btn_BuscarPorEmail);
            this.Controls.Add(this.Txt_UsuarioBusca);
            this.Controls.Add(this.Label_BuscaNomeUsuario);
            this.Controls.Add(this.LstView_ListaUsuario);
            this.Controls.Add(this.Btn_VoltarCadUsu);
            this.Controls.Add(this.Btn_BuscarPorUsuario);
            this.Name = "FormListarUsuario";
            this.Text = "Lista de Usuarios";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormListarUsuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_BuscarTodosUsuarios;
        private System.Windows.Forms.TextBox Txt_EmailBusca;
        private System.Windows.Forms.Label Label_BuscaEmailUsuario;
        private System.Windows.Forms.Button Btn_EditarUsuario;
        private System.Windows.Forms.Button Btn_ExcluirUsuario;
        private System.Windows.Forms.Button Btn_BuscarPorEmail;
        private System.Windows.Forms.TextBox Txt_UsuarioBusca;
        private System.Windows.Forms.Label Label_BuscaNomeUsuario;
        private System.Windows.Forms.ListView LstView_ListaUsuario;
        private System.Windows.Forms.Button Btn_VoltarCadUsu;
        private System.Windows.Forms.Button Btn_BuscarPorUsuario;
        private System.Windows.Forms.Label Label_CalculaQuantidadeUsu;
        private System.Windows.Forms.Label Label_QuantidadeUsuarios;
    }
}