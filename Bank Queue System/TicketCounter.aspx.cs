using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Bank_Queue_System
{
    public partial class TicketCounter : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //check in if session is null
            if (Session["TokenQueue"] == null)
            {
                //transfering data from quue to session. to print how many number of people are ahead.
                Queue<int> tokenQueues = new Queue<int>();
                Session["TokenQueue"] = tokenQueues;
            }
            
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            //transfering queue from session into another queue
            Queue<int> queueToken = (Queue<int>)Session["TokenQueue"];
            //printing number of people are ahead.
            Label2.Text = queueToken.Count.ToString();

            //initializing new session to 0 if session is null
            if (Session["ListToken"] == null)
            {
                Session["ListToken"] = 0;
            }

            //incrementing new session with + 1 when button is click.
            int token = (int)Session["ListToken"] + 1;

            Session["ListToken"] = token;
            queueToken.Enqueue(token);
            addQueueList(queueToken);

            
        }
        void addQueueList(Queue<int> queueList)
        {
            ListBox1.Items.Clear();
            foreach (int t in queueList)
            {
                ListBox1.Items.Add(t.ToString());
            }
        }
        void AddListToCounter(TextBox textBox, int counter)
        {
            Queue<int> queueToken = (Queue<int>)Session["TokenQueue"];
            if (queueToken.Count == 0)
            {
                textBox.Text = "No customer in line";

            }
            else
            {
                int tokenToBeServed = queueToken.Dequeue();
                textBox.Text = tokenToBeServed.ToString();
                addQueueList(queueToken);
                Label1.Text = "Token " + tokenToBeServed + " please go to counter no " + counter;

            }
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            AddListToCounter(TextBox1, 1);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            AddListToCounter(TextBox2, 2);
        }
        protected void Button3_Click1(object sender, EventArgs e)
        {
            AddListToCounter(TextBox3, 3);
        }
    }
}