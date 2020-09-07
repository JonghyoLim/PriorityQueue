using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Assignment6PQ
{
    public partial class Form1 : Form
    {
        ArrayList list = new ArrayList();
        HeapSortPQ heapPQ = new HeapSortPQ();

        public Form1()
        {
            InitializeComponent();  
        }

        private void label3_Click(object sender, EventArgs e)
        {
            //By Mistake!! 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            heapPQ.Enqueue(textName.Text.ToString(), Int32.Parse(comboBox1.SelectedItem.ToString()));
            textName.Clear();
            textQueue.Text = heapPQ.Display();
            btnAdd.Enabled = false;
        }

        private void btnCall_Click(object sender, EventArgs e)
        {
            textCalled.Text = heapPQ.Call();
            textQueue.Clear();

            textQueue.Text = heapPQ.Display();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            btnAdd.Enabled = false;
        }

        private void textName_TextChanged(object sender, EventArgs e)
        {
            if (textName.TextLength > 0)
                btnAdd.Enabled = true;
            else
                btnAdd.Enabled = false;
        }
    }
}
