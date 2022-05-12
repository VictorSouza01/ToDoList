using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace toDolist
{
    internal class List
    {
        public List()
        {
        }

        public List<String> tarefas = new List<String>();

        public void AdicionarNaLista(String text)
        {
            tarefas.Add(text);
        }
        public void ApagarDaLista(String text)
        {
            tarefas.Remove(text);
        }
        public void ApagarTodaLista()
        {
            tarefas.Clear();
        }
    }
}
