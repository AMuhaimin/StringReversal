namespace StringReversal
{
    partial class Main
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
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.grpOutput = new System.Windows.Forms.GroupBox();
            this.lbTotal = new System.Windows.Forms.Label();
            this.lbTotalFix = new System.Windows.Forms.Label();
            this.grpInput = new System.Windows.Forms.GroupBox();
            this.btnRev = new System.Windows.Forms.Button();
            this.btnClr = new System.Windows.Forms.Button();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.lbTotal2 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grpOutput.SuspendLayout();
            this.grpInput.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(6, 49);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOutput.Size = new System.Drawing.Size(510, 151);
            this.txtOutput.TabIndex = 3;
            // 
            // grpOutput
            // 
            this.grpOutput.Controls.Add(this.lbTotal2);
            this.grpOutput.Controls.Add(this.label2);
            this.grpOutput.Controls.Add(this.lbTotal);
            this.grpOutput.Controls.Add(this.lbTotalFix);
            this.grpOutput.Controls.Add(this.txtOutput);
            this.grpOutput.Location = new System.Drawing.Point(18, 186);
            this.grpOutput.Name = "grpOutput";
            this.grpOutput.Size = new System.Drawing.Size(522, 209);
            this.grpOutput.TabIndex = 4;
            this.grpOutput.TabStop = false;
            this.grpOutput.Text = "Output";
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.ForeColor = System.Drawing.Color.Red;
            this.lbTotal.Location = new System.Drawing.Point(137, 26);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(0, 13);
            this.lbTotal.TabIndex = 5;
            // 
            // lbTotalFix
            // 
            this.lbTotalFix.AutoSize = true;
            this.lbTotalFix.Location = new System.Drawing.Point(16, 26);
            this.lbTotalFix.Name = "lbTotalFix";
            this.lbTotalFix.Size = new System.Drawing.Size(116, 13);
            this.lbTotalFix.TabIndex = 4;
            this.lbTotalFix.Text = "Total with whitespace :";
            // 
            // grpInput
            // 
            this.grpInput.Controls.Add(this.btnRev);
            this.grpInput.Controls.Add(this.btnClr);
            this.grpInput.Controls.Add(this.txtInput);
            this.grpInput.Location = new System.Drawing.Point(12, 13);
            this.grpInput.Name = "grpInput";
            this.grpInput.Size = new System.Drawing.Size(522, 167);
            this.grpInput.TabIndex = 5;
            this.grpInput.TabStop = false;
            this.grpInput.Text = "Input";
            // 
            // btnRev
            // 
            this.btnRev.Location = new System.Drawing.Point(181, 127);
            this.btnRev.Name = "btnRev";
            this.btnRev.Size = new System.Drawing.Size(75, 33);
            this.btnRev.TabIndex = 5;
            this.btnRev.Text = "Reverse";
            this.btnRev.UseVisualStyleBackColor = true;
            this.btnRev.Click += new System.EventHandler(this.btnRev_Click);
            // 
            // btnClr
            // 
            this.btnClr.Location = new System.Drawing.Point(287, 127);
            this.btnClr.Name = "btnClr";
            this.btnClr.Size = new System.Drawing.Size(75, 33);
            this.btnClr.TabIndex = 4;
            this.btnClr.Text = "Clear";
            this.btnClr.UseVisualStyleBackColor = true;
            this.btnClr.Click += new System.EventHandler(this.btnClr_Click);
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(6, 34);
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtInput.Size = new System.Drawing.Size(510, 87);
            this.txtInput.TabIndex = 3;
            this.txtInput.TextChanged += new System.EventHandler(this.txtInput_TextChanged);
            // 
            // lbTotal2
            // 
            this.lbTotal2.AutoSize = true;
            this.lbTotal2.ForeColor = System.Drawing.Color.Red;
            this.lbTotal2.Location = new System.Drawing.Point(415, 26);
            this.lbTotal2.Name = "lbTotal2";
            this.lbTotal2.Size = new System.Drawing.Size(0, 13);
            this.lbTotal2.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(278, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Total without whitespace :";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 400);
            this.Controls.Add(this.grpInput);
            this.Controls.Add(this.grpOutput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "String Reversal / Count Char";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.grpOutput.ResumeLayout(false);
            this.grpOutput.PerformLayout();
            this.grpInput.ResumeLayout(false);
            this.grpInput.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.GroupBox grpOutput;
        private System.Windows.Forms.Label lbTotalFix;
        private System.Windows.Forms.GroupBox grpInput;
        private System.Windows.Forms.Button btnRev;
        private System.Windows.Forms.Button btnClr;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label lbTotal2;
        private System.Windows.Forms.Label label2;
    }
}

