namespace SoccerManager.View.Principal
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Tsb_Usuarios = new System.Windows.Forms.ToolStripButton();
            this.Tsb_Times = new System.Windows.Forms.ToolStripButton();
            this.Tsb_Sorteio = new System.Windows.Forms.ToolStripButton();
            this.Lbl_TabelaDiv1 = new System.Windows.Forms.Label();
            this.LstView_TabelaDiv1 = new System.Windows.Forms.ListView();
            this.Lbl_TabelaDiv2 = new System.Windows.Forms.Label();
            this.LstView_TabelaDiv2 = new System.Windows.Forms.ListView();
            this.Btn_Atualizar = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Tsb_Usuarios,
            this.Tsb_Times,
            this.Tsb_Sorteio});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1350, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Tsb_Usuarios
            // 
            this.Tsb_Usuarios.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Tsb_Usuarios.Image = ((System.Drawing.Image)(resources.GetObject("Tsb_Usuarios.Image")));
            this.Tsb_Usuarios.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Tsb_Usuarios.Name = "Tsb_Usuarios";
            this.Tsb_Usuarios.Size = new System.Drawing.Size(56, 22);
            this.Tsb_Usuarios.Text = "Usuarios";
            this.Tsb_Usuarios.Click += new System.EventHandler(this.Tsb_Usuarios_Click);
            // 
            // Tsb_Times
            // 
            this.Tsb_Times.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Tsb_Times.Image = ((System.Drawing.Image)(resources.GetObject("Tsb_Times.Image")));
            this.Tsb_Times.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Tsb_Times.Name = "Tsb_Times";
            this.Tsb_Times.Size = new System.Drawing.Size(42, 22);
            this.Tsb_Times.Text = "Times";
            this.Tsb_Times.Click += new System.EventHandler(this.Tsb_Times_Click);
            // 
            // Tsb_Sorteio
            // 
            this.Tsb_Sorteio.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Tsb_Sorteio.Image = ((System.Drawing.Image)(resources.GetObject("Tsb_Sorteio.Image")));
            this.Tsb_Sorteio.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Tsb_Sorteio.Name = "Tsb_Sorteio";
            this.Tsb_Sorteio.Size = new System.Drawing.Size(48, 22);
            this.Tsb_Sorteio.Text = "Sorteio";
            this.Tsb_Sorteio.Click += new System.EventHandler(this.Tsb_Sorteio_Click);
            // 
            // Lbl_TabelaDiv1
            // 
            this.Lbl_TabelaDiv1.AutoSize = true;
            this.Lbl_TabelaDiv1.Location = new System.Drawing.Point(32, 46);
            this.Lbl_TabelaDiv1.Name = "Lbl_TabelaDiv1";
            this.Lbl_TabelaDiv1.Size = new System.Drawing.Size(97, 13);
            this.Lbl_TabelaDiv1.TabIndex = 4;
            this.Lbl_TabelaDiv1.Text = "Tabela - 1ª Divisão";
            // 
            // LstView_TabelaDiv1
            // 
            this.LstView_TabelaDiv1.HideSelection = false;
            this.LstView_TabelaDiv1.Location = new System.Drawing.Point(35, 62);
            this.LstView_TabelaDiv1.Name = "LstView_TabelaDiv1";
            this.LstView_TabelaDiv1.Size = new System.Drawing.Size(537, 382);
            this.LstView_TabelaDiv1.TabIndex = 1;
            this.LstView_TabelaDiv1.UseCompatibleStateImageBehavior = false;
            // 
            // Lbl_TabelaDiv2
            // 
            this.Lbl_TabelaDiv2.AutoSize = true;
            this.Lbl_TabelaDiv2.Location = new System.Drawing.Point(631, 46);
            this.Lbl_TabelaDiv2.Name = "Lbl_TabelaDiv2";
            this.Lbl_TabelaDiv2.Size = new System.Drawing.Size(97, 13);
            this.Lbl_TabelaDiv2.TabIndex = 5;
            this.Lbl_TabelaDiv2.Text = "Tabela - 2ª Divisão";
            // 
            // LstView_TabelaDiv2
            // 
            this.LstView_TabelaDiv2.HideSelection = false;
            this.LstView_TabelaDiv2.Location = new System.Drawing.Point(634, 62);
            this.LstView_TabelaDiv2.Name = "LstView_TabelaDiv2";
            this.LstView_TabelaDiv2.Size = new System.Drawing.Size(537, 382);
            this.LstView_TabelaDiv2.TabIndex = 2;
            this.LstView_TabelaDiv2.UseCompatibleStateImageBehavior = false;
            // 
            // Btn_Atualizar
            // 
            this.Btn_Atualizar.Location = new System.Drawing.Point(35, 460);
            this.Btn_Atualizar.Name = "Btn_Atualizar";
            this.Btn_Atualizar.Size = new System.Drawing.Size(118, 44);
            this.Btn_Atualizar.TabIndex = 3;
            this.Btn_Atualizar.Text = "Atualizar";
            this.Btn_Atualizar.UseVisualStyleBackColor = true;
            this.Btn_Atualizar.Click += new System.EventHandler(this.Btn_Atualizar_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.Btn_Atualizar);
            this.Controls.Add(this.LstView_TabelaDiv2);
            this.Controls.Add(this.Lbl_TabelaDiv2);
            this.Controls.Add(this.LstView_TabelaDiv1);
            this.Controls.Add(this.Lbl_TabelaDiv1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FormPrincipal";
            this.Text = "Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Tsb_Usuarios;
        private System.Windows.Forms.ToolStripButton Tsb_Times;
        private System.Windows.Forms.ToolStripButton Tsb_Sorteio;
        private System.Windows.Forms.Label Lbl_TabelaDiv1;
        private System.Windows.Forms.ListView LstView_TabelaDiv1;
        private System.Windows.Forms.Label Lbl_TabelaDiv2;
        private System.Windows.Forms.ListView LstView_TabelaDiv2;
        private System.Windows.Forms.Button Btn_Atualizar;
    }
}