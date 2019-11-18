using System;
using System.Threading;
using System.Threading.Tasks;

namespace GestioneTask
{
    class Program
    {
        static void Main(string[] args)
        {
            //costruzione di un semplice task
            var simpleTask = Task.Factory.StartNew(() =>
            {
                Thread.Sleep(1000);
                Console.WriteLine("Ciao da simpleTask");
            });

            //costruzione di un task con parametro in input
            var parameterTask = Task.Factory.StartNew((name) =>
            {
                Thread.Sleep(1000);
                Console.WriteLine("Ciao da parameterTask, {0}", name);
            }, "Matteo Tumiati");

            //costruzione di un task che ritorna un risultato
            var resultTask = Task.Factory.StartNew((inputValue) =>
                PerformSomeLongCalculation(inputValue), 5000D);

            //esecuzione
            resultTask.Start();

            //determinazione del risultato
            Console.WriteLine("Il risultato è: {0}", resultTask.Result);

            Console.ReadLine();
        }
    }
}
