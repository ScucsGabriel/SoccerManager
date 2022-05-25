using SoccerManager.Controller;
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
    public partial class FormUsuario : Form
    {
        public FormUsuario()
        {
            InitializeComponent();
        }

        private void Btn_SalvarUsuario_Click(object sender, EventArgs e)
        {
            if (!ValidarPreenchimento())
                return;

            string usuarioAtivo = "Sim";
            UsuarioController inserirUsuario = new UsuarioController();
            inserirUsuario.InserirUsuario(Txt_NomeUsuario.Text.Trim(), Txt_EmailUsuario.Text.Trim(), Masked_Telefone.Text.Trim(),
                 usuarioAtivo);

            MessageBox.Show("Cadastro incluído com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Limpar();
        }

        private void Limpar()
        {
            Txt_NomeUsuario.Text = "";
            Txt_EmailUsuario.Text = "";
            Masked_Telefone.Text = "";
        }

        private void Btn_ListarUsuario_Click(object sender, EventArgs e)
        {
            FormListarUsuario formListarUsuario = new FormListarUsuario();
            formListarUsuario.ShowDialog();
            this.Close();
        }

        private void Btn_VoltarUsuario_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool ValidarPreenchimento()
        {

            if (Txt_NomeUsuario.Text == "")
            {
                MessageBox.Show("Nome do usuário está vazio.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (IsNome(Txt_NomeUsuario.Text) == false)
            {
                MessageBox.Show("Nome do usuário não contém somente letras.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Txt_NomeUsuario.Text.Length > 50)
            {
                MessageBox.Show("Nome do usuário está muito grande.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Txt_EmailUsuario.Text == "")
            {
                MessageBox.Show("E-mail está vazio.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (IsEmail(Txt_EmailUsuario.Text) == false)
            {
                MessageBox.Show("E-mail não está num formato correto.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Txt_EmailUsuario.Text.Length > 100)
            {
                MessageBox.Show("E-mail está muito grande.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (!Masked_Telefone.MaskFull)
            {
                MessageBox.Show("Telefone está vazio ou incompleto.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }            
            return true;
        }

        public static bool IsNome(string strNome)
        {
            for (int i = 0; i < strNome.Length; i++)
            {
                if (!Char.IsLetter(strNome, i) && !Char.IsWhiteSpace(strNome, i))
                    return false;
            }
            return true;
        }
        public static bool IsEmail(string strEmail)
        {
            string strModelo = "^([0-9a-zA-Z]([-.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
            if (System.Text.RegularExpressions.Regex.IsMatch(strEmail, strModelo))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void Txt_NomeUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label_NomeUsuario_Click(object sender, EventArgs e)
        {

        }

        private void Masked_Telefone_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void Txt_TelefoneUsuario_Click(object sender, EventArgs e)
        {

        }

        private void Txt_EmailUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label_EmailUsuario_Click(object sender, EventArgs e)
        {

        }
    }
}
