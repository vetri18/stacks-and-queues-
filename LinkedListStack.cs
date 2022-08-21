﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueue
{
    public class LinkedListStack
    {
        Node head;
        Node current;
        public LinkedListStack()
        {
            this.head = null;
        }
        public void Push(int data)
        {
            Node node = new Node(data);
            //no first node added to list
            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;

                }
                //assigning node to temp->next
                temp.next = node;
            }
            Console.WriteLine("{0} data is inserted \n", node.data);

        }
        public void Display()
        {
            Node temp = this.head;

            if (temp == null)
            {
                Console.WriteLine("LinkedList is empty\n");
                return;
            }
            while (temp != null)
            {
                Console.Write(temp.data + " \n");
                temp = temp.next;
            }
        }

        public void Peek()
        {

            if (head == null)
            {
                Console.WriteLine("LinkedList is empty\n");
                return;
            }
            else
            {
                Console.WriteLine("Top of list is {0}  \n ", head.data);
            }
        }

        public void Pop()
        {
            if (head == null)
            {
                Console.WriteLine("LinkedList is empty, so deletion can't possible");
                return;
            }
            else
            {
                Console.WriteLine("{0} is poped", head.data);
                head = head.next;


            }

        }

        public bool IsEmpty()
        {

            if (head == null)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

    }
}