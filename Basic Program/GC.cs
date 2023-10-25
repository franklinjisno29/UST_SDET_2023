using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Program
{
    internal class GC
    {
        public void ListHandling()
        {
            List<int> num = new List<int>();
            num.Add(10);
            num.Add(20);
            num.Add(30);
            num.Add(40);
            num.Reverse();
            num.RemoveAt(3);
            num.Sort();
            //arrayList.Clear();
            Console.WriteLine(num.Contains(10));

            //for (int i = 0; i < arrayList.Count; i++)
            //{
            //    Console.WriteLine(arrayList[i]);
            //}
            foreach (var i in num)
            {
                Console.WriteLine(i);
            }
        }
        public void StackHandling()
        {
            Stack st = new Stack();
            st.Push(10);
            st.Push(20);
            st.Push("BB");
            foreach (var i in st)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("pop" + st.Pop());
            Console.WriteLine("peek" + st.Peek());
        }
        public void QueueHandling()
        {
            Queue q = new Queue();
            q.Enqueue(10);
            q.Enqueue(20);
            q.Enqueue("BB");
            foreach (var i in q)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Dequeue" + q.Dequeue());
            Console.WriteLine("peek" + q.Peek());
        }
        public void DictionaryHandling()
        {
            Dictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(1, "aa");
            dict.Add(2, "yy");
            dict.Add(3, "BB");
            dict.Add(4, "AA");
            dict.Remove(3);
            dict.ContainsKey(4);
            Console.WriteLine("count" + dict.Count);
            foreach (var i in dict)
            {
                Console.WriteLine(i);
            }
        }
        public void SortedListHandling()
        {
            SortedList sl = new SortedList();
            sl.Add(1, 10);
            sl.Add(3, "BB");
            sl.Add(4, "AA");
            sl.Add(2, 20);

            sl.Remove(3);
            sl.ContainsKey(4);
            Console.WriteLine("count" + sl.Count);
            foreach (var i in sl)
            {
                Console.WriteLine(i);
            }

        }
    }
}
