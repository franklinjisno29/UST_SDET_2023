﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadsEx
{
    internal class Warehouse
    {
        private int boxCount = 0;

        public void AddBox(int workerId)
        {
            for (int i = 1; i <= 5; i++)
            {
                Thread.Sleep(1000); // Simulate the time it takes to add a box
                boxCount++;
                Console.WriteLine($"Worker {workerId} added a box. Total boxes: {boxCount}");
            }
        }
        public int GetTotalBoxes()
        {
            return boxCount;
        }
    }
}
