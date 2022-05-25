using SoccerManager.Controller;
using SoccerManager.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoccerManager
{
    public partial class FormEditarTime : Form
    {
        public FormEditarTime(List<Time> listaTime)
        {
            InitializeComponent();
            foreach (var item in listaTime)
            {
                Label_CodigoTime.Text = item.idTime.ToString();
                Txt_TimeEdit.Text = item.time.ToString();
            }
        }

        private void Btn_SalvarEditTime_Click(object sender, EventArgs e)
        {
            if (!ValidarPreenchimento())
                return;

            string timeAtivo = "Sim";

            TimeController editarTime = new TimeController();
            editarTime.EditarTime(Convert.ToInt32(Label_CodigoTime.Text), Txt_TimeEdit.Text.Trim(), timeAtivo);

            MessageBox.Show("Cadastro atualizado com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Limpar();
            this.Close();
        }

        private void Limpar()
        {
            Txt_TimeEdit.Text = "";
        }

        private void Btn_ListarEditTime_Click(object sender, EventArgs e)
        {
            FormListarTime formListarTime = new FormListarTime();
            formListarTime.Show();
            this.Close();
        }
        private bool ValidarPreenchimento()
        {
            if (Txt_TimeEdit.Text == "")
            {
                MessageBox.Show("Time está vazio.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Txt_TimeEdit.Text.Length > 50)
            {
                MessageBox.Show("Time está muito grande.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
    }
}
