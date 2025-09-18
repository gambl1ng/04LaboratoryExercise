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

namespace _04LaboratoryExercise
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("- Before starting thread -");

            Console.WriteLine("- Before starting thread -");

            MyThreadClass threadAObject = new MyThreadClass();

            MyThreadClass threadBObject = new MyThreadClass();

            Thread threadA = new Thread (new ThreadStart(MyThreadClass.Thread1));

            Thread threadB = new Thread (new ThreadStart(MyThreadClass.Thread1));

            threadA.Name = "Thread A";

            threadB.Name = "Thread B";
            threadA.Start();
            threadB.Start();

            threadA.Join();
            threadB.Join();

            label1.Text = "- End of thread -";

        }
    }
}
