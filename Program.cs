using System;
using System.ComponentModel.Design;
using System.Dynamic;
using System.Net.Mime;
using System.Runtime.InteropServices.ComTypes;
using System.Threading.Tasks.Dataflow;

namespace Indexers
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var book = new Books();

            Console.WriteLine(book[3]);

            book[3] = "we changed item";

            Console.WriteLine(book[3]);

            var getItemByValue = book["we changed item"];

            Console.WriteLine(getItemByValue);
            
            Console.ReadKey();

        }
    }
}