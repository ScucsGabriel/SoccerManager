using Microsoft.Office.Interop.Excel;
using SoccerManager.Controller;
using SoccerManager.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SoccerManager.View.Sorteios
{
    public partial class FormSorteios : Form
    {
        public FormSorteios()
        {
            InitializeComponent();
        }

        private void Btn_GerarSorteio_Click(object sender, EventArgs e)
        {
            GerarSorteio();
        }

        private void GerarSorteio()
        {
            PreencherListView_GerarSorteio();
            LstView_Sorteio.View = System.Windows.Forms.View.Details;
        }

        private void LimparFormLista()
        {
            LstView_Sorteio.Columns.Clear();
            LstView_Sorteio.Items.Clear();
            LstView_Sorteio.FullRowSelect = true;
        }
        private void PreencherColumnHeader_GerarSorteio()
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

            LstView_Sorteio.Columns.Add(columnHeader1);
            LstView_Sorteio.Columns.Add(columnHeader2);
            LstView_Sorteio.Columns.Add(columnHeader3);
            LstView_Sorteio.Columns.Add(columnHeader4);
            LstView_Sorteio.Columns.Add(columnHeader5);
            LstView_Sorteio.Columns.Add(columnHeader6);
            LstView_Sorteio.Columns.Add(columnHeader7);

            LstView_Sorteio.GridLines = true;
        }

        private void PreencherListView_GerarSorteio()
        {
            LimparFormLista();
            PreencherColumnHeader_GerarSorteio();

            SorteioController gerarSorteio = new SorteioController();
            TabelaDivUmController tabelaDivUm = new TabelaDivUmController();
            TabelaDivDoisController tabelaDivDois = new TabelaDivDoisController();
            Random aleatorio = new Random();
            int contador = 0, divisao, contagemDivisao, idTime, contagemTime, idUsuario, contagemUsuario;

            tabelaDivUm.ExcluirTabelaDivUm();
            tabelaDivDois.ExcluirTabelaDivDois();
            gerarSorteio.ExcluirSorteio();

            while (contador < 40)
            {
                do
                {
                    do
                    {
                        do
                        {
                            divisao = aleatorio.Next(1, 3);
                            contagemDivisao = gerarSorteio.ContarSorteioPorDivisao(divisao).contagemDivisao;
                        } while (contagemDivisao >= 20);

                        idTime = aleatorio.Next(1, 41);
                        contagemTime = gerarSorteio.ConsultarSorteioPorTime(idTime).contagemTime;
                    } while (contagemTime > 0);

                    idUsuario = aleatorio.Next(1, 41);
                    contagemUsuario = gerarSorteio.ConsultarSorteioPorUsuario(idUsuario).contagemUsuario;
                    if (contagemDivisao < 20 && contagemTime == 0 && contagemUsuario == 0)
                        gerarSorteio.InserirSorteio(idUsuario, idTime, divisao);
                } while (contagemUsuario > 0);
                contador++;
            }



            foreach (var item in gerarSorteio.ConsultarTodoSorteio())
            {
                ListViewItem listViewItem = new ListViewItem(new[]
                {item.idSorteio.ToString(), item.idSorteioUsuario.ToString(),
                  item.usuario.nomeUsuario, item.usuario.emailUsuario,
                    item.idSorteioTime.ToString(), item.time.time, item.divisao.ToString()});
                LstView_Sorteio.Items.Add(listViewItem);
            }
        }


        private void Btn_SalvarXLS_Click(object sender, EventArgs e)
        {
            if (LstView_Sorteio.Items.Count == 0)
            {
                MessageBox.Show("Necessário gerar dados para salvar em XLS!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                if (!GerarXls_Sorteio())
                    return;
            }
        }

        private bool GerarXls_Sorteio()
        {
            Salvar_XLS.Title = "Salvar Sorteio";
            Salvar_XLS.Filter = "XLS file (*.xlsx)|*.xlsx";
            Salvar_XLS.FileName = "Sorteio - Soccer Manager";
            Salvar_XLS.DefaultExt = ".xlsx";
            Salvar_XLS.InitialDirectory = @"C:\";
            Salvar_XLS.RestoreDirectory = true;
            DialogResult resultado = Salvar_XLS.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
                if (xlApp == null)
                {
                    MessageBox.Show("Excel não está instalado!");
                    return false;
                }
                string caminho = Salvar_XLS.FileName;

                try
                {
                    Microsoft.Office.Interop.Excel.Workbook xlWorkbook = xlApp.Workbooks.Add(XlWBATemplate.xlWBATWorksheet);
                    Microsoft.Office.Interop.Excel.Worksheet xlWorksheet = xlWorkbook.Sheets[1];

                    int row = 1;
                    xlWorksheet.Cells[row, 1] = "Código Sorteio";
                    xlWorksheet.Cells[row, 2] = "Código Usuário";
                    xlWorksheet.Cells[row, 3] = "Nome Usuário";
                    xlWorksheet.Cells[row, 4] = "E-mail Usuário";
                    xlWorksheet.Cells[row, 5] = "Código Time";
                    xlWorksheet.Cells[row, 6] = "Time";
                    xlWorksheet.Cells[row, 7] = "Divisão";

                    xlWorksheet.get_Range("A1", "G1").Font.Bold = true;
                    xlWorksheet.get_Range("A1", "G1").VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;

                    for (int i = 0; i < LstView_Sorteio.Items.Count; i++)
                    {
                        row++;
                        int col = 1;
                        xlWorksheet.Cells[row, col] = LstView_Sorteio.Items[i].SubItems[0].Text;
                        col++;
                        xlWorksheet.Cells[row, col] = LstView_Sorteio.Items[i].SubItems[1].Text;
                        col++;
                        xlWorksheet.Cells[row, col] = LstView_Sorteio.Items[i].SubItems[2].Text;
                        col++;
                        xlWorksheet.Cells[row, col] = LstView_Sorteio.Items[i].SubItems[3].Text;
                        col++;
                        xlWorksheet.Cells[row, col] = LstView_Sorteio.Items[i].SubItems[4].Text;
                        col++;
                        xlWorksheet.Cells[row, col] = LstView_Sorteio.Items[i].SubItems[5].Text;
                        col++;
                        xlWorksheet.Cells[row, col] = LstView_Sorteio.Items[i].SubItems[6].Text;
                        xlWorksheet.get_Range("A" + row, "G" + row).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignLeft;
                                               
                    }

                    xlWorkbook.SaveAs(Salvar_XLS.FileName, XlFileFormat.xlOpenXMLWorkbook);
                    xlWorkbook.Close();

                    DialogResult resposta = MessageBox.Show("Documento salvo! Deseja abrir o documento?", "Informação",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                    if (resposta == DialogResult.Yes)
                        System.Diagnostics.Process.Start(Salvar_XLS.FileName);
                }
                catch (Exception e)
                {
                    MessageBox.Show("O documento anteriormente salvo está aberto ou sendo usado por outro processo!",
                        "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                finally
                {
                    xlApp.Quit();
                }
            }
            else
            {
                MessageBox.Show("Operação cancelada!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

        private void Btn_GravarTabela_Click(object sender, EventArgs e)
        {
            TabelaDivUmController tabelaDivUm = new TabelaDivUmController();            
            SorteioController listarSorteioDivUm = new SorteioController();
            List<Sorteio> sorteiosSelecionadosDivUm = new List<Sorteio>();            

            foreach (var item in listarSorteioDivUm.ContarSorteioDiv1())
            {
                Sorteio sorteio = new Sorteio();
                sorteio.idSorteio = item.idSorteio;

                sorteiosSelecionadosDivUm.Add(sorteio);
            }

            tabelaDivUm.InserirTabelaDivUm(sorteiosSelecionadosDivUm);

            TabelaDivDoisController tabelaDivDois = new TabelaDivDoisController();
            SorteioController listarSorteioDivDois = new SorteioController();
            List<Sorteio> sorteiosSelecionadosDivDois = new List<Sorteio>();

            foreach (var item in listarSorteioDivDois.ContarSorteioDiv2())
            {
                Sorteio sorteio = new Sorteio();
                sorteio.idSorteio = item.idSorteio;

                sorteiosSelecionadosDivDois.Add(sorteio);
            }

            tabelaDivDois.InserirTabelaDivDois(sorteiosSelecionadosDivDois);

            MessageBox.Show("Tabelas incluídas com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
 }
