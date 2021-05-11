using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HasTable
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Hash table"); 
            MyMapNode<string, string> hash = new MyMapNode<string, string>(18);
            hash.Add("0", "To");
            hash.Add("1", "be");
            hash.Add("2", "or");
            hash.Add("3", "not");
            hash.Add("4", "to");
            hash.Add("5", "be");
            string word_At_5th_Key = hash.Get("5");
            Console.WriteLine("5th index value: " + word_At_5th_Key);
            string word_At_2nd_Key = hash.Get("2");
            Console.WriteLine("2th index value: " + word_At_2nd_Key);
            Console.ReadKey();
        }
    }
}
