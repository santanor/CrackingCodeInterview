using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomLinkedList
{
    class Program
    {
        public static void Main(string[] args)
        {
            LinkedList list = new LinkedList(0);
            for (int i = 0; i < 10; i++)
                list.AddAtTail(i);

            list.DeleteElement(1);

            Console.WriteLine(list.ToString());
        }
    }
}
