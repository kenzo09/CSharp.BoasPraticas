using System;

namespace Padrao.Singleton
{
    public static class Singleton1
    {
        public static void Metodo()
        {
            Console.WriteLine("Método");
        }

    }

    public class Singleton2
    {
        private Singleton2() { }

        private static Singleton2 instance;
        public static Singleton2 CriarInstancia()
        {
            if (instance == null)
            {
                instance = new Singleton2();
            }
            return instance;
        }

        public void Metodo()
        {
            Console.WriteLine("Método");
        }
    }

    public class Singleton3
    {
        private static readonly object mutex = new object();
        private static volatile Singleton3 instance;
        private Singleton3() { }

        public static Singleton3 CriarInstancia()
        {
            if (instance == null)
            {
                lock (mutex)
                {
                    if (instance == null)
                    {
                        instance = new Singleton3();
                    }
                }
            }
            return instance;
        }

        public void Metodo()
        {
            Console.WriteLine("Método");
        }
    }

    public class Singleton4
    {
        private static readonly Singleton4 instance = new Singleton4();
        public static Singleton4 Instancia { get { return instance; } }

        static Singleton4() { }
        private Singleton4()
        {
            Console.WriteLine("Passei pelo construtor...");
        }

        public static void Metodo()
        {
            Console.WriteLine("Método");
        }
    }

    public class Singleton5
    {
        private static readonly Lazy<Singleton5> instance = 
            new Lazy<Singleton5>(() => new Singleton5(), true);
        public static Singleton5 Instancia { get { return instance.Value; } }

        static Singleton5() { }
        private Singleton5()
        {
            Console.WriteLine("Passei pelo construtor...");
        }

        public static void Metodo()
        {
            Console.WriteLine("Método");
        }
    }
}
