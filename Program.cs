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
            hash.Add("0", "paranoids");
            hash.Add("1", "are");
            hash.Add("2", "not");
            hash.Add("3", "paranoids");
            hash.Add("4", "because");
            hash.Add("5", "they");
            hash.Add("6", "are");
            hash.Add("7", "paranoids");
            hash.Add("8", "but");
            hash.Add("9", "because");
            hash.Add("10", "they");
            hash.Add("11", "keep");
            hash.Add("12", "putting");
            hash.Add("13", "themselves");
            hash.Add("14", "deliberately");
            hash.Add("15", "into");
            hash.Add("16", "paranoids");
            hash.Add("17", "avoidable");
            hash.Add("18", "situations");
            hash.Display();
            hash.Remove("17");
            Console.ReadKey();
        }
    }
}
