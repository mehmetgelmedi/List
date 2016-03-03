using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    public class LinkedList : LinkedListADT
    {
        public override void InsertFirst(int value)
        {
            Node tmpHead = new Node 
            { 
                Data = value 
            };

            if (Head == null)
                Head = tmpHead;
            else
            {
                //En kritik nokta: tmpHead'in next'i eski Head'i göstermeli
                tmpHead.Next = Head;
                //Yeni Head artık tmpHead oldu
                Head = tmpHead;
            }
            //Bağlı listedeki eleman sayısı bir arttı
            Size++;
        }

        public override void InsertLast(int value)
        {
        //  Node  first = new Node();
        //    if (first == null)
        //    {
        //        first = first.Next;
        //    }
        //    Node newLast = new Node();
        //    while (first.Next != null)
        //    {
        //        first = first.Next;
        //    }
        //    newLast.Data= value;
        //    first.Next = newLast;
        //    first = newLast;
            //Node last = new Node();
            //last.Data = value;
           
            //Node node = first;
            //if (first == null)
            //{
            //    first = last;
            //}
            //else
            //{
            //    while (node.Next != null)
            //    {
            //        node = node.Next;
            //    }
            //    node.Next = last;
            //}
            //Node last ;
            //Node newLast = new Node();
            
            //while (last.Next != null)
            //{
            //    last = newLast.Next;
            //}
            //newLast.Data = value;
            //newLast.Next = last;
            //last = newLast;  
            Node newLast = new Node();
            if (Head == null)
            {
                newLast.Data = value;
                Head = newLast;
                return;
            }
            Node curr = Head;
            while (curr.Next != null)
            {
                curr = curr.Next;
            }
            newLast.Data = value;
            curr.Next= newLast;
            Size++;
           
        }

        public override void InsertPos(int position, int value)
        {
            throw new NotImplementedException();
        }

        public override void DeleteFirst()
        {
            if (Head != null)
            {
                //Head'in next'i HeadNext'e atanıyor
                Node HeadNext = this.Head.Next;
                //HeadNext null ise zaten tek kayıt olan Head silinir.
                if (HeadNext == null)
                    Head = null;
                else
                    //HeadNext null değilse yeni Head, HeadNext olur.
                    Head = HeadNext;
                //Listedeki eleman sayısı bir azaltılıyor
                Size--;
            }
        }

        public override void DeleteLast()
        {
            Node item = Head;
            int i = 1;
            while (item != null)
            {
                if (i == Size-1)
                {
                    item.Next = null;
                    break;
                }
                item = item.Next;
                i++;
            }
            Size--;

        }

        public override void DeletePos(int position)
        {
            throw new NotImplementedException(); // hata verir
        }

        public override Node GetElement(int position)
        {
            throw new NotImplementedException(); // hata verir
        }

        public override string DisplayElements()
        {
            string temp = "";
            Node item = Head;
            while (item != null)
            {
                temp += "-->" + item.Data;// +" Next -->" + item.Next;
                item = item.Next;
            }

            return temp;
        }
    }
}
