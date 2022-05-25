using SoccerManager.Controller;
using System;
using System.Globalization;
using System.Windows.Forms;

namespace SoccerManager
{
    public partial class FormTime : Form
    {
        public FormTime()
        {
            InitializeComponent();
        }

        private void Btn_SalvarTime_Click(object sender, EventArgs e)
        {
            if (!ValidarPreenchimento())
                return;

            string timeAtivo = "Sim";

            TimeController inserirTime = new TimeController();
            inserirTime.InserirTime(Txt_Time.Text.Trim(), timeAtivo);

            MessageBox.Show("Cadastro incluído com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Limpar();
        }

        private void Limpar()
        {
            Txt_Time.Text = "";
        }

        private void Btn_ListarTime_Click(object sender, EventArgs e)
        {
            FormListarTime formListarTime = new FormListarTime();
            formListarTime.ShowDialog();
            this.Close();
        }
        private bool ValidarPreenchimento()
        {
            if (Txt_Time.Text == "")
            {
                MessageBox.Show("Time está vazio.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Txt_Time.Text.Length > 50)
            {
                MessageBox.Show("Time está muito grande.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
    }
}
