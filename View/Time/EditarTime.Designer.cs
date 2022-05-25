namespace SoccerManager
{
    partial class FormEditarTime
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
            this.Txt_TimeEdit = new System.Windows.Forms.TextBox();
            this.Label_TimeEdit = new System.Windows.Forms.Label();
            this.Label_CodigoTime = new System.Windows.Forms.Label();
            this.Label_CodigoTimeEdit = new System.Windows.Forms.Label();
            this.Btn_SalvarEditTime = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Txt_TimeEdit
            // 
            this.Txt_TimeEdit.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_TimeEdit.Location = new System.Drawing.Point(120, 37);
            this.Txt_TimeEdit.Name = "Txt_TimeEdit";
            this.Txt_TimeEdit.Size = new System.Drawing.Size(199, 21);
            this.Txt_TimeEdit.TabIndex = 2;
            // 
            // Label_TimeEdit
            // 
            this.Label_TimeEdit.AutoSize = true;
            this.Label_TimeEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.Label_TimeEdit.Location = new System.Drawing.Point(79, 39);
            this.Label_TimeEdit.Name = "Label_TimeEdit";
            this.Label_TimeEdit.Size = new System.Drawing.Size(35, 15);
            this.Label_TimeEdit.TabIndex = 5;
            this.Label_TimeEdit.Text = "Time";
            // 
            // Label_CodigoTime
            // 
            this.Label_CodigoTime.AutoSize = true;
            this.Label_CodigoTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_CodigoTime.Location = new System.Drawing.Point(117, 9);
            this.Label_CodigoTime.Name = "Label_CodigoTime";
            this.Label_CodigoTime.Size = new System.Drawing.Size(14, 15);
            this.Label_CodigoTime.TabIndex = 1;
            this.Label_CodigoTime.Text = "0";
            // 
            // Label_CodigoTimeEdit
            // 
            this.Label_CodigoTimeEdit.AutoSize = true;
            this.Label_CodigoTimeEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_CodigoTimeEdit.Location = new System.Drawing.Point(68, 9);
            this.Label_CodigoTimeEdit.Name = "Label_CodigoTimeEdit";
            this.Label_CodigoTimeEdit.Size = new System.Drawing.Size(46, 15);
            this.Label_CodigoTimeEdit.TabIndex = 4;
            this.Label_CodigoTimeEdit.Text = "Código";
            // 
            // Btn_SalvarEditTime
            // 
            this.Btn_SalvarEditTime.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Btn_SalvarEditTime.Cursor = System.Windows.Forms.Cursors.No;
            this.Btn_SalvarEditTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_SalvarEditTime.Location = new System.Drawing.Point(198, 64);
            this.Btn_SalvarEditTime.Name = "Btn_SalvarEditTime";
            this.Btn_SalvarEditTime.Size = new System.Drawing.Size(121, 39);
            this.Btn_SalvarEditTime.TabIndex = 3;
            this.Btn_SalvarEditTime.Text = "Salvar";
            this.Btn_SalvarEditTime.UseVisualStyleBackColor = false;
            this.Btn_SalvarEditTime.Click += new System.EventHandler(this.Btn_SalvarEditTime_Click);
            // 
            // FormEditarTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 114);
            this.Controls.Add(this.Txt_TimeEdit);
            this.Controls.Add(this.Label_TimeEdit);
            this.Controls.Add(this.Label_CodigoTime);
            this.Controls.Add(this.Label_CodigoTimeEdit);
            this.Controls.Add(this.Btn_SalvarEditTime);
            this.Name = "FormEditarTime";
            this.Text = "Time";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Txt_TimeEdit;
        private System.Windows.Forms.Label Label_TimeEdit;
        private System.Windows.Forms.Label Label_CodigoTime;
        private System.Windows.Forms.Label Label_CodigoTimeEdit;
        private System.Windows.Forms.Button Btn_SalvarEditTime;
    }
}