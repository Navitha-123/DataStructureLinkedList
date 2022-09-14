using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureLinkedList
{
    internal class UC6LastDelete
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
                
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = newNode;
            }
        }
      
        public int DeleteLastNode()
        {
            Node newNode = this.head;
            if (this.head == null)
            {
                Console.WriteLine("Linked list is empty");
                return 0;
            }
            if (this.head.next == null)
            {
                //this.head = null;
                return 0;
            }
            while (newNode.next.next != null)//12   13   14
            {
                newNode = newNode.next;// 12   13
            }
            int lasteleteNode = newNode.next.data;//14
            newNode.next = null;
            return lasteleteNode;
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
