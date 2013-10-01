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
    public partial class PlayAs : Form
    {
        public bool playAsBlack { get; set; }
        public double biasValue { get; set; }
        
        public PlayAs()
        {
            InitializeComponent();
        }

        private void ButtonEventHandler(object sender, EventArgs e)
        {


            Button btn = sender as Button;

            switch (btn.Text)
            {
                case "Ok":
                    {
                        if (this.radioButton2.Checked)
                        {
                            this.playAsBlack = true;
                            this.biasValue = double.Parse(textBox1.Text);
                        }
                        else
                        {
                            this.playAsBlack = false;
                            this.biasValue = double.Parse(textBox1.Text);
                        }
                        this.Close();
                        break;
                    }
                case "Cancel":
                    {
                        break;
                    }
            }
        }

        private void PlayAs_Load(object sender, EventArgs e)
        {

        }

        
    }
}
