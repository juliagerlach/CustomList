﻿using System;
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
            CustomList<int> customList = new CustomList<int>();
            {
                foreach (int item in customList)
                {
                    Console.WriteLine(item);
                }
                Console.ReadLine();

            }
        }    
        
    }
}
