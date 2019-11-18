using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneTask2
{
    class Program
    {
        static void Main(string[] args)
        {
            //attesa senza timeout
            var myTask = Task.Factory.StartNew(SomeMethod);
            myTask.Wait();

            //attesa con timeout di un secondo
            myTask = Task.Factory.StartNew(SomeMethod);
            myTask.Wait(1000);

            Console.ReadLine();
        }
    }
}
