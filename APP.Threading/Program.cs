using System;
using System.Threading;

namespace APP.Threading
{
    class Program
    {
        static int interval;

        static void Main(string[] args)
        {
            Console.WriteLine("Intervalo para exibir os resultados?");
            interval = int.Parse(Console.ReadLine());

            Thread ThreadPrincipal = Thread.CurrentThread;
            ThreadPrincipal.Name = "Thread Principal";

            ThreadStart ThreadWorker = new ThreadStart(Initializacao);
            Thread newThreading = new Thread(ThreadWorker);
            newThreading.Name = "Trabalhadora com prioridade";
            newThreading.Priority = ThreadPriority.Highest;
            newThreading.Start();

            ThreadStart ThreadWorker2 = new ThreadStart(Initializacao);
            Thread newThreading2 = new Thread(ThreadWorker2);
            newThreading2.Name = "Trabalhadora sem prioridade";
            newThreading2.Priority = ThreadPriority.Lowest;
            newThreading2.Start();

            GetResultado();
            Console.ReadLine();
        }

        static void Initializacao()
        {
            GetResultado();
        }

        static void GetResultado()
        {
            Thread ProcessoEmAndamento = Thread.CurrentThread;
            string name = ProcessoEmAndamento.Name;

            Console.WriteLine("Iniciando thread: " + name);

            for (int i = 1; i < 2000 * interval; i++)
            {
                if (i % interval == 0)
                    Console.WriteLine(name + ": contagem alcançou " + i);
            }
            Console.WriteLine($"Terminou: {ProcessoEmAndamento.Name}");
        }
    }
}
