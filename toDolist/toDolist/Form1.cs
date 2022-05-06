using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace toDolist
{
    public partial class Janela1 : Form
    {
        List L = new List();
        int contador = 0;
        public Janela1()
        {
            InitializeComponent();
        }
        public void setTxt_item(TextBox txt_item)
        {
            this.txt_item.Text = txt_item.Text;
        }
        public void CriarPasta()
        {
            string folderPath = @"C:\listToDo";
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
                Console.WriteLine(folderPath);
            }
        }
        public void GravarArquivoTXT()
        {
            StreamWriter sw = new StreamWriter("C:\\listToDo\\list.txt");
            foreach (List p in L.tarefas)
            {
                sw.WriteLine(p.item);
            }
            sw.Close();
        }
        public void LerArquivoTXT()
        {
            if (File.Exists("C:\\listToDo\\list.txt"))//Verificando se existe ou não o arquivo
            {
                if (File.Exists("C:\\listToDo\\list.txt"))
                {
                    foreach (string line in System.IO.File.ReadLines(@"C:\\listToDo\\list.txt"))
                    {
                        L.AdicionarNaLista(line);
                        ListarElementos();
                        Console.ReadLine();
                    }
                }
            }
        }
        public void AdicionarNaLista()
        {
            if (txt_item.Text != "")
            {
                //Fazer verificação se o item já está na lista ou não... Um for eu acho que resolve

                String text = txt_item.Text;
                L.AdicionarNaLista(text);
                txt_item.Text = "";
                ListarElementos();
            }
            else
            {
                MessageBox.Show("Escreva algo para adicionar na lista");
            }
        }
        public void ListarElementos()
        {
            data_grid_view_result.Rows.Clear();
            int i = 0;
            foreach (List p in L.tarefas)
            {
                data_grid_view_result.Rows.Add(i, p.item);
                i++;
            }
            
            txt_qtd_tarefas.Text = "N°" + i;

            //aqui é o text
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                AdicionarNaLista();
                GravarArquivoTXT();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao adicionar uma nova tarefa\n\n\n" +
                    "Código do erro: \n\n\n" +
                    ex.Message);
            }
            finally
            {
                txt_item.Text = "";
            }
        }
        private void txt_item_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) //Codigo para adicionar ao pressionar o ENTER
            {
                try
                {
                    AdicionarNaLista();
                    GravarArquivoTXT();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao adicionar uma nova tarefa\n\n\n" +
                        "Código do erro: \n\n\n" +
                        ex.Message);
                }
                finally
                {
                    txt_item.Text = "";
                }
            }
        }
        public void Excluir(int text)
        {
            if (MessageBox.Show("Deseja realmente apagar esta tarefa?", "ATENÇÃO!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                L.ApagarDaLista(text);
                ListarElementos();
            }
        }


        private void data_grid_view_result_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == data_grid_view_result.Columns["btn_excluir"].Index)
                {
                    int text = (int)data_grid_view_result.CurrentRow.Cells[0].Value; //recebendo o valor da coluna 0 na linha atual do clique para poder usar no metodo de apagar
                    Excluir(text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir o item da lista" +
                    "!!" +
                    "\n\n\n Erro: " + ex.Message);
            }

            try
            {
                String copia = Convert.ToString(data_grid_view_result.CurrentRow.Cells[0].Value);
                if (e.ColumnIndex == data_grid_view_result.Columns["selecao"].Index)
                {
                    data_grid_view_result.EndEdit();
                    String valor = data_grid_view_result.Rows[e.RowIndex].Cells[3].Value.ToString();
                    if (valor == "True")
                    {
                        data_grid_view_result.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                        data_grid_view_result.Update();
                        data_grid_view_result.Select();
                        data_grid_view_result.CurrentRow.DefaultCellStyle.BackColor = Color.Yellow;
                        btn_excluir_selecao.Visible = true;
                        contador++;
                    }
                    else if (valor == "False")
                    {
                        data_grid_view_result.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                        data_grid_view_result.Update();
                        data_grid_view_result.Select();
                        data_grid_view_result.CurrentRow.DefaultCellStyle.BackColor = Color.White;
                        contador--; 
                        if (contador == 0)
                        {
                            btn_excluir_selecao.Visible = false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao marcar como concluído" +
                    "!!" +
                    "\n\n\n Erro: " + ex.Message);
            }
        }
        private void btn_excluir_selecao_Click(object sender, EventArgs e)
        {
            //Aqui vai o codigo para excluir todos os selecionados
        }
        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                GravarArquivoTXT();
                MessageBox.Show("Lista salva com sucesso!", "Sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar a lista" +
                    "!!" +
                    "\n\n\n Erro: " + ex.Message);
            }
        }
        private void Janela1_Load_1(object sender, EventArgs e)
        {
            try
            {
                CriarPasta();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao criar a pasta\n\n\n" +
                "Código do erro: \n\n\n" +
                ex.Message);
            }
            try
            {
                LerArquivoTXT();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar arquivo\n\n\n" +
                "Código do erro: \n\n\n" +
                ex.Message);
            }
        }
        private void btn_excluir_lista_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Esta opção irá apagar todas as tarefas!!\n\n" +
                    "Deseja realmente apagar todas as tarefas?", "ATENÇÃO!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    L.ApagarTodaLista();
                    ListarElementos();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro ao apagar as tarefas\n\n\n" +
                "Código do erro: \n\n\n" +
                ex.Message);
            }
        }
    }
}
