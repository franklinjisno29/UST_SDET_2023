using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Program
{
    internal class NGC
    {
        public void ArrayListHandling()
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add(10);
            arrayList.Add(20);
            arrayList.Add("AA");
            arrayList.Add(true);
            arrayList.Add(false);
            arrayList.Reverse();
            arrayList.RemoveAt(3);
            //arrayList.Sort();
            //arrayList.Clear();
            Console.WriteLine(arrayList.Contains(10));

            //for (int i = 0; i < arrayList.Count; i++)
            //{
            //    Console.WriteLine(arrayList[i]);
            //}
            foreach (var i in arrayList)
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
            Console.WriteLine("pop"+st.Pop());
            Console.WriteLine("peek"+st.Peek());
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
        public void HTHandling()
        {
            Hashtable h = new Hashtable();
            h.Add(1,10);
            h.Add(2,20);
            h.Add(3,"BB");
            h.Add("4", "AA");
            h.Remove(3);
            h.ContainsKey(4);
            Console.WriteLine("count" + h.Count);
            foreach (var i in h)
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
