using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Reversi
{
    public partial class InputApponentMove : Form
    {
        public InputApponentMove()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void InputApponentMove_FormClosed(object sender, FormClosedEventArgs e)
        {

            int[] a  = new int[2];
            a [0] = int.Parse(this.textBox1.Text);
            a[1] = int.Parse(this.textBox2.Text);

          
        }
    }
}
