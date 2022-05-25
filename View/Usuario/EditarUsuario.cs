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
    public partial class FormEditarUsuario : Form
    {
        public FormEditarUsuario(List<Usuario> listaUsuario)
        {
            InitializeComponent();
            foreach (var item in listaUsuario)
            {
                Label_CodigoUsuario.Text = item.idUsuario.ToString();
                Txt_NomeUsuarioEdit.Text = item.nomeUsuario.ToString();
                Txt_EmailUsuarioEdit.Text = item.emailUsuario;
                Masked_TelefoneEdit.Text = item.telefoneUsuario;
            }
        }

        private void Btn_SalvarEditUsuario_Click(object sender, EventArgs e)
        {
            if (!ValidarPreenchimento())
                return;

            string usuarioAtivo = "Sim";
            UsuarioController editarUsuario = new UsuarioController();
            editarUsuario.EditarUsuario(Convert.ToInt32(Label_CodigoUsuario.Text), Txt_NomeUsuarioEdit.Text.Trim(),
                Txt_EmailUsuarioEdit.Text.Trim(), Masked_TelefoneEdit.Text.Trim(), usuarioAtivo);

            MessageBox.Show("Cadastro atualizado com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Limpar();
            this.Close();
        }

        private void Limpar()
        {
            Txt_NomeUsuarioEdit.Text = "";
            Txt_EmailUsuarioEdit.Text = "";
            Masked_TelefoneEdit.Text = "";
        }

        private void Btn_ListarEditUsuario_Click(object sender, EventArgs e)
        {
            FormListarUsuario formListarUsuario = new FormListarUsuario();
            formListarUsuario.Show();
            this.Close();
        }

        private bool ValidarPreenchimento()
        {
            if (Txt_NomeUsuarioEdit.Text == "")
            {
                MessageBox.Show("Nome do usuário está vazio.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (IsNome(Txt_NomeUsuarioEdit.Text) == false)
            {
                MessageBox.Show("Nome do usuário não contém somente letras.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Txt_NomeUsuarioEdit.Text.Length > 50)
            {
                MessageBox.Show("Nome do usuário está muito grande.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Txt_EmailUsuarioEdit.Text == "")
            {
                MessageBox.Show("E-mail está vazio.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (IsEmail(Txt_EmailUsuarioEdit.Text) == false)
            {
                MessageBox.Show("E-mail não está num formato correto.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (Txt_EmailUsuarioEdit.Text.Length > 100)
            {
                MessageBox.Show("E-mail está muito grande.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else if (!Masked_TelefoneEdit.MaskFull)
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
    }
}
