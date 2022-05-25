namespace SoccerManager
{
    partial class FormListarTime
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
            this.Btn_BuscarTodos = new System.Windows.Forms.Button();
            this.Btn_EditarTime = new System.Windows.Forms.Button();
            this.Btn_ExcluirTime = new System.Windows.Forms.Button();
            this.Txt_TimeBusca = new System.Windows.Forms.TextBox();
            this.Label_BuscaTime = new System.Windows.Forms.Label();
            this.LstView_ListaTime = new System.Windows.Forms.ListView();
            this.Btn_VoltarCadTime = new System.Windows.Forms.Button();
            this.Btn_BuscarPorTime = new System.Windows.Forms.Button();
            this.Label_CalculaQuantidadeTime = new System.Windows.Forms.Label();
            this.Label_QuantidadeTimes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Btn_BuscarTodos
            // 
            this.Btn_BuscarTodos.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Btn_BuscarTodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Btn_BuscarTodos.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Btn_BuscarTodos.Location = new System.Drawing.Point(439, 13);
            this.Btn_BuscarTodos.Name = "Btn_BuscarTodos";
            this.Btn_BuscarTodos.Size = new System.Drawing.Size(134, 33);
            this.Btn_BuscarTodos.TabIndex = 11;
            this.Btn_BuscarTodos.Text = "Buscar Todos";
            this.Btn_BuscarTodos.UseVisualStyleBackColor = false;
            this.Btn_BuscarTodos.Click += new System.EventHandler(this.Btn_BuscarTodos_Click);
            // 
            // Btn_EditarTime
            // 
            this.Btn_EditarTime.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Btn_EditarTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_EditarTime.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Btn_EditarTime.Location = new System.Drawing.Point(579, 12);
            this.Btn_EditarTime.Name = "Btn_EditarTime";
            this.Btn_EditarTime.Size = new System.Drawing.Size(134, 34);
            this.Btn_EditarTime.TabIndex = 12;
            this.Btn_EditarTime.Text = "Editar";
            this.Btn_EditarTime.UseVisualStyleBackColor = false;
            this.Btn_EditarTime.Click += new System.EventHandler(this.Btn_EditarTime_Click);
            // 
            // Btn_ExcluirTime
            // 
            this.Btn_ExcluirTime.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Btn_ExcluirTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ExcluirTime.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Btn_ExcluirTime.Location = new System.Drawing.Point(719, 12);
            this.Btn_ExcluirTime.Name = "Btn_ExcluirTime";
            this.Btn_ExcluirTime.Size = new System.Drawing.Size(134, 33);
            this.Btn_ExcluirTime.TabIndex = 13;
            this.Btn_ExcluirTime.Text = "Excluir";
            this.Btn_ExcluirTime.UseVisualStyleBackColor = false;
            this.Btn_ExcluirTime.Click += new System.EventHandler(this.Btn_ExcluirTime_Click);
            // 
            // Txt_TimeBusca
            // 
            this.Txt_TimeBusca.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_TimeBusca.Location = new System.Drawing.Point(56, 24);
            this.Txt_TimeBusca.Name = "Txt_TimeBusca";
            this.Txt_TimeBusca.Size = new System.Drawing.Size(237, 21);
            this.Txt_TimeBusca.TabIndex = 9;
            // 
            // Label_BuscaTime
            // 
            this.Label_BuscaTime.AutoSize = true;
            this.Label_BuscaTime.Location = new System.Drawing.Point(20, 28);
            this.Label_BuscaTime.Name = "Label_BuscaTime";
            this.Label_BuscaTime.Size = new System.Drawing.Size(30, 13);
            this.Label_BuscaTime.TabIndex = 16;
            this.Label_BuscaTime.Text = "Time";
            // 
            // LstView_ListaTime
            // 
            this.LstView_ListaTime.AllowColumnReorder = true;
            this.LstView_ListaTime.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LstView_ListaTime.HideSelection = false;
            this.LstView_ListaTime.Location = new System.Drawing.Point(23, 53);
            this.LstView_ListaTime.Name = "LstView_ListaTime";
            this.LstView_ListaTime.Size = new System.Drawing.Size(1313, 536);
            this.LstView_ListaTime.TabIndex = 15;
            this.LstView_ListaTime.UseCompatibleStateImageBehavior = false;
            // 
            // Btn_VoltarCadTime
            // 
            this.Btn_VoltarCadTime.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Btn_VoltarCadTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_VoltarCadTime.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Btn_VoltarCadTime.Location = new System.Drawing.Point(859, 12);
            this.Btn_VoltarCadTime.Name = "Btn_VoltarCadTime";
            this.Btn_VoltarCadTime.Size = new System.Drawing.Size(134, 34);
            this.Btn_VoltarCadTime.TabIndex = 14;
            this.Btn_VoltarCadTime.Text = "Voltar";
            this.Btn_VoltarCadTime.UseVisualStyleBackColor = false;
            this.Btn_VoltarCadTime.Click += new System.EventHandler(this.Btn_VoltarCadTime_Click);
            // 
            // Btn_BuscarPorTime
            // 
            this.Btn_BuscarPorTime.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Btn_BuscarPorTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Btn_BuscarPorTime.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Btn_BuscarPorTime.Location = new System.Drawing.Point(299, 12);
            this.Btn_BuscarPorTime.Name = "Btn_BuscarPorTime";
            this.Btn_BuscarPorTime.Size = new System.Drawing.Size(134, 33);
            this.Btn_BuscarPorTime.TabIndex = 10;
            this.Btn_BuscarPorTime.Text = "Buscar por Time";
            this.Btn_BuscarPorTime.UseVisualStyleBackColor = false;
            this.Btn_BuscarPorTime.Click += new System.EventHandler(this.Btn_BuscarPorTime_Click);
            // 
            // Label_CalculaQuantidadeTime
            // 
            this.Label_CalculaQuantidadeTime.AutoSize = true;
            this.Label_CalculaQuantidadeTime.Location = new System.Drawing.Point(20, 631);
            this.Label_CalculaQuantidadeTime.Name = "Label_CalculaQuantidadeTime";
            this.Label_CalculaQuantidadeTime.Size = new System.Drawing.Size(13, 13);
            this.Label_CalculaQuantidadeTime.TabIndex = 18;
            this.Label_CalculaQuantidadeTime.Text = "0";
            // 
            // Label_QuantidadeTimes
            // 
            this.Label_QuantidadeTimes.AutoSize = true;
            this.Label_QuantidadeTimes.Location = new System.Drawing.Point(20, 601);
            this.Label_QuantidadeTimes.Name = "Label_QuantidadeTimes";
            this.Label_QuantidadeTimes.Size = new System.Drawing.Size(108, 13);
            this.Label_QuantidadeTimes.TabIndex = 17;
            this.Label_QuantidadeTimes.Text = "Quantidade de Times";
            // 
            // FormListarTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 665);
            this.Controls.Add(this.Label_CalculaQuantidadeTime);
            this.Controls.Add(this.Label_QuantidadeTimes);
            this.Controls.Add(this.Btn_BuscarTodos);
            this.Controls.Add(this.Btn_EditarTime);
            this.Controls.Add(this.Btn_ExcluirTime);
            this.Controls.Add(this.Txt_TimeBusca);
            this.Controls.Add(this.Label_BuscaTime);
            this.Controls.Add(this.LstView_ListaTime);
            this.Controls.Add(this.Btn_VoltarCadTime);
            this.Controls.Add(this.Btn_BuscarPorTime);
            this.Name = "FormListarTime";
            this.Text = "ListarTime";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormListarTime_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_BuscarTodos;
        private System.Windows.Forms.Button Btn_EditarTime;
        private System.Windows.Forms.Button Btn_ExcluirTime;
        private System.Windows.Forms.TextBox Txt_TimeBusca;
        private System.Windows.Forms.Label Label_BuscaTime;
        private System.Windows.Forms.ListView LstView_ListaTime;
        private System.Windows.Forms.Button Btn_VoltarCadTime;
        private System.Windows.Forms.Button Btn_BuscarPorTime;
        private System.Windows.Forms.Label Label_CalculaQuantidadeTime;
        private System.Windows.Forms.Label Label_QuantidadeTimes;
    }
}