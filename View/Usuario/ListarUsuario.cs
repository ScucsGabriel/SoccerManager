using SoccerManager.Controller;
using SoccerManager.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SoccerManager
{
    public partial class FormListarUsuario : Form
    {
        public FormListarUsuario()
        {
            InitializeComponent();
        }

        private void Btn_VoltarCadUsu_Click(object sender, EventArgs e)
        {
            FormUsuario formUsuario = new FormUsuario();
            this.Hide();
            this.Close();
            formUsuario.ShowDialog();
        }
        private void BuscarTodosUsuarios()
        {
            Txt_UsuarioBusca.Text = "";
            Txt_EmailBusca.Text = "";
            LimparFormLista();
            PreencherColumnHeader();
            PreencherListView_TodosUsuarios();
            LstView_ListaUsuario.View = System.Windows.Forms.View.Details;
        }
        private void BuscarPorNomeUsuario(string nomeUsuario)
        {
            LimparFormLista();
            PreencherColumnHeader();
            PreencherListView_NomeUsuario(nomeUsuario);
            LstView_ListaUsuario.View = System.Windows.Forms.View.Details;
        }

        private void BuscarPorEmail(string emailUsuario)
        {
            LimparFormLista();
            PreencherColumnHeader();
            PreencherListView_Email(emailUsuario);
            LstView_ListaUsuario.View = System.Windows.Forms.View.Details;
        }
        private void FormListarUsuario_Load(object sender, EventArgs e)
        {
            LimparFormLista();
            LstView_ListaUsuario.FullRowSelect = true;
        }

        private void PreencherColumnHeader()
        {
            ColumnHeader columnHeader1 = new ColumnHeader();
            ColumnHeader columnHeader2 = new ColumnHeader();
            ColumnHeader columnHeader3 = new ColumnHeader();
            ColumnHeader columnHeader4 = new ColumnHeader();

            columnHeader1.Text = "Código";
            columnHeader2.Text = "Nome do Usuário";
            columnHeader3.Text = "E-mail";
            columnHeader4.Text = "Telefone";

            LstView_ListaUsuario.Columns.Add(columnHeader1);
            LstView_ListaUsuario.Columns.Add(columnHeader2);
            LstView_ListaUsuario.Columns.Add(columnHeader3);
            LstView_ListaUsuario.Columns.Add(columnHeader4);

            LstView_ListaUsuario.GridLines = true;
        }

        private void PreencherListView_TodosUsuarios()
        {
            LimparFormLista();
            PreencherColumnHeader();
            UsuarioController listarUsuario = new UsuarioController();
            int resultadoBusca = listarUsuario.ConsultarTodoUsuarioAtivo().Count;

            if (resultadoBusca == 0)
                MessageBox.Show("Não há registros para este usuário!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                foreach (var item in listarUsuario.ConsultarTodoUsuarioAtivo())
                {
                    ListViewItem listViewItem = new ListViewItem(new[]
                    {item.idUsuario.ToString(), item.nomeUsuario.ToString(), item.emailUsuario.ToString(),
                item.telefoneUsuario.ToString()});
                    LstView_ListaUsuario.Items.Add(listViewItem);
                    Label_CalculaQuantidadeUsu.Text = Convert.ToString(LstView_ListaUsuario.Items.Count);
                }
            }
        }

        private void PreencherListView_NomeUsuario(string nomeUsuario)
        {
            LimparFormLista();
            PreencherColumnHeader();
            UsuarioController listarUsuario = new UsuarioController();
            int resultadoBusca = listarUsuario.ConsultarUsuarioPorNome(nomeUsuario).Count;

            if (resultadoBusca == 0)
                MessageBox.Show("Não há registros para este usuário!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                foreach (var item in listarUsuario.ConsultarUsuarioPorNome(nomeUsuario))
                {
                    ListViewItem listViewItem = new ListViewItem(new[]
                    {item.idUsuario.ToString(), item.nomeUsuario.ToString(), item.emailUsuario.ToString(),
                item.telefoneUsuario.ToString()});
                    LstView_ListaUsuario.Items.Add(listViewItem);
                    Label_CalculaQuantidadeUsu.Text = Convert.ToString(LstView_ListaUsuario.Items.Count);
                }
            }
        }

        private void PreencherListView_Email(string emailUsuario)
        {
            LimparFormLista();
            PreencherColumnHeader();
            UsuarioController listarEmail = new UsuarioController();
            int resultadoBusca = listarEmail.ConsultarUsuarioPorEmail(emailUsuario).Count;

            if (resultadoBusca == 0)
                MessageBox.Show("Não há registros para este cachorro!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                foreach (var item in listarEmail.ConsultarUsuarioPorEmail(emailUsuario))
                {
                    ListViewItem listViewItem = new ListViewItem(new[]
                    {item.idUsuario.ToString(), item.nomeUsuario.ToString(), item.emailUsuario.ToString(),
                item.telefoneUsuario.ToString()});
                    LstView_ListaUsuario.Items.Add(listViewItem);
                    Label_CalculaQuantidadeUsu.Text = Convert.ToString(LstView_ListaUsuario.Items.Count);
                }
            }
        }
        private void Btn_BuscarTodosUsuarios_Click(object sender, EventArgs e)
        {
            BuscarTodosUsuarios();
        }
        private void Btn_BuscarPorUsuario_Click(object sender, EventArgs e)
        {
            Txt_EmailBusca.Text = "";
            if (Txt_UsuarioBusca.Text == "")
            {
                MessageBox.Show("Digite o nome do usuário.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (IsNome(Txt_UsuarioBusca.Text) == false)
            {
                MessageBox.Show("Nome do usuário não contém somente letras.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (Txt_UsuarioBusca.Text.Length > 50)
            {
                MessageBox.Show("Nome do usuário está muito grande.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            BuscarPorNomeUsuario(Txt_UsuarioBusca.Text);
        }

        private void Btn_BuscarPorEmail_Click(object sender, EventArgs e)
        {
            Txt_UsuarioBusca.Text = "";
            if (Txt_EmailBusca.Text == "")
            {
                MessageBox.Show("Digite o e-mail.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (IsEmail(Txt_EmailBusca.Text) == false)
            {
                MessageBox.Show("E-mail não está no formato correto.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (Txt_EmailBusca.Text.Length > 100)
            {
                MessageBox.Show("E-mail está muito grande.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            BuscarPorEmail(Txt_EmailBusca.Text);
        }

        private void Btn_ExcluirUsuario_Click(object sender, EventArgs e)
        {
            if (LstView_ListaUsuario.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecione um registro!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (LstView_ListaUsuario.SelectedItems.Count > 1)
            {
                MessageBox.Show("Selecione apenas um registro!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else if (MessageBox.Show("Você irá excluir o registro permanentemente!", "Deseja continuar?",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                //PedidoController listarPedido = new PedidoController();
                //int idCli = Convert.ToInt32(LstView_ListaUsuario.SelectedItems[0].SubItems[0].Text);
                //if (listarPedido.ConsultarPedidoPorUsuarioExclusao(idCli).Count >= 1)
                //{
                //    MessageBox.Show("Não é possível deletar este Usuario, pois ele possui um ou mais pedidos cadastrados. Exclua o pedido para este Usuario primeiro.",
                //        "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    return;
                //}
                if (MessageBox.Show("Confirma a exclusão?", "",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    UsuarioController listarUsuario = new UsuarioController();
                    int idUsuario = Convert.ToInt32(LstView_ListaUsuario.SelectedItems[0].SubItems[0].Text);
                    listarUsuario.ExcluirUsuario(idUsuario);
                    MessageBox.Show("Registro deletado!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    for (int i = LstView_ListaUsuario.SelectedItems.Count - 1; i >= 0; i--)
                    {
                        ListViewItem lstRemove = LstView_ListaUsuario.SelectedItems[i];
                        LstView_ListaUsuario.Items.Remove(lstRemove);
                    }
                    LstView_ListaUsuario.Refresh();

                    Label_CalculaQuantidadeUsu.Text = Convert.ToString(LstView_ListaUsuario.Items.Count);
                }
            }

            else
                return;
        }

        private void LimparFormLista()
        {
            LstView_ListaUsuario.Columns.Clear();
            LstView_ListaUsuario.Items.Clear();
        }

        private void Btn_EditarUsuario_Click(object sender, EventArgs e)
        {
            if (LstView_ListaUsuario.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecione um registro!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (LstView_ListaUsuario.SelectedItems.Count > 1)
            {
                MessageBox.Show("Selecione apenas um registro!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            UsuarioController listarUsuario = new UsuarioController();
            List<Usuario> usuariosSelecionados = new List<Usuario>();
            int idUsuario = Convert.ToInt32(LstView_ListaUsuario.SelectedItems[0].SubItems[0].Text);
            foreach (var item in listarUsuario.ConsultarUsuarioPorId(idUsuario))
            {
                Usuario usuario = new Usuario();
                usuario.idUsuario = item.idUsuario;
                usuario.nomeUsuario = item.nomeUsuario;
                usuario.emailUsuario = item.emailUsuario;
                usuario.telefoneUsuario = item.telefoneUsuario;
                usuario.usuarioAtivo = item.usuarioAtivo;

                usuariosSelecionados.Add(usuario);
            }

            FormEditarUsuario formEditarUsuario = new FormEditarUsuario(usuariosSelecionados);
            formEditarUsuario.ShowDialog();

            if (Txt_UsuarioBusca.Text != "")
                PreencherListView_NomeUsuario(Txt_UsuarioBusca.Text);
            else
                PreencherListView_Email(Txt_EmailBusca.Text);
        }

        public static bool IsNome(string strNome)
        {
            for (int i = 0; i < strNome.Length; i++)
            {
                if (!Char.IsLetter(strNome, i))
                    return false;
            }
            return true;
        }

        private void LstView_ListaUsuario_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Delete && LstView_ListaUsuario.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecione um registro!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (e.KeyCode == Keys.Delete && LstView_ListaUsuario.SelectedItems.Count > 1)
            {
                MessageBox.Show("Selecione apenas um registro!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else if (e.KeyCode == Keys.Delete && MessageBox.Show("Você irá excluir o registro permanentemente!", "Deseja continuar?",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                //PedidoController listarPedido = new PedidoController();
                //int idCli = Convert.ToInt32(LstView_ListaUsuario.SelectedItems[0].SubItems[0].Text);
                //if (listarPedido.ConsultarPedidoPorUsuarioExclusao(idCli).Count >= 1)
                //{
                //    MessageBox.Show("Não é possível deletar este Usuario, pois ele possui um ou mais pedidos cadastrados. Exclua o pedido para este Usuario primeiro.",
                //        "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    return;
                //}
                if (MessageBox.Show("Confirma a exclusão?", "",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    UsuarioController listarUsuario = new UsuarioController();
                    int idUsuario = Convert.ToInt32(LstView_ListaUsuario.SelectedItems[0].SubItems[0].Text);
                    listarUsuario.ExcluirUsuario(idUsuario);
                    MessageBox.Show("Registro deletado!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    for (int i = LstView_ListaUsuario.SelectedItems.Count - 1; i >= 0; i--)
                    {
                        ListViewItem lstRemove = LstView_ListaUsuario.SelectedItems[i];
                        LstView_ListaUsuario.Items.Remove(lstRemove);
                    }
                    LstView_ListaUsuario.Refresh();

                    Label_CalculaQuantidadeUsu.Text = Convert.ToString(LstView_ListaUsuario.Items.Count);
                }
            }

            else
                return;
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
