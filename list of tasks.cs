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
    public partial class list_of_tasks : Form
    {
        public list_of_tasks()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void averge(object sender, EventArgs e)
        {
            task1 obj = new task1();
            this.Hide();
            obj.Show();
        }
    }
}
