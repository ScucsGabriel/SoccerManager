namespace SoccerManager.View.Sorteios
{
    partial class FormSorteios
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
            this.LstView_Sorteio = new System.Windows.Forms.ListView();
            this.Btn_GerarSorteio = new System.Windows.Forms.Button();
            this.Btn_SalvarXLS = new System.Windows.Forms.Button();
            this.Salvar_XLS = new System.Windows.Forms.SaveFileDialog();
            this.Btn_GravarTabela = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LstView_Sorteio
            // 
            this.LstView_Sorteio.HideSelection = false;
            this.LstView_Sorteio.Location = new System.Drawing.Point(30, 74);
            this.LstView_Sorteio.Name = "LstView_Sorteio";
            this.LstView_Sorteio.Size = new System.Drawing.Size(537, 322);
            this.LstView_Sorteio.TabIndex = 2;
            this.LstView_Sorteio.UseCompatibleStateImageBehavior = false;
            // 
            // Btn_GerarSorteio
            // 
            this.Btn_GerarSorteio.Location = new System.Drawing.Point(30, 15);
            this.Btn_GerarSorteio.Name = "Btn_GerarSorteio";
            this.Btn_GerarSorteio.Size = new System.Drawing.Size(118, 44);
            this.Btn_GerarSorteio.TabIndex = 1;
            this.Btn_GerarSorteio.Text = "Gerar Sorteio";
            this.Btn_GerarSorteio.UseVisualStyleBackColor = true;
            this.Btn_GerarSorteio.Click += new System.EventHandler(this.Btn_GerarSorteio_Click);
            // 
            // Btn_SalvarXLS
            // 
            this.Btn_SalvarXLS.Location = new System.Drawing.Point(452, 410);
            this.Btn_SalvarXLS.Name = "Btn_SalvarXLS";
            this.Btn_SalvarXLS.Size = new System.Drawing.Size(115, 28);
            this.Btn_SalvarXLS.TabIndex = 4;
            this.Btn_SalvarXLS.Text = "Salvar XLS";
            this.Btn_SalvarXLS.UseVisualStyleBackColor = true;
            this.Btn_SalvarXLS.Click += new System.EventHandler(this.Btn_SalvarXLS_Click);
            // 
            // Btn_GravarTabela
            // 
            this.Btn_GravarTabela.Location = new System.Drawing.Point(316, 410);
            this.Btn_GravarTabela.Name = "Btn_GravarTabela";
            this.Btn_GravarTabela.Size = new System.Drawing.Size(115, 28);
            this.Btn_GravarTabela.TabIndex = 3;
            this.Btn_GravarTabela.Text = "Gravar";
            this.Btn_GravarTabela.UseVisualStyleBackColor = true;
            this.Btn_GravarTabela.Click += new System.EventHandler(this.Btn_GravarTabela_Click);
            // 
            // FormSorteios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btn_GravarTabela);
            this.Controls.Add(this.Btn_SalvarXLS);
            this.Controls.Add(this.LstView_Sorteio);
            this.Controls.Add(this.Btn_GerarSorteio);
            this.Name = "FormSorteios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sorteio";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView LstView_Sorteio;
        private System.Windows.Forms.Button Btn_GerarSorteio;
        private System.Windows.Forms.Button Btn_SalvarXLS;
        private System.Windows.Forms.SaveFileDialog Salvar_XLS;
        private System.Windows.Forms.Button Btn_GravarTabela;
    }
}