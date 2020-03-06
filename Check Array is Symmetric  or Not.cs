using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Check_Array_is_Symmetric__or_Not
{
    class Program
    {
        static void Main(string[] args)
        {
            //input Size or Array
            Console.Write("Enter Array Size : ");
            int ArraySize = int.Parse(Console.ReadLine());
            //input Array Elements
            Console.WriteLine("Enter Array Elements :");
            int[] array = new int[ArraySize];
            for(int i=0;i<array.Length;i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            //Check Array Is Symmetric or Not
            bool Symmetric = false;
            for(int i=0; i<array.Length/2; i++)
            {
                if (array[i] == array[array.Length -i- 1])
                {
                    Symmetric = true;
                }
            }
            //Display Result
            Console.Write("Is Array is Symmetric ? : "+Symmetric);
            Console.ReadLine();


        }
    }
}
