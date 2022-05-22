using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public void ApagarDaLista(String Tarefa)
        {
            tarefas.Remove(new List() { Tarefa = Tarefa });
            //Não está mais apagando 
        }
        public void ApagarTodaLista()
        {
            tarefas.Clear();
        }
    }
}
