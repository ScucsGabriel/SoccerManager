using SoccerManager.Controller;
using SoccerManager.View.Sorteios;
using System;
using System.Windows.Forms;

namespace SoccerManager.View.Principal
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void Tsb_Usuarios_Click(object sender, EventArgs e)
        {
            FormUsuario formUsuario = new FormUsuario();
            formUsuario.ShowDialog();
        }

        private void Tsb_Times_Click(object sender, EventArgs e)
        {
            FormTime formTime = new FormTime();
            formTime.ShowDialog();
        }

        private void Tsb_Sorteio_Click(object sender, EventArgs e)
        {
            FormSorteios formSorteio = new FormSorteios();
            formSorteio.ShowDialog();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            PreencherListView_GerarTabelaDiv1();
            PreencherListView_GerarTabelaDiv2();
            LstView_TabelaDiv1.View = System.Windows.Forms.View.Details;
            LstView_TabelaDiv2.View = System.Windows.Forms.View.Details;
        }

        private void PreencherListView_GerarTabelaDiv1()
        {
            LimparFormLista_TabelaDiv1();
            PreencherColumnHeader_GerarTabelaDiv1();

            TabelaDivUmController tabelaDivUm = new TabelaDivUmController();

            foreach (var item in tabelaDivUm.GerarTabelaDiv1())
            {
                ListViewItem listViewItem = new ListViewItem(new[]
                {item.idTabelaDivUmSorteio.ToString(), item.usuario.idUsuario.ToString(),
                  item.usuario.nomeUsuario, item.usuario.emailUsuario,
                    item.time.idTime.ToString(), item.time.time, item.sorteio.divisao.ToString()});
                LstView_TabelaDiv1.Items.Add(listViewItem);
            }
        }

        private void LimparFormLista_TabelaDiv1()
        {
            LstView_TabelaDiv1.Columns.Clear();
            LstView_TabelaDiv1.Items.Clear();
            LstView_TabelaDiv1.FullRowSelect = true;
        }

        private void PreencherColumnHeader_GerarTabelaDiv1()
        {
            ColumnHeader columnHeader1 = new ColumnHeader();
            ColumnHeader columnHeader2 = new ColumnHeader();
            ColumnHeader columnHeader3 = new ColumnHeader();
            ColumnHeader columnHeader4 = new ColumnHeader();
            ColumnHeader columnHeader5 = new ColumnHeader();
            ColumnHeader columnHeader6 = new ColumnHeader();
            ColumnHeader columnHeader7 = new ColumnHeader();

            columnHeader1.Text = "Código Sorteio";
            columnHeader2.Text = "Código Usuário";
            columnHeader3.Text = "Nome Usuário";
            columnHeader4.Text = "E-mail Usuário";
            columnHeader5.Text = "Código Time";
            columnHeader6.Text = "Time";
            columnHeader7.Text = "Divisão";

            LstView_TabelaDiv1.Columns.Add(columnHeader1);
            LstView_TabelaDiv1.Columns.Add(columnHeader2);
            LstView_TabelaDiv1.Columns.Add(columnHeader3);
            LstView_TabelaDiv1.Columns.Add(columnHeader4);
            LstView_TabelaDiv1.Columns.Add(columnHeader5);
            LstView_TabelaDiv1.Columns.Add(columnHeader6);
            LstView_TabelaDiv1.Columns.Add(columnHeader7);

            LstView_TabelaDiv1.GridLines = true;
        }

        private void PreencherListView_GerarTabelaDiv2()
        {
            LimparFormLista_TabelaDiv2();
            PreencherColumnHeader_GerarTabelaDiv2();

            TabelaDivDoisController tabelaDivDois = new TabelaDivDoisController();

            foreach (var item in tabelaDivDois.GerarTabelaDiv2())
            {
                ListViewItem listViewItem = new ListViewItem(new[]
                {item.idTabelaDivDoisSorteio.ToString(), item.usuario.idUsuario.ToString(),
                  item.usuario.nomeUsuario, item.usuario.emailUsuario,
                    item.time.idTime.ToString(), item.time.time, item.sorteio.divisao.ToString()});
                LstView_TabelaDiv2.Items.Add(listViewItem);
            }
        }

        private void LimparFormLista_TabelaDiv2()
        {
            LstView_TabelaDiv2.Columns.Clear();
            LstView_TabelaDiv2.Items.Clear();
            LstView_TabelaDiv2.FullRowSelect = true;
        }

        private void PreencherColumnHeader_GerarTabelaDiv2()
        {
            ColumnHeader columnHeader1 = new ColumnHeader();
            ColumnHeader columnHeader2 = new ColumnHeader();
            ColumnHeader columnHeader3 = new ColumnHeader();
            ColumnHeader columnHeader4 = new ColumnHeader();
            ColumnHeader columnHeader5 = new ColumnHeader();
            ColumnHeader columnHeader6 = new ColumnHeader();
            ColumnHeader columnHeader7 = new ColumnHeader();

            columnHeader1.Text = "Código Sorteio";
            columnHeader2.Text = "Código Usuário";
            columnHeader3.Text = "Nome Usuário";
            columnHeader4.Text = "E-mail Usuário";
            columnHeader5.Text = "Código Time";
            columnHeader6.Text = "Time";
            columnHeader7.Text = "Divisão";

            LstView_TabelaDiv2.Columns.Add(columnHeader1);
            LstView_TabelaDiv2.Columns.Add(columnHeader2);
            LstView_TabelaDiv2.Columns.Add(columnHeader3);
            LstView_TabelaDiv2.Columns.Add(columnHeader4);
            LstView_TabelaDiv2.Columns.Add(columnHeader5);
            LstView_TabelaDiv2.Columns.Add(columnHeader6);
            LstView_TabelaDiv2.Columns.Add(columnHeader7);

            LstView_TabelaDiv2.GridLines = true;
        }

        private void Btn_Atualizar_Click(object sender, EventArgs e)
        {
            PreencherListView_GerarTabelaDiv1();
            PreencherListView_GerarTabelaDiv2();
            LstView_TabelaDiv1.View = System.Windows.Forms.View.Details;
            LstView_TabelaDiv2.View = System.Windows.Forms.View.Details;
        }
    }
}
