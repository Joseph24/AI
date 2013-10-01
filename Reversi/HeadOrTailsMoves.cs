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
    public partial class HeadOrTailsMoves : Form
    {
        public HeadOrTailsMoves()
        {
            InitializeComponent();
        }

        public String headsInputRow { get; set; }
        public String headsInputCol { get; set; }

        public String tailsInputRow1 { get; set; }
        public String tailsInputRow2 { get; set; }
        public String tailsInputCol1 { get; set; }
        public String tailsInputCol2 { get; set; }

        private void btnHeadsMove_Click(object sender, EventArgs e)
        {
           // this.headsInputRow = txtHeadRow.Text;
            this.Close();
            HeadsOpponentInput hoi = new HeadsOpponentInput();
            hoi.Show();
        }

        private void HeadOrTailsMoves_Load(object sender, EventArgs e)
        {
            this.Close();
            HeadsOpponentInput hoi = new HeadsOpponentInput();
            hoi.Show();
        }


    }
}
