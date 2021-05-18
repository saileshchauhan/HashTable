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
            MyMapNode<string, int> uc1_Dictionary = new MyMapNode<string, int>(3);
            MyMapNode<string, int> uc2_Dictionary = new MyMapNode<string, int>(9);
            uc1_Dictionary.Word_Frequency("to be or not to be", uc1_Dictionary);
            uc1_Dictionary.Display();
            //UC2
            uc2_Dictionary.Word_Frequency("Paranoids are not paranoid because they are paranoid but" +
                                          "because they keep putting themseleves deliberately into" +
                                          " paranoid avoidable situations", uc2_Dictionary);
            uc2_Dictionary.Display();
            //UC3
            uc2_Dictionary.Remove("avoidable");
            uc2_Dictionary.Display();
            Console.ReadKey();

        }
    }
}
