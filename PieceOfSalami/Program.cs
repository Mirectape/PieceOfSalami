using System;
using System.Text;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Collections;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System.Net.Http;

namespace PieceOfSalami
{
    class Program
    {
        static object o = new object();
        static int countMultipleNumers = 0;

        static readonly int lowerBarNumber = 100_000_000;
        static readonly int upperBarNumber = 200_000_000;

        private static void Main(String[] args)
        {
            GetSumOfMultipleNumers();
            Console.WriteLine(countMultipleNumers);
            Console.ReadLine();
        }

        private static void GetSumOfMultipleNumers()
        {
            int tempNumber = lowerBarNumber;
            var tasks = new List<Task>();

            while (tempNumber + 100_000 <= upperBarNumber)
            {
                tasks.Add(Task.Factory.StartNew(GetSumOfMultipleNumersInBetween, tempNumber));
                tempNumber += 100_000;
            }
            tasks.Add(Task.Factory.StartNew(GetSumOfMultipleNumersInBetween, tempNumber));
            Task t = Task.WhenAll(tasks);

            try
            {
                t.Wait();
            }
            catch { }

            if (t.Status == TaskStatus.RanToCompletion)
                Console.WriteLine("All ping attempts succeeded.");
            else if (t.Status == TaskStatus.Faulted)
                Console.WriteLine("Ping attempts failed");
        }

        private static void GetSumOfMultipleNumersInBetween(object tempNumber)
        {
            int totalSumInBetween = 0;

            int lowerNumber = (int)tempNumber;
            if(upperBarNumber - lowerNumber >= 100_000)
            {
                for (int i = lowerNumber; i < lowerNumber + 100_000; i++)
                {
                    var numericValueSplit = new NumericValueSplit<int>(i);
                    if(numericValueSplit.isSumNumbersMultipleToLastNumber())
                    {
                        totalSumInBetween++;
                    }
                }
            }
            else
            {
                for (int i = lowerNumber; i <= upperBarNumber; i++)
                {
                    var numericValueSplit = new NumericValueSplit<int>(i);
                    if (numericValueSplit.isSumNumbersMultipleToLastNumber())
                    {
                        totalSumInBetween++;
                    }
                }
            }

            lock(o)
            {
                countMultipleNumers += totalSumInBetween;
            }
        }
    }
}

//Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MSSQLLocalDemo;Integrated Security=True;Pooling=False


