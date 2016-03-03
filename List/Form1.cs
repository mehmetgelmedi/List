using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace List
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            LinkedList ll = new LinkedList();
            ll.InsertFirst(4);
            //ll.InsertLast(5);
            MessageBox.Show(ll.DisplayElements());
            ll.InsertFirst(1);
            ll.InsertFirst(2);
            ll.InsertFirst(8);
            MessageBox.Show(ll.DisplayElements());
            ll.DeleteFirst();
            MessageBox.Show(ll.DisplayElements());
            //ll.DeleteLast();
            MessageBox.Show(ll.DisplayElements());
            //ll.DeleteLast();
            ll.DeleteLast();
            MessageBox.Show(ll.DisplayElements());
            ll.InsertLast(99);
            MessageBox.Show(ll.DisplayElements());
            ll.InsertLast(100);
            ll.InsertLast(101);
            ll.InsertLast(102);
            MessageBox.Show(ll.DisplayElements());
            // not: ll.DeletePos(0) ilk eleman sorun yok
            // bu şekilde çalışıyor
            ll.DeletePos(5); 
            ll.DeletePos(4);
            ll.DeletePos(3);
            ll.DeletePos(2);
            ll.DeletePos(1);
            // bu şekilde çalışmıyor
            //ll.DeletePos(1);
            //ll.DeletePos(2);
            //ll.DeletePos(3);
            //ll.DeletePos(4);
            //ll.DeletePos(5);
            MessageBox.Show(ll.DisplayElements());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LinkedList ll = new LinkedList();
            ll.InsertFirst(6); 
            ll.InsertFirst(5); 
            ll.InsertFirst(4);
            ll.InsertFirst(3);
            ll.InsertFirst(2);
            ll.InsertFirst(1);

            Uygulama2(ll.Head);
        }

        public void Uygulama2(Node test)
        {
            if (test == null)
                return;

            MessageBox.Show(test.Data.ToString());

            if (test.Next != null)
                Uygulama2(test.Next.Next);

            MessageBox.Show(test.Data.ToString());
        }

        private void btnReverse_Click(object sender, EventArgs e)
        {
            LinkedList ll = new LinkedList();
            ll.InsertFirst(6);
            ll.InsertFirst(5);
            ll.InsertFirst(4);
            ll.InsertFirst(3);
            ll.InsertFirst(2);
            ll.InsertFirst(1);
            MessageBox.Show(ll.DisplayElements());
            Uygulama3Reverse(ref ll.Head);
            MessageBox.Show(ll.DisplayElements());
        }

        public void Uygulama3Reverse(ref Node head)
        {
		    Node currNode = head;
		    Node nextNode = null;
		    Node prevNode = null;

		    while(currNode.Next!=null)
            {
			    nextNode = currNode.Next;
			    currNode.Next = prevNode;
			    prevNode = currNode;
			    currNode = nextNode;
		    }
            currNode.Next = prevNode;
            head = currNode;
        }

    }
}
