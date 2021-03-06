﻿using System;
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
        LinkedList objListe;
        private void btnAdim2_Click(object sender, EventArgs e)
        {
            objListe = new LinkedList();
            Random rnd = new Random();
            int i = 0;
            while (i != 100)
            {
                objListe.InsertFirst(rnd.Next(1, 31));
                i++;
            }
            MessageBox.Show(objListe.DisplayElements(), "Adım-2");
            txtElemanAl.Enabled = true;
            btnAdim3.Enabled = true;
            btnAdim4.Enabled = true;

        }

        private void btnAdim3_Click(object sender, EventArgs e)
        {
            int eleman = 0, j = 0;
            try
            {
                eleman = Convert.ToInt32(txtElemanAl.Text);
                while (j != objListe.Size)
                {
                    if (eleman == objListe.GetElement(j).Data)
                        objListe.DeletePos(j);
                    j++;
                }
                MessageBox.Show(objListe.DisplayElements(), "Adım-3");
            }
            catch
            {
                MessageBox.Show("Aradığınız eleman bulunamadı...", "Uyarı");
            }
        }

        public void tersCevir(ref Node head)
        {
            Node currNode = head;
            Node nextNode = null;
            Node prevNode = null;

            while (currNode.Next != null)
            {
                nextNode = currNode.Next;
                currNode.Next = prevNode;
                prevNode = currNode;
                currNode = nextNode;
            }
            currNode.Next = prevNode;
            head = currNode;
        }
        private void btnAdim4_Click(object sender, EventArgs e)
        {
            tersCevir(ref objListe.Head);
            MessageBox.Show(objListe.DisplayElements(), "Adım-4");
        }

    }

}