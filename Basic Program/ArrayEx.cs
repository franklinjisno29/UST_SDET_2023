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
    }
}
