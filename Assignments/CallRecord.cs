using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class CallRecord
    {
        public CallRecord(int callID, double phoneNumber, double callTime)
        {
            CallID = callID;
            PhoneNumber = phoneNumber;
            CallTime = callTime;
        }

        public int CallID { get; set; }
        public double PhoneNumber { get; set; }
        public double CallTime { get; set; }

        public static Dictionary<int, CallRecord> callrec = new Dictionary<int, CallRecord>();
        public static void SearchRec(double phnum)
        {
            foreach (var i in callrec.Values)
            {
                if (phnum == i.PhoneNumber)
                {
                    Console.WriteLine("CallId: {0}\tCallTime:{1}", i.CallID, i.CallTime);
                }
            }
        }
        public static void TotalCalls()
        {
            Dictionary<double, int> totcall = new Dictionary<double, int>();
            foreach (var i in callrec.Values)
            {
                if (totcall.ContainsKey(i.PhoneNumber))
                {
                    totcall[i.PhoneNumber]++;
                }
                else
                {
                    totcall[i.PhoneNumber] = 1;
                }
            }
            foreach (var i in totcall)
            {
                Console.WriteLine("Phonenumber:{0}\t{1}", i.Key, i.Value);
            }
        }
    }
}
