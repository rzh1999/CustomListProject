using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListProj
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomList<int> customList = new CustomList<int>();
            //customList[0] = 2;
            //customList[1] = 3;

            customList.Add(1);
            customList.Add(2);
            customList.Add(3);
            customList.Add(4);
            customList.Add(5);
            customList.Add(6);
            customList.Add(7);
            customList.Add(8);
            customList.Add(9);
            customList.Add(10);
            customList.Add(11);
            customList.Add(12);
            customList.Add(13);
            customList.Add(14);
            customList.Add(15);
            customList.Add(16);
            customList.Add(17);
            customList.Remove(3);

            Console.WriteLine(customList[0]);
            Console.WriteLine(customList[1]);
            Console.WriteLine(customList[2]);
            Console.WriteLine(customList[3]);
            Console.WriteLine(customList[4]);
            Console.WriteLine(customList[5]);
            Console.WriteLine(customList[6]);
            Console.WriteLine(customList[7]);
            Console.WriteLine(customList[8]);
            Console.WriteLine(customList[9]);
            Console.WriteLine(customList[10]);
            Console.WriteLine(customList[11]);
            Console.WriteLine(customList[12]);
            Console.WriteLine(customList[13]);
            Console.WriteLine(customList[14]);
            Console.WriteLine(customList[15]);
            Console.WriteLine(customList[16]);

            Console.ReadLine();

        }
    }
}
