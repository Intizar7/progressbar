using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgressBar_Example
{
    public partial class form : Form
    {
        Thread th1;
        int sm1 = 1;
        private ManualResetEvent _manualResetEvent = new ManualResetEvent(true);
        delegate void IncreasePb();

        public form()
        {
            InitializeComponent();
        }

        private void form_Load(object sender, EventArgs e)
        {
            th1 = new Thread(RunPB1);
        }

        private void RunPB1()
        {
            for (; ; )
            {
                _manualResetEvent.WaitOne(Timeout.Infinite);
                Thread.Sleep(100);
                IncreasePb1();
            }
        }

        private void IncreasePb1()
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.pb1.InvokeRequired)
            {
                IncreasePb d = new IncreasePb(IncreasePb1);
                this.Invoke(d, new object[] { });
            }
            else
            {
                this.pb1.Increment(1);
            }
        }

        private void btn_for_pb1_Click(object sender, EventArgs e)
        {
            textBox1.Text = th1.ThreadState.ToString();

            if (th1.ThreadState == ThreadState.Unstarted)
                th1.Start();
        }

        private void btn_for_pb2_Click(object sender, EventArgs e)
        {

        }

        private void btn_for_pb3_Click(object sender, EventArgs e)
        {

        }

        private void timer_Tick(object sender, EventArgs e)
        {

        }

        private void toggleBtn1_Click(object sender, EventArgs e)
        {
            if (sm1 == 1)
                _manualResetEvent.Reset();
            else
                _manualResetEvent.Set();

            sm1 = 1 - sm1;
        }
    }
}
