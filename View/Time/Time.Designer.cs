namespace SoccerManager
{
    partial class FormTime
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
            this.Txt_Time = new System.Windows.Forms.TextBox();
            this.Label_Time = new System.Windows.Forms.Label();
            this.Btn_ListarTime = new System.Windows.Forms.Button();
            this.Btn_SalvarTime = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Txt_Time
            // 
            this.Txt_Time.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Time.Location = new System.Drawing.Point(143, 24);
            this.Txt_Time.Name = "Txt_Time";
            this.Txt_Time.Size = new System.Drawing.Size(199, 21);
            this.Txt_Time.TabIndex = 1;
            // 
            // Label_Time
            // 
            this.Label_Time.AutoSize = true;
            this.Label_Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Time.Location = new System.Drawing.Point(102, 24);
            this.Label_Time.Name = "Label_Time";
            this.Label_Time.Size = new System.Drawing.Size(35, 15);
            this.Label_Time.TabIndex = 4;
            this.Label_Time.Text = "Time";
            // 
            // Btn_ListarTime
            // 
            this.Btn_ListarTime.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Btn_ListarTime.Cursor = System.Windows.Forms.Cursors.No;
            this.Btn_ListarTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ListarTime.Location = new System.Drawing.Point(45, 61);
            this.Btn_ListarTime.Name = "Btn_ListarTime";
            this.Btn_ListarTime.Size = new System.Drawing.Size(121, 38);
            this.Btn_ListarTime.TabIndex = 3;
            this.Btn_ListarTime.Text = "Listar";
            this.Btn_ListarTime.UseVisualStyleBackColor = false;
            this.Btn_ListarTime.Click += new System.EventHandler(this.Btn_ListarTime_Click);
            // 
            // Btn_SalvarTime
            // 
            this.Btn_SalvarTime.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Btn_SalvarTime.Cursor = System.Windows.Forms.Cursors.No;
            this.Btn_SalvarTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_SalvarTime.Location = new System.Drawing.Point(221, 61);
            this.Btn_SalvarTime.Name = "Btn_SalvarTime";
            this.Btn_SalvarTime.Size = new System.Drawing.Size(121, 39);
            this.Btn_SalvarTime.TabIndex = 2;
            this.Btn_SalvarTime.Text = "Salvar";
            this.Btn_SalvarTime.UseVisualStyleBackColor = false;
            this.Btn_SalvarTime.Click += new System.EventHandler(this.Btn_SalvarTime_Click);
            // 
            // FormTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 114);
            this.Controls.Add(this.Txt_Time);
            this.Controls.Add(this.Label_Time);
            this.Controls.Add(this.Btn_ListarTime);
            this.Controls.Add(this.Btn_SalvarTime);
            this.Name = "FormTime";
            this.Text = "Time";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Txt_Time;
        private System.Windows.Forms.Label Label_Time;
        private System.Windows.Forms.Button Btn_ListarTime;
        private System.Windows.Forms.Button Btn_SalvarTime;
    }
}