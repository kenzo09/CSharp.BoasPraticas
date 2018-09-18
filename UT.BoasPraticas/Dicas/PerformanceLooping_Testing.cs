using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace UT.BoasPraticas.Dicas
{
    [TestClass]
    public class PerformanceLooping_UnitTesting
    {
        [TestMethod]
        public void TestMethod_For()
        {
            Console.WriteLine("C# loop for - thread única \n");

            var medirPerformance = System.Diagnostics.Stopwatch.StartNew();
            for (int index = 0; index <= 10; index++)
            {
                Console.WriteLine("index = {0}, thread = {1}",
                    index, Thread.CurrentThread.ManagedThreadId);
                Thread.Sleep(100);
            }
            medirPerformance.Stop();
            GetTempoProcessamento(medirPerformance);
        }

        [TestMethod]
        public void TestMethod_Parallel_For()
        {
            Console.WriteLine("Parallel.For loop - multithread \n");

            var medirPerformance = System.Diagnostics.Stopwatch.StartNew();
            Parallel.For(0, 10, index =>
            {
                Console.WriteLine("index = {0}, thread = {1}", index,
                Thread.CurrentThread.ManagedThreadId);
                Thread.Sleep(100);
            });
            medirPerformance.Stop();
            GetTempoProcessamento(medirPerformance);
        }

        private static void GetTempoProcessamento(System.Diagnostics.Stopwatch medirPerformance)
        {
            TimeSpan ts = medirPerformance.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                ts.Hours, ts.Minutes, ts.Seconds,
                ts.Milliseconds);
            Console.WriteLine("Tempo de processamento: " + elapsedTime);
        }
    }
}
