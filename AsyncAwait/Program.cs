using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncAwait
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kalispera");
            Console.WriteLine(GetData().Result);
            Console.WriteLine("Kalinixta");
        }

        public async static Task<int> GetData()
        {

            Task<int> task = new Task<int>(Repository);
            task.Start();

            int result = await task;

            return  result;
        } 
        
        public static int Repository()
        {
            Thread.Sleep(5000);
            return 2023;
        }

    }
}
