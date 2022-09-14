using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureLinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("choose option 1.add ele to list \t 2.Addfirst");
            int option = Convert.ToInt32(Console.ReadLine());   
            switch(option)
            {
                case 1:

                    SimpleLinkedList list = new SimpleLinkedList();

                    list.AddEle(34);
                    list.AddEle(67);
                    list.AddEle(89);
                    list.AddEle(58);

                    list.Display();
                    break;
                case 2:
                    UC2AddList list1 = new UC2AddList();
                    list1.ListAdd(70);
                    list1.ListAdd(30);
                    list1.ListAdd(56);
                    list1.Display();
                    break;

                default:
                    Console.WriteLine("Enter wrong choice");
                    break;            
            }
            Console.ReadLine();
        }
    }
}
