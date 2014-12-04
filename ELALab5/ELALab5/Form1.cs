using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Threading;
using System.Linq;
using System.Text;
using System.Messaging;

namespace ELALab5
{
    public partial class Form1 : Form
    {
        public MessageQueue mqRequest, mqAnswer;
        public static int b;
        Server server1;

        public Form1()
        {
            InitializeComponent();
            if (MessageQueue.Exists(@".\Private$\request_queue"))
                mqRequest = new System.Messaging.MessageQueue(@".\Private$\request_queue");
            else
                mqRequest = MessageQueue.Create(@".\Private$\request_queue");

            if (MessageQueue.Exists(@".\Private$\answer_queue"))
                mqAnswer = new System.Messaging.MessageQueue(@".\Private$\answer_queue");
            else
                mqAnswer = MessageQueue.Create(@".\Private$\answer_queue");
            
        }




        private void btnFactorial_Click(object sender, EventArgs e)
        {


            System.Messaging.Message mm = new System.Messaging.Message();
            string temp = "1" + tbNumber.Text.ToString();
            mm.Body = temp;
            
            //MessageBox.Show("Sending number: " + mm.Body.ToString());
            mqRequest.Send(mm);
            server1 = new Server();
            server1.Show();
            // RECEIVE ANSWER
            if (server1.isComplete())
            {
                System.Messaging.Message mes;
                string m;

                try
                {
                    mes = mqAnswer.Receive();
                    mes.Formatter = new XmlMessageFormatter(new Type[] { typeof(string) });
                    m = mes.Body.ToString();
                }
                catch
                {
                    m = "No Message";
                }
                lblFactorial.Text = m;
            }

        }


        
        private void btnPrime_Click(object sender, EventArgs e)
        {


            System.Messaging.Message mm = new System.Messaging.Message();
            string temp = "2" + tbNumber.Text.ToString();
            mm.Body = temp;
            b++;

            //MessageBox.Show("Sending number: " + mm.Body.ToString());
            mqRequest.Send(mm);
            server1 = new Server();
            server1.Show();
            // RECEIVE ANSWER
            if (server1.isComplete())
            {
                System.Messaging.Message mes;
                string m;

                try
                {
                    mes = mqAnswer.Receive();
                    mes.Formatter = new XmlMessageFormatter(new Type[] { typeof(string) });
                    m = mes.Body.ToString();
                }
                catch
                {
                    m = "No Message";
                }

                if (m == "0")
                {
                    lblPrime.Text = "Prime";
                }
                else if (m == "1")
                {
                    lblPrime.Text = "Not prime";
                }
                else lblPrime.Text = m;
            }
            
        }
        

        private void btnSqrt_Click(object sender, EventArgs e)
        {

            System.Messaging.Message mm = new System.Messaging.Message();
            string temp = "3" + tbNumber.Text.ToString();
            mm.Body = temp;
            

            //MessageBox.Show("Sending number: " + mm.Body.ToString());
            mqRequest.Send(mm);
            server1 = new Server();
            server1.Show();
            // RECEIVE ANSWER
            if (server1.isComplete())
            {
                System.Messaging.Message mes;
                string m;

                try
                {
                    mes = mqAnswer.Receive();
                    mes.Formatter = new XmlMessageFormatter(new Type[] { typeof(string) });
                    m = mes.Body.ToString();
                }
                catch
                {
                    m = "No Message";
                }
                lblSqrt.Text = m;
                
            }
        }

        private void btnTen_Click(object sender, EventArgs e)
        {
            System.Messaging.Message mm = new System.Messaging.Message();
            string temp = "4" + tbNumber.Text.ToString();
            mm.Body = temp;

            //MessageBox.Show("Sending number: " + mm.Body.ToString());
            mqRequest.Send(mm);
            server1 = new Server();
            server1.Show();
            // RECEIVE ANSWER
            if (server1.isComplete())
            {
                System.Messaging.Message mes;
                string m;

                try
                {
                    mes = mqAnswer.Receive();
                    mes.Formatter = new XmlMessageFormatter(new Type[] { typeof(string) });
                    m = mes.Body.ToString();
                }
                catch
                {
                    m = "No Message";
                }
                lblTen.Text = m;

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (server1.isComplete())
            {
                System.Messaging.Message mes;
                string m;

                try
                {
                    mes = mqAnswer.Receive();
                    mes.Formatter = new XmlMessageFormatter(new Type[] { typeof(string) });
                    m = mes.Body.ToString();
                }
                catch
                {
                    m = "No Message";
                }
                lblFactorial.Text = m;
            }
        }

    }
}
