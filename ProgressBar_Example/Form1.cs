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
        Thread th1, th2, th3;
        int sm1 = 1,sm2=1,sm3=1;
        private ManualResetEvent _manualResetEvent1 = new ManualResetEvent(true);
        private ManualResetEvent _manualResetEvent2 = new ManualResetEvent(true);
        private ManualResetEvent _manualResetEvent3 = new ManualResetEvent(true);
        delegate void IncreasePb();
     
        public form()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void form_Load(object sender, EventArgs e)
        {
            th1 = new Thread(RunPB1);
            if (th1.ThreadState == ThreadState.Unstarted)
                th1.Start();
           // th1.Abort();
            th2 = new Thread(RunPB2);
            if (th2.ThreadState == ThreadState.Unstarted)
                th2.Start();

            th3 = new Thread(RunPB3);
            if (th3.ThreadState == ThreadState.Unstarted)
                th3.Start();
        }

        /*First Action*/
        private void btn_for_pb1_Click(object sender, EventArgs e)
        {
            //if (th1.ThreadState == ThreadState.Unstarted)
            //    th1.Start();
        }

        private void toggleBtn1_Click(object sender, EventArgs e)
        {
            //if (th1 != null && th1.IsAlive)
            //{
            //    th1.Suspend();
            //}
            if (sm1 == 1)
                _manualResetEvent1.Reset();
            else
                _manualResetEvent1.Set();

            sm1 = 1 - sm1;
        }

        private void RunPB1()
        {
            for (; ; )
            {
                _manualResetEvent1.WaitOne(Timeout.Infinite);
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

        /*Second Action*/
        private void RunPB2()
        {
            for (; ; )
            {
                _manualResetEvent2.WaitOne(Timeout.Infinite);
                Thread.Sleep(100);
                IncreasePb2();
            }
        }

        private void IncreasePb2()
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.pb2.InvokeRequired)
            {
                IncreasePb d = new IncreasePb(IncreasePb2);
                this.Invoke(d, new object[] { });
            }
            else
            {
                this.pb2.Increment(1);
            }
        }

        private void btn_for_pb2_Click(object sender, EventArgs e)
        {
            //if (th2.ThreadState == ThreadState.Unstarted)
            //    th2.Start();
        }

        private void toggleBtn2_Click(object sender, EventArgs e)
        {
            if (sm2 == 1)
                _manualResetEvent2.Reset();
            else
                _manualResetEvent2.Set();

            sm2 = 1 - sm2;
        }

        /*Third Action*/
        private void RunPB3()
        {
            for (; ; )
            {
                _manualResetEvent3.WaitOne(Timeout.Infinite);
                Thread.Sleep(100);
                IncreasePb3();
            }
        }

        private void IncreasePb3()
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.pb3.InvokeRequired)
            {
                IncreasePb d = new IncreasePb(IncreasePb3);
                this.Invoke(d, new object[] { });
            }
            else
            {
                this.pb3.Increment(1);
            }
        }

        private void btn_for_pb3_Click(object sender, EventArgs e)
        {
            //if (th3.ThreadState == ThreadState.Unstarted)
            //    th3.Start();
        }

        private void toggleBtn3_Click(object sender, EventArgs e)
        {
            if (sm3 == 1)
                _manualResetEvent3.Reset();
            else
                _manualResetEvent3.Set();

            sm3 = 1 - sm3;
        }
    }
}
