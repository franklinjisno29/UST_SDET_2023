using Basic_Program.ExceptionMessages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Program
{
    internal class ExcepHandling
    {
        public ExcepHandling(int num1, int num2)
        {
            Num1 = num1;
            Num2 = num2;
        }

        public int Num1 { get; set; }
        public int Num2 { get; set; }
        public void Divide()
        {
            //try
            //{
                int[] num = { 10, 20, 30 };
                int res = Num1 / Num2;
                Console.WriteLine(res);
                foreach(var i in num)
                {
                    res = i / Num2;
                    Console.WriteLine(res);
                }
                for(int i = 0; i <=3; i++)
                {
                    res = num[i] / Num2;
                }
        //    }
        //    catch (ArithmeticException ex)
        //    {
        //        //Console.WriteLine(ex.Message);
        //        //Console.WriteLine(ex.StackTrace);
        //        //Console.WriteLine(ex.Source);
        //        Console.WriteLine("Dont give zero for denom");
        //    }
        //    catch(IndexOutOfRangeException ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //    }
        //    finally { Console.WriteLine("done"); }
        }
        public void Numcheck()
        {
            if(Num1 >= 100)
            {
                Console.WriteLine("Congratz");
            }
            else
            {
                throw new Num1Exception(MyExceptions.exmsglist[3]);
            }
            if (Num2 < 100)
            {
                Console.WriteLine("Congratz");
            }
            else
            {
                throw new Num2Exception(MyExceptions.exmsglist[4]);
            }
        }
        public void Numcheck1()
        {
            if (Num2 < 100)
            {
                Console.WriteLine("Congratz");
            }
            else
            {
                throw new Num2Exception(MyExceptions.exmsglist[4]);
            }
        }
    }
    
}
