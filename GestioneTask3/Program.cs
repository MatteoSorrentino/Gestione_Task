using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneTask3
{
    class Program
    {
        static void Main(string[] args)
        {
            var problematicTask = Task.Factory.StartNew(() =>
            {
                throw new ApplicationException("Errore");
            });

            try
            {
                problematicTask.Wait();
            }
            catch(AggregateException ex)
            {
                Console.WriteLine("Il task ha sollevato la seguente eccezione:");
                Console.WriteLine(ex.InnerException);
            }

            Console.ReadLine();
        }
    }
}
