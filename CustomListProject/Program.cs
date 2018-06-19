using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomListProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<int> builtInList = new List<int>();
            //builtInList.Add(15);
            //builtInList.Add(16);
            //builtInList.Add(17);
            //builtInList.Add(18);
            //builtInList.Add(19);
            //builtInList.Add(20);
            //builtInList.Remove(18);

            CustomList<int> list = new CustomList<int>();

            // Act
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            Console.ReadKey();
        }
    }
}
