using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// NOTES 
//Standing Queue --> A Line or sequeence of people or vehicles awaiting their turn to be attended to or too proceed
//Array and Queue are references type.

namespace QueuevsStack
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Queue<string> peopleQueue = new Queue<string>();
        Stack<string> peopleStack = new Stack<string>();
        private void Form1_Load(object sender, EventArgs e)
        {
            string[] pArray = new string[] { "Tim", "John", "Lisa", "Mary" };
            Queue<string> xQueen = new Queue<string>(pArray);
            Stack<string> xStack = new Stack<string>(pArray);
            peopleQueue.Enqueue("Tim");
            peopleQueue.Enqueue("John");
            peopleQueue.Enqueue("Tracey");
            peopleQueue.Enqueue("Lisa");
            peopleQueue.Enqueue("Mary");
            foreach (string person in peopleQueue)
            {
                rtbQueue.AppendText(person + Environment.NewLine);
            }
            peopleStack.Push("Jane");
            peopleStack.Push("Kim");
            peopleStack.Push("Simon");
            peopleStack.Push("Peter");
            peopleStack.Push("Elizabeth");
            foreach (string person in peopleStack)
            {
                rtbQueue.AppendText(person + Environment.NewLine);
            }
        }

        private void btnEnqueue_Click(object sender, EventArgs e)
        {
            string x = txtQueueInput.Text.Trim();
            if (x.Length > 0)
            {
                peopleQueue.Enqueue(x);
            }
            else
            {
                lblMessage.Text = " Message: Nothing to be added to the queue";
                return;
            }
            rtbQueue.Clear();
            foreach (string person in peopleQueue)
            {
                rtbQueue.AppendText(person + Environment.NewLine);
            }
            lblMessage.Text = "Note: " + x + " is added to the queue";



        }

        private void btnDequeue_Click(object sender, EventArgs e)
        {
            if (peopleQueue.Count > 0)
                lblMessage.Text = "Note: " + peopleQueue.Dequeue() +
                            "is being removed from the queue.";
            rtbQueue.Clear();
            foreach (string person in peopleQueue)
            {
                rtbQueue.AppendText(person + Environment.NewLine);
            }

        }

        private void btnPeek_Click(object sender, EventArgs e)
        {
            if (peopleQueue.Count > 0)
            {
                lblMessage.Text = "Who is the first on the queue? " + peopleQueue.Peek() + " is the first!";
                rtbQueue.Clear();
                foreach (string person in peopleQueue)
                {
                    rtbQueue.AppendText(person + Environment.NewLine);
                }

            }
        }

        private void btnPush_Click(object sender, EventArgs e)
        {
            string x = txtStackInput.Text.Trim();
            if (x.Length > 0)
            {
                peopleStack.Push(x);
            }
            else
            {
                lblMessage.Text = "Message: Nothing to be added to the stack";
                return;
            }
            rtbStack.Clear();
            foreach (string person in peopleStack)
            {
                rtbStack.AppendText(person + Environment.NewLine);
            }
            lblMessage.Text = "Note: " + x + "is added to the stack";
        }

        private void btnPop_Click(object sender, EventArgs e)
        {
            if (peopleStack.Count > 0)
            {
                lblMessage.Text = "Note: " + peopleStack.Pop() + " is being removed from the stack. ";
                rtbStack.Clear();
                foreach (string person in peopleStack)
                {
                    rtbStack.AppendText(person + Environment.NewLine);
                }
            }
        }

        private void BtnPeekStack_Click(object sender, EventArgs e)
        {
            if (peopleStack.Count > 0)
            {
                lblMessage.Text = "Who is the last on the stack ?" + peopleStack.Peek() + " Is the last !!";
                rtbStack
                    .Clear();
                foreach (string person in peopleStack)
                {
                    rtbStack.AppendText(person + Environment.NewLine);
                }
            }
        }
    }
}
