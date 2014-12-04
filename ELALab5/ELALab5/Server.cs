using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Messaging;

namespace ELALab5
{
    public partial class Server : Form
    {
        public MessageQueue mqRequest, mqAnswer;
        public static int a;
        public bool completed = false;
        public Server()
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

        private void Server_Load(object sender, EventArgs e)
        {
            completed = false;
            System.Messaging.Message mes;
            System.Messaging.Message mm1 = new System.Messaging.Message();

            string m;
            int mode=0, number =0;

            try
            {
                mes = mqRequest.Receive();
                mes.Formatter = new XmlMessageFormatter(new Type[] { typeof(string) });
                m = mes.Body.ToString();
                
            }
            catch
            {
                m = null;
            }

            if (m != null)
            {
                //MessageBox.Show("Received: " + m);
                string modeStr = m[0]+"";
                mode = Convert.ToInt32(modeStr);
                m = m.Remove(0,1);
                number = Convert.ToInt32(m);

                //MessageBox.Show("Mode: " + mode + "; Number: " + number);
                //double

                mm1.Body = Calculation(number, mode).ToString();
                //MessageBox.Show("Sending answer: " + mm1.Body.ToString());
                mqAnswer.Send(mm1);
                completed = true;
            }
            else mqAnswer.Send("No number");

            this.Close();
        }
        
        public double Calculation(int _num, int _mode)
        {
            double result;
            // FACTORIAL
            if (_mode == 1)
            {
                result = 1.0;
                for (int i = 1; i <= _num; i++)
                {
                    result = result * i;
                }
                return result;
            }      
            // EVEN 1 - even, 0 - noneven
            if (_mode == 2)
            {
                int count = 0;
                for (int i = 2; i < _num; i++)
                {
                    if (_num % i == 0)  
                    {
                        count++;
                    }
                }
                if (count == 0) return 0;
                return 1;
            }

            //SQRT
            if (_mode == 3)
            {
                return Math.Sqrt(_num);
            }

            //pow(num,10)
            
            return Math.Pow(_num, 10);
       
            
        }

        public bool isComplete()
        {
            return completed;
        }
    }
}
