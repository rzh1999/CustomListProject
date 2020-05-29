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
       
        //Create new instance of "type" in this case int to be searched
        CustomList<int> intList = new CustomList<int>();

        //Create new instance of "type" in this case int for your query
        CustomList<int> search = new CustomList<int>();

        //Add items to list to be searched
        intList.Add(1);
        intList.Add(3);
        intList.Add(5);

        //Add items for your query
        search.Add(2);
        search.Add(1);
        search.Add(6);

        //Create list to hold results
        CustomList<int> results;

        results = intList - search;

        Console.WriteLine(results.ToString());
        
            Console.ReadLine();

        }
    }
}
