using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormstrainng
{
    public partial class task1 : Form
    {
        public task1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sum = 0;
            string[] textBoxLines = textBox1.Lines;
            foreach (string line in textBoxLines)
            {
                sum+= Int32.Parse(line);
                
            }
            MessageBox.Show("sum-->" + sum);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
