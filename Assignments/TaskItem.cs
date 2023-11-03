using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class TaskItem
    {
        public TaskItem(int taskID, string? taskDescription)
        {
            TaskID = taskID;
            TaskDescription = taskDescription;
            IsCompleted = false;
        }

        public int TaskID { get; set; }
        public string? TaskDescription { get; set; }
        public bool IsCompleted { get; set; }

    }
    class Node
    {
        public TaskItem Data { get; set; }
        public Node Next { get; set; }

        public Node(TaskItem data)
        {
            Data = data;
            Next = null;
        }
    }

    public class CustomLinkedList
    {
        private Node head;

        public CustomLinkedList()
        {
            head = null;
        }

        public bool IsEmpty()
        {
            return head == null;
        }

        public void AddTask(int id, string description)
        {
            TaskItem newTask = new TaskItem(id, description);
            Node newNode = new Node(newTask);

            if (head == null)
            {
                head = newNode;
            }
            else
            {
                Node current = head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;
            }
        }

        public void RemoveTask(int taskId)
        {
            if (IsEmpty())
            {
                Console.WriteLine("List is empty. Cannot remove.");
                return;
            }

            if (head != null)
            {
                if (head.Data.TaskID == taskId)
                {
                    head = head.Next;
                    return;
                }

                Node current = head;
                while (current.Next != null)
                {
                    if (current.Next.Data.TaskID == taskId)
                    {
                        current.Next = current.Next.Next;
                        return;
                    }
                    current = current.Next;
                }
            }
        }

        public void MarkTaskAsCompleted(int taskId)
        {
            Node current = head;
            while (current != null)
            {
                if (current.Data.TaskID == taskId)
                {
                    current.Data.IsCompleted = true;
                    return;
                }
                current = current.Next;
            }
        }

        public void DisplayTasks()
        {
            if (head == null)
            {
                Console.WriteLine("Task list is empty.");
                return;
            }

            Node current = head;
            Console.WriteLine("Tasks:");
            while (current != null)
            {
                Console.WriteLine($"Task ID: {current.Data.TaskID}, Description: {current.Data.TaskDescription}, Completed: {current.Data.IsCompleted}");
                current = current.Next;
            }
        }
        public void DisplayCompletedTasks()
        {
            if (IsEmpty())
            {
                Console.WriteLine("List is empty.");
                return;
            }

            Node current = head;
            Console.WriteLine("Completed Tasks:");
            while (current != null)
            {
                if (current.Data.IsCompleted)
                {
                    Console.WriteLine($"Task ID: {current.Data.TaskID}, Description: {current.Data.TaskDescription}");
                }
                current = current.Next;
            }
        }

        public void DisplayPendingTasks()
        {
            Node current = head;
            Console.WriteLine("Pending Tasks:");
            while (current != null)
            {
                if (!current.Data.IsCompleted)
                {
                    Console.WriteLine($"Task ID: {current.Data.TaskID}, Description: {current.Data.TaskDescription}");
                }
                current = current.Next;
            }
        }
    }
}
