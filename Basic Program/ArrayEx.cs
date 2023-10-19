using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Program
{
    internal class ArrayEx
    {
        //readonly 
        int[] numbers = new int[5]; //={10,20,30};
        int[,] nums = new int[2, 2];
        int[][,] arr = new int[][,]
        {
            new int[,] {{ 1, 2 }, { 3, 4 }},
            new int[,] {{1,4},{5, 6 },{ 5, 7 }},
            new int[,] {{ 2, 3 },{ 9, 8 },{ 7, 7 }}
        };
        public void Onedim()
        {
            numbers[0] = 100;
            numbers[1] = 10;
            for(int i=0;i<numbers.Length;i++)
            {
                Console.WriteLine(numbers[i]);
            }
            Array.Sort(numbers);
            foreach(var num in numbers)
            {
                Console.WriteLine(num);
            }
        }
        public void Twodim()
        {
            //nums[0, 0] = 100;
            //nums[0, 1] = 10;
            //nums[1, 0] = 20;
            //nums[1, 1] = 30;
            int[,] nums = { { 100, 100 }, { 100, 100 } };
            foreach(int num in nums)
            {
                Console.WriteLine(num);
            }
        }

        public void Ja()
        {
            foreach(var num in arr)
            {
                Console.WriteLine(num[1,1]);
            }
            for(int i=0;i < arr.Length;i++)
            {
                int x = 0;
                for (int j = 0; j < arr[i].GetLength(x);j++)
                {
                    for (int k = 0; k < arr[j].Rank;k++)
                    {
                        Console.Write(arr[i][j,k] +" ");
                    }
                    Console.WriteLine();
                }
                x++;
                Console.WriteLine();
            }
        }
    }
}
