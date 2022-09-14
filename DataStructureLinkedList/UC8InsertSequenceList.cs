using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureLinkedList
{
    internal class UC8InsertSequenceList
    {
        
        
            Node head;
            int newdata;
            public void AppendList(int newdata)
            {
                Node newNode = new Node(newdata);
                if (this.head == null)
                {
                    this.head = newNode;
                }
                else
                {
                    Node temp = this.head;
                    if (temp == null)
                    {
                        Console.WriteLine("list is empty");
                    }
                    while (temp.next != null)
                    {
                        temp = temp.next;
                    }
                    temp.next = newNode;
                }
            }

            public void InsertBetween(int data, int position)
            {
                Node newNode = new Node(data);
                newNode.data = data;
                newNode.next = null;

                if (position < 1)
                {
                    Console.WriteLine("position should be greater than");
                }
                else if (position == 1)
                {
                    newNode.next = this.head;
                    head = newNode;
                }
                else
                {
                    Node tempNode = new Node(data);
                    tempNode = this.head;
                    while (position > 2)
                    {
                        tempNode = tempNode.next;
                        position--;

                    }
                    newNode.next = this.head;
                    tempNode.next = newNode;
                }

            }
            public void Display()
            {
                Node temp = this.head;
                if (temp == null)
                    Console.WriteLine("List is null");

                while (temp != null)
                {
                    Console.WriteLine(temp.data + " ");
                    temp = temp.next;
                }

            }

    }
}

