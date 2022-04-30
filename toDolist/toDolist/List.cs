using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace toDolist
{
    internal class List
    {
        public string item { get; set; }
        public string recebe { get; set; }

        public List(string item)
        {
            this.item = item;
        }

        public List()
        {
        }

        public List<List> tarefas = new List<List>();

        public void AdicionarNaLista(String text)
        {
            tarefas.Add(new List(text));
        }
        public void ApagarDaLista(int text)
        {
            tarefas.RemoveAt(text);
        }
    }
}
