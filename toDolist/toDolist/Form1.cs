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

        Queue<string> Numberscopy = new Queue<string>();
        /*
        Criando uma fila para armazenar os valores temporarios dos numeros que serao excluidos
        de uma vez da lista principal
        */

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
        public void Excluir(String Tarefa)
        {
            //Erro ao apagar, pois ele não apaga
            L.ApagarDaLista(Tarefa);
            ListarElementos();
        }
        public void GravarArquivoTXT()
        {
            StreamWriter sw = new StreamWriter("C:\\listToDo\\list.txt");
            foreach (List p in L.tarefas)
            {
                sw.WriteLine(p.Tarefa);
            }
            sw.Close();
            VerificaContadorDoBTN(contador);
        }
        public void LerArquivoTXT()
        {
            if (File.Exists("C:\\listToDo\\list.txt"))//Verificando se existe ou não o arquivo
            {
                if (File.Exists("C:\\listToDo\\list.txt"))
                {
                    foreach (string line in System.IO.File.ReadLines(@"C:\\listToDo\\list.txt"))
                    {//Tem q corrigir, mudar para json 
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
                String Tarefa = txt_item.Text;
                L.AdicionarNaLista(Tarefa);
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
                data_grid_view_result.Rows.Add(i, p.Tarefa);
                i++;
            }
            txt_qtd_tarefas.Text = "N°" + i;
        }
        public void VerificaContadorDoBTN(int contador)
        {
            if (contador == 0)
            {
                btn_excluir_selecao.Visible = false;
            }
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
        private void data_grid_view_result_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == data_grid_view_result.Columns["btn_excluir"].Index)
                {
                    if (MessageBox.Show("Deseja realmente apagar esta tarefa?", "ATENÇÃO!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        String Tarefa = (String)data_grid_view_result.CurrentRow.Cells[1].Value; 
                        Excluir(Tarefa);
                    }
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
                if (e.ColumnIndex == data_grid_view_result.Columns["selecao"].Index)
                {
                    String copia = Convert.ToString(data_grid_view_result.CurrentRow.Cells[1].Value);
                    data_grid_view_result.EndEdit();
                    String valor = data_grid_view_result.Rows[e.RowIndex].Cells[3].Value.ToString();
                    if (valor == "True")
                    {
                        data_grid_view_result.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                        data_grid_view_result.Update();
                        data_grid_view_result.Select();
                        data_grid_view_result.CurrentRow.DefaultCellStyle.BackColor = Color.Yellow;
                        btn_excluir_selecao.Visible = true;
                        Numberscopy.Enqueue(copia);//Adiciona o valor que foi selecionado na fila, para que
                        //possa ser removido ou não, caso ele não seja mais selecionado
                        contador++;
                    }
                    else if (valor == "False")
                    {
                        data_grid_view_result.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                        data_grid_view_result.Update();
                        data_grid_view_result.Select();
                        data_grid_view_result.CurrentRow.DefaultCellStyle.BackColor = Color.White;
                        Numberscopy.Dequeue();//remove o valor da queue
                        contador--;
                        VerificaContadorDoBTN(contador);
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
            try
            {
                if (MessageBox.Show("Deseja realmente apagar estas tarefas?", "ATENÇÃO!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    foreach (string number in Numberscopy)
                    {
                        Excluir(number);
                        MessageBox.Show(number);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro ao apagar seleção!" +
                "!!" +
                "\n\n\n Erro: " + ex.Message);
            }
            finally
            {
                VerificaContadorDoBTN(contador);
            }
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
