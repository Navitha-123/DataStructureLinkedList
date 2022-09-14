using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureLinkedList
{
    public class SimpleLinkedList
    {
        Node head;
        public void AddEle(int newdata)
        {
            Node newNode = new Node(newdata);
            if(this.head == null)
            {
                this.head = newNode;
            }
            else
            {
                Node temp = this.head;
                while(temp.next != null)
                {
                    temp = temp.next;   
                }
                temp.next = newNode;
            }
        }

        public void Display()
        {
            Node temp = this.head;
            if(temp==null)
                Console.WriteLine("List is null");

            while(temp!=null)
            {
                Console.WriteLine(temp.data+" ");
                temp = temp.next;
            }

        }

    }
}
