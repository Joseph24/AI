namespace Reversi
{
    partial class HeadsOpponentInput
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtHeadRow = new System.Windows.Forms.TextBox();
            this.txtHeadCol = new System.Windows.Forms.TextBox();
            this.lblH = new System.Windows.Forms.Label();
            this.lblHeads = new System.Windows.Forms.Label();
            this.lblR = new System.Windows.Forms.Label();
            this.lblC = new System.Windows.Forms.Label();
            this.btnOkHeads = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtHeadRow
            // 
            this.txtHeadRow.Location = new System.Drawing.Point(187, 63);
            this.txtHeadRow.Name = "txtHeadRow";
            this.txtHeadRow.Size = new System.Drawing.Size(86, 20);
            this.txtHeadRow.TabIndex = 0;
            // 
            // txtHeadCol
            // 
            this.txtHeadCol.Location = new System.Drawing.Point(295, 63);
            this.txtHeadCol.Name = "txtHeadCol";
            this.txtHeadCol.Size = new System.Drawing.Size(86, 20);
            this.txtHeadCol.TabIndex = 1;
            // 
            // lblH
            // 
            this.lblH.AutoSize = true;
            this.lblH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblH.Location = new System.Drawing.Point(9, 63);
            this.lblH.Name = "lblH";
            this.lblH.Size = new System.Drawing.Size(146, 20);
            this.lblH.TabIndex = 2;
            this.lblH.Text = "OPPONENT INPUT";
            // 
            // lblHeads
            // 
            this.lblHeads.AutoSize = true;
            this.lblHeads.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeads.Location = new System.Drawing.Point(34, 26);
            this.lblHeads.Name = "lblHeads";
            this.lblHeads.Size = new System.Drawing.Size(89, 25);
            this.lblHeads.TabIndex = 3;
            this.lblHeads.Text = "HEADS";
            // 
            // lblR
            // 
            this.lblR.AutoSize = true;
            this.lblR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblR.Location = new System.Drawing.Point(213, 31);
            this.lblR.Name = "lblR";
            this.lblR.Size = new System.Drawing.Size(41, 20);
            this.lblR.TabIndex = 4;
            this.lblR.Text = "Row";
            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblC.Location = new System.Drawing.Point(305, 30);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(63, 20);
            this.lblC.TabIndex = 5;
            this.lblC.Text = "Column";
            // 
            // btnOkHeads
            // 
            this.btnOkHeads.Location = new System.Drawing.Point(187, 98);
            this.btnOkHeads.Name = "btnOkHeads";
            this.btnOkHeads.Size = new System.Drawing.Size(194, 38);
            this.btnOkHeads.TabIndex = 6;
            this.btnOkHeads.Text = "OK";
            this.btnOkHeads.UseVisualStyleBackColor = true;
            // 
            // HeadsOpponentInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 148);
            this.Controls.Add(this.btnOkHeads);
            this.Controls.Add(this.lblC);
            this.Controls.Add(this.lblR);
            this.Controls.Add(this.lblHeads);
            this.Controls.Add(this.lblH);
            this.Controls.Add(this.txtHeadCol);
            this.Controls.Add(this.txtHeadRow);
            this.Name = "HeadsOpponentInput";
            this.Text = "Opponent Input";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtHeadRow;
        private System.Windows.Forms.TextBox txtHeadCol;
        private System.Windows.Forms.Label lblH;
        private System.Windows.Forms.Label lblHeads;
        private System.Windows.Forms.Label lblR;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.Button btnOkHeads;
    }
}