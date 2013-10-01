namespace Reversi
{
    partial class HeadOrTailsMoves
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
            this.btnHeadsMove = new System.Windows.Forms.Button();
            this.btnTailsMove = new System.Windows.Forms.Button();
            this.lblMove = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnHeadsMove
            // 
            this.btnHeadsMove.Location = new System.Drawing.Point(47, 59);
            this.btnHeadsMove.Name = "btnHeadsMove";
            this.btnHeadsMove.Size = new System.Drawing.Size(75, 23);
            this.btnHeadsMove.TabIndex = 0;
            this.btnHeadsMove.Text = "HEADS";
            this.btnHeadsMove.UseVisualStyleBackColor = true;
            this.btnHeadsMove.Click += new System.EventHandler(this.btnHeadsMove_Click);
            // 
            // btnTailsMove
            // 
            this.btnTailsMove.Location = new System.Drawing.Point(141, 59);
            this.btnTailsMove.Name = "btnTailsMove";
            this.btnTailsMove.Size = new System.Drawing.Size(75, 23);
            this.btnTailsMove.TabIndex = 1;
            this.btnTailsMove.Text = "TAILS";
            this.btnTailsMove.UseVisualStyleBackColor = true;
            // 
            // lblMove
            // 
            this.lblMove.AutoSize = true;
            this.lblMove.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMove.Location = new System.Drawing.Point(70, 22);
            this.lblMove.Name = "lblMove";
            this.lblMove.Size = new System.Drawing.Size(135, 24);
            this.lblMove.TabIndex = 2;
            this.lblMove.Text = "MOVE BASIS";
            // 
            // HeadOrTailsMoves
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 118);
            this.Controls.Add(this.lblMove);
            this.Controls.Add(this.btnTailsMove);
            this.Controls.Add(this.btnHeadsMove);
            this.Name = "HeadOrTailsMoves";
            this.Text = "HeadOrTailsMoves";
            this.Load += new System.EventHandler(this.HeadOrTailsMoves_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHeadsMove;
        private System.Windows.Forms.Button btnTailsMove;
        private System.Windows.Forms.Label lblMove;
    }
}