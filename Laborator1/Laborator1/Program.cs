using System;
using System.Collections.Generic;
using System.Threading;
namespace Laborator1
{
    class Program
    {
        public static bool IsPrime(long number)
        {
            if (number < 2)
                return false;
            if (number == 2)
                return true;
            for (long div = 2; div <= number / 2; div++)
                if (number % div == 0)
                    return false;
            return true;

        }

        public static long BiggestPrime(long number)
        {
            long primeNum = number - 1;
            while (primeNum >= 2)
            {
                if (IsPrime(primeNum))
                {
                    return primeNum;
                }
                primeNum--;
            }
            return primeNum;
        }
        public static void ExecuteThread(object arg)
        {
            Args args = (Args)arg;
            args.messages.Add("Start fir: " + args.ThreadName + " " + DateTime.Now + " Numar natural dat = " + args.number);
            bool threadDone = false;
            while (!threadDone)
            {
                try
                {
                    long num = BiggestPrime(args.number);
                    args.messages.Add("End fir: " + args.ThreadName + " " + DateTime.Now + "Numar prim = " + num);
                    threadDone = true;
                }
                catch (ThreadInterruptedException)
                {
                    args.messages.Add("Iesire temporara fir: " + args.ThreadName + " " + DateTime.Now);
                }
            }
        }
        static void Main(string[] args)
        {
            List<String> messages = new List<String>();
            Args a1 = new Args("t1", 4000000000, messages);
            Args a2 = new Args("t2", 2000000000, messages);
            Thread t1 = new Thread(ExecuteThread);
            Thread t2 = new Thread(ExecuteThread);
            t1.Start(a1);
            t2.Start(a2);
            t1.Join();
            t2.Join();
            foreach (string message in messages)
            {
                Console.WriteLine(message);
            }
            /* var crypt = new EventProducer();
             var print = new EventSubscriber();
             crypt.Encrypted += print.PrintEncryptedText;
             Console.WriteLine(crypt.Substract("anvz"));*/
        }
    }
}
