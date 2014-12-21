using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomLinkedList
{
    public class LinkedList
    {

        private Node head;

        public LinkedList(int info)
        {
            Node head = new Node(info);
            this.head = head;
        }
        
        public void AddAtTail(int info)
        {
            Node end = new Node(info);
            Node n = head;
            while (n.Next != null)
                n = n.Next;
            n.Next = end;
        }

        public void DeleteElement(int info)
        {
            if(head.data == info)
            {
                if (head.Next != null)
                    head = head.Next;
                else
                    head = null;
            }

            Node prev = head;
            Node next = head.Next;

            while(next!= null)
            {
                if(next.data == info)
                {
                    prev.Next = next.Next;
                    break;
                }
                prev = next;
                next = next.Next;
            }
        }


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            Node node = head;
            while(node != null)
            {
                sb.Append(node.ToString());
                node = node.Next;
            }
            return sb.ToString();
        }
    }
}
