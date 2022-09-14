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
            Console.WriteLine("choose option 1.add ele to list \t 2.Addfirst \t 3.AppendList \t 4.insert \t 5.deletefirst \t 6.Deletelast \t 7.search \t 8.insertsequencelist");
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
                case 3:
                    UC3AppendList list2 = new UC3AppendList();
                    list2.AppendList(56);
                    list2.AppendList(30);
                    list2.AppendList(70);
                    list2.Display();
                    break;
                case 4:
                    UC4InsertList list3 = new UC4InsertList();
                    list3.AppendList(30);
                    list3.AppendList(70);
                    list3.InsertBetween(56, 1);
                    list3.Display();
                    break;
                case 5:
                    UC5DeleteFirst list4 = new UC5DeleteFirst();
                    list4.AppendList(56);
                    list4.AppendList(30);
                    list4.AppendList(70);
                    list4.DeleteFirst();

                    list4.Display();
                    break;

                case 6:
                    UC6DeleteLast list5 = new UC6DeleteLast();
                    list5.AppendList(56);
                    list5.AppendList(30);
                    list5.AppendList(70);
                    list5.DeleteLastNode();
                    list5.Display();
                    break;
                case 7:
                    UC7SearchList list6 = new UC7SearchList();
                    list6.AppendList(56);
                    list6.AppendList(30);
                    list6.AppendList(70);
                    list6.Search(30);
                    break;
                case 8:
                    UC8InsertSequenceList list7 = new UC8InsertSequenceList();
                    list7.AppendList(56);
                    list7.AppendList(30);
                    list7.AppendList(70);
                    list7.InsertBetween(40,3);
                    list7.Display();
                    break;

                default:
                    Console.WriteLine("Enter wrong choice");
                    break;            
            }
            Console.ReadLine();
        }
    }
}
