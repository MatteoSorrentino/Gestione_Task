using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GestioneTask4
{
    class Program
    {
        static void Main(string[] args)
        {
            var compositeTask = Task.Factory.StartNew(() =>
            {
                Thread.Sleep(1000);
                Console.WriteLine("Primo task");
            }).ContinueWith((task) =>
            {
                Thread.Sleep(1000);
                Console.WriteLine("Secondo task");
            });

            //accodamento di una funzione
            var resultTask = compositeTask.ContinueWith((task) =>
            {
                string result = "Funzione del terzo task";
                Console.WriteLine(result);
                return result;
            });

            Console.WriteLine("Il risultato è: {0}", resultTask.Result);

            Console.ReadLine();
        }
    }
}
