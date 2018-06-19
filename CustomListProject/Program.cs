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

            CustomList<int> nums = new CustomList<int>();

            // Act
            nums.Add(2);
            nums.Add(4);
            nums.Add(6);
            nums.Add(8);
            nums.Add(10);
            nums[0].ToString();
            nums[1].ToString();
            nums[2].ToString();
            nums[3].ToString();
            nums[4].ToString();
            for (int i = 0; i < nums.Count; i++)
            {
                Console.WriteLine(nums.ToString());
                Console.ReadLine();
            }
            
        }
    }
}
