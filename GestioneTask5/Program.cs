using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneTask5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Task> TaskList = GetTaskList();

            //task da eseguire al termine di tutti quelli contenuti in taskList
            var finalTask = Task.Factory.ContinueWhenAll(TaskList.ToArray(),
                (tl) => Console.WriteLine("Tutti i task completati con successo"));

            Console.ReadLine();
        }
    }
}
