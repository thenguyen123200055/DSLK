using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSLK
{
    class Node
    {
        private int info;
        private Node next;

        public Node(int x)
        {
            info = x;
            next = null;
        }
        public int Info
        {
            set { this.info = value; }
            get { return info; }
        }
        public Node Next
        {
            set { this.next = value; }
            get { return next; }
        }
        class SingleLinkList
        {
            private Node Head;
            public SingleLinkList()
            {
                Head = null;
            }
            public void AddHead(int x)
            {
                Node p = new Node(x);
                if (Head == null)
                {
                    Head = p;
                }
                else
                {
                    Node q = Head;
                    while (q.Next != null)
                    {
                        q = q.Next;
                    }
                    q.Next = p;
                }
            }
            public void DeleteHead()
            {
                if (Head != null)
                {
                    Node p = Head;
                    Head = Head.Next;
                    p.Next = null;
                }
            }
            public void DeleteLast()
            {
                if (Head != null)
                {
                    Node p = Head;
                    Node q = null;
                    while (p.Next != null)
                    {
                        q = p;
                        p = p.Next;
                    }
                    q.next = null;
                }
            }
            public void ProcessList()
            {
                Node p = Head;
                while (p != null)
                {
                    Console.WriteLine($"{p.Info} ");
                    p = p.Next;
                }
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                SingleLinkList l = new SingleLinkList();

                l.ProcessList();
                Console.ReadLine();
                l.AddHead(9);
                l.AddHead(8);
                l.AddHead(2);
                l.AddHead(1);
                Console.WriteLine("Danh sach lien ket");
                l.ProcessList();

                l.DeleteHead();
                Console.WriteLine("\nDanh sach lien ket sau khi xoa nut dau:");
                l.ProcessList();

                l.DeleteLast();
                Console.WriteLine("\nDanh sach lien ket sau khi xoa nut cuoi:");
                l.ProcessList();
                Console.ReadLine();
            }


        }
    }
}

