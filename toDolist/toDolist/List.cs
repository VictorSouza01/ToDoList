using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace toDolist
{
    internal class List
    {
        private string tarefa;

        public List()
        {
        }
        public List(string tarefa)
        {
            this.Tarefa = tarefa;
        }
        public string Tarefa { get => tarefa; set => tarefa = value; }

        public List<List> tarefas = new List<List>();

        public void AdicionarNaLista(String Tarefa)
        {
            tarefas.Add(new List(){Tarefa = Tarefa});
        }

        public void apagardalista(String tarefaRemove)
        {

            tarefas.RemoveAll(item => item.tarefa == tarefaRemove);

        }


        public void ApagarTodaLista()
        {
            tarefas.Clear();
        }
    }
}
