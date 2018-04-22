using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dz4_3
{
    public partial class Form1 : Form
    {
        ToolStripMenuItem parent;
        public Form1()
        {
            InitializeComponent();
            parent = new ToolStripMenuItem();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            parent = (ToolStripMenuItem)menuStrip1.Items.Add(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            parent.DropDownItems.Add(textBox2.Text);
        }
    }
}
