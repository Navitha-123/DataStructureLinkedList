using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureLinkedList
{
    public class UC2AddList
    {
        Node head;
        int newdata;

        public void ListAdd(int newdata)
        {
            Node newNode = new Node(newdata);
            newNode.next = head;
            head = newNode;
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
