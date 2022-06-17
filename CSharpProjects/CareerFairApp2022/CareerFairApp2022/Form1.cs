using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace CareerFairApp2022
{
    public partial class Form1 : Form
    {
        internal Timer timer = new Timer();
        internal short stopVal = 60;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            progressBar1.Value = 60;
        }

        private void StartMission_Click(object sender, EventArgs e)
        {
            int TimeLeft = 60;
            timer.Interval = 60000;
            timer.Start();


            while (TimeLeft > 0)
            {
                TimeLeft--;
                if (TimeLeft <= 0)
                {
                    progressBar1.Value = 0;
                    timer.Stop();
                }
                else
                {
                    progressBar1.Value = stopVal -= 1;
                    System.Threading.Thread.Sleep(1000);
                }
            }
            
        }
    }
}
