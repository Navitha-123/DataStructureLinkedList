using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureLinkedList
{
    public class UC7ListSearch
    {
        Node head;
        int newdata;
        public void AppendList(int newData)
        {
            Node newNode = new Node(newData);

            if (this.head == null)
            {
                this.head = newNode;
            }
            else
            {
                Node temp = this.head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = newNode;
            }
        }
        public void Search(int value)
        {
            Node temp = this.head;
            if (temp != null)
            {
                while (temp != null)
                {
                    if (temp.data == value)//11 12 13
                    {
                        Console.WriteLine("{0} is present in the list", value);
                    }
                    temp = temp.next;
                }
                Console.WriteLine("{0} is not present in the list", value);
            }
        }
    }
}
