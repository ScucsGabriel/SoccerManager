using SoccerManager.Controller;
using SoccerManager.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace SoccerManager
{
    public partial class FormListarTime : Form
    {
        public FormListarTime()
        {
            InitializeComponent();
        }

        private void Btn_VoltarCadTime_Click(object sender, EventArgs e)
        {
            FormTime formTime = new FormTime();
            this.Hide();
            this.Close();
            formTime.ShowDialog();

        }
        private void BuscarPorTime(string time)
        {
            LimparFormLista();
            PreencherColumnHeader();
            PreencherListView_Time(time);
            LstView_ListaTime.View = System.Windows.Forms.View.Details;
        }
        private void FormListarTime_Load(object sender, EventArgs e)
        {
            LimparFormLista();
            LstView_ListaTime.FullRowSelect = true;
        }

        private void PreencherColumnHeader()
        {
            ColumnHeader columnHeader1 = new ColumnHeader();
            ColumnHeader columnHeader2 = new ColumnHeader();

            columnHeader1.Text = "Código";
            columnHeader2.Text = "Time";

            LstView_ListaTime.Columns.Add(columnHeader1);
            LstView_ListaTime.Columns.Add(columnHeader2);


            LstView_ListaTime.GridLines = true;
        }

        private void PreencherListView_Time(string time)
        {
            LimparFormLista();
            PreencherColumnHeader();
            TimeController listarTime = new TimeController();
            int resultadoBusca = listarTime.ConsultarTime(time).Count;

            if (resultadoBusca == 0)
                MessageBox.Show("Não há registros para este time!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                foreach (var item in listarTime.ConsultarTime(time))
                {
                    ListViewItem listViewItem = new ListViewItem(new[]
                    {item.idTime.ToString(), item.time.ToString()});
                    LstView_ListaTime.Items.Add(listViewItem);
                    Label_CalculaQuantidadeTime.Text = Convert.ToString(LstView_ListaTime.Items.Count);
                }
            }
        }
        private void Btn_BuscarPorTime_Click(object sender, EventArgs e)
        {
            if (Txt_TimeBusca.Text == "")
            {
                MessageBox.Show("Digite o time!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (Txt_TimeBusca.Text.Length > 50)
            {
                MessageBox.Show("Time está muito grande.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            BuscarPorTime(Txt_TimeBusca.Text);
        }
        private void Btn_ExcluirTime_Click(object sender, EventArgs e)
        {
            if (LstView_ListaTime.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecione um registro!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (LstView_ListaTime.SelectedItems.Count > 1)
            {
                MessageBox.Show("Selecione apenas um registro!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else if (MessageBox.Show("Você irá excluir o registro permanentemente!", "Deseja continuar?",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                //PedidoController listarPedido = new PedidoController();
                //int idProd = Convert.ToInt32(LstView_ListaProduto.SelectedItems[0].SubItems[0].Text);
                //if (listarPedido.ConsultarPedidoPorProdutoExclusao(idProd).Count >= 1)
                //{
                //    MessageBox.Show("Não é possível deletar este produto, pois ele possui um ou mais pedidos cadastrados. Exclua o pedido para este produto primeiro.",
                //        "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    return;
                //}
                if (MessageBox.Show("Confirma a exclusão?", "",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    TimeController listarTime = new TimeController();
                    int idTime = Convert.ToInt32(LstView_ListaTime.SelectedItems[0].SubItems[0].Text);
                    listarTime.ExcluirTime(idTime);
                    MessageBox.Show("Registro deletado!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    for (int i = LstView_ListaTime.SelectedItems.Count - 1; i >= 0; i--)
                    {
                        ListViewItem lstRemove = LstView_ListaTime.SelectedItems[i];
                        LstView_ListaTime.Items.Remove(lstRemove);
                    }
                    LstView_ListaTime.Refresh();

                    Label_CalculaQuantidadeTime.Text = Convert.ToString(LstView_ListaTime.Items.Count);
                }
            }

            else
                return;
        }
        private void LimparFormLista()
        {
            LstView_ListaTime.Columns.Clear();
            LstView_ListaTime.Items.Clear();
        }
        private void Btn_EditarTime_Click(object sender, EventArgs e)
        {
            if (LstView_ListaTime.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecione um registro!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (LstView_ListaTime.SelectedItems.Count > 1)
            {
                MessageBox.Show("Selecione apenas um registro!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            TimeController listarTime = new TimeController();
            List<Time> timesSelecionados = new List<Time>();
            int idTime = Convert.ToInt32(LstView_ListaTime.SelectedItems[0].SubItems[0].Text);
            foreach (var item in listarTime.ConsultarTimePorId(idTime))
            {
                Time time = new Time();
                time.idTime = item.idTime;
                time.time = item.time;
                time.timeAtivo = item.timeAtivo;

                timesSelecionados.Add(time);
            }

            FormEditarTime formEditarTime = new FormEditarTime(timesSelecionados);
            formEditarTime.ShowDialog();

            if (Txt_TimeBusca.Text != "")
                PreencherListView_Time(Txt_TimeBusca.Text);
            else
                PreencherListView_Todos();
        }
        private void LstView_ListaProduto_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && LstView_ListaTime.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecione um registro!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (e.KeyCode == Keys.Delete && LstView_ListaTime.SelectedItems.Count > 1)
            {
                MessageBox.Show("Selecione apenas um registro!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else if (e.KeyCode == Keys.Delete && MessageBox.Show("Você irá excluir o registro permanentemente!", "Deseja continuar?",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                //PedidoController listarPedido = new PedidoController();
                //int idProd = Convert.ToInt32(LstView_ListaProduto.SelectedItems[0].SubItems[0].Text);
                //if (listarPedido.ConsultarPedidoPorProdutoExclusao(idProd).Count >= 1)
                //{
                //    MessageBox.Show("Não é possível deletar este produto, pois ele possui um ou mais pedidos cadastrados. Exclua o pedido para este produto primeiro.",
                //        "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    return;
                //}
                if (MessageBox.Show("Confirma a exclusão?", "",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    TimeController listarTime = new TimeController();
                    int idTime = Convert.ToInt32(LstView_ListaTime.SelectedItems[0].SubItems[0].Text);
                    listarTime.ExcluirTime(idTime);
                    MessageBox.Show("Registro deletado!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    for (int i = LstView_ListaTime.SelectedItems.Count - 1; i >= 0; i--)
                    {
                        ListViewItem lstRemove = LstView_ListaTime.SelectedItems[i];
                        LstView_ListaTime.Items.Remove(lstRemove);
                    }
                    LstView_ListaTime.Refresh();

                    Label_CalculaQuantidadeTime.Text = Convert.ToString(LstView_ListaTime.Items.Count);
                }
            }

            else
                return;
        }

        private void Btn_BuscarTodos_Click(object sender, EventArgs e)
        {
            BuscarTodos();
        }

        private void BuscarTodos()
        {
            Txt_TimeBusca.Text = "";
            LimparFormLista();
            PreencherColumnHeader();
            PreencherListView_Todos();
            LstView_ListaTime.View = System.Windows.Forms.View.Details;
        }

        private void PreencherListView_Todos()
        {
            LimparFormLista();
            PreencherColumnHeader();
            TimeController listarTime = new TimeController();
            int resultadoBusca = listarTime.ConsultarTodoTime().Count;

            if (resultadoBusca == 0)
                MessageBox.Show("Não há registros para este time!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                foreach (var item in listarTime.ConsultarTodoTime())
                {
                    ListViewItem listViewItem = new ListViewItem(new[]
                    {item.idTime.ToString(), item.time.ToString()});
                    LstView_ListaTime.Items.Add(listViewItem);
                    Label_CalculaQuantidadeTime.Text = Convert.ToString(LstView_ListaTime.Items.Count);
                }
            }
        }
    }
}
