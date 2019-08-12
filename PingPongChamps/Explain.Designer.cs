namespace PingPongChamps
{
    partial class Explain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Explain));
            this.lblGatesText = new System.Windows.Forms.Label();
            this.lblOrGate = new System.Windows.Forms.Label();
            this.lblGateNames = new System.Windows.Forms.Label();
            this.lblAndGate = new System.Windows.Forms.Label();
            this.lblNandGate = new System.Windows.Forms.Label();
            this.lblNorGate = new System.Windows.Forms.Label();
            this.lblXorGate = new System.Windows.Forms.Label();
            this.lblXnorGate = new System.Windows.Forms.Label();
            this.lblWarning = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblGatesText
            // 
            this.lblGatesText.AutoSize = true;
            this.lblGatesText.Font = new System.Drawing.Font("Minion Pro", 50F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGatesText.Location = new System.Drawing.Point(12, 9);
            this.lblGatesText.Name = "lblGatesText";
            this.lblGatesText.Size = new System.Drawing.Size(197, 93);
            this.lblGatesText.TabIndex = 0;
            this.lblGatesText.Text = "Gates";
            // 
            // lblOrGate
            // 
            this.lblOrGate.AutoSize = true;
            this.lblOrGate.Location = new System.Drawing.Point(106, 156);
            this.lblOrGate.Name = "lblOrGate";
            this.lblOrGate.Size = new System.Drawing.Size(156, 13);
            this.lblOrGate.TabIndex = 1;
            this.lblOrGate.Text = "Output is ON if either input is on";
            // 
            // lblGateNames
            // 
            this.lblGateNames.AutoSize = true;
            this.lblGateNames.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGateNames.Location = new System.Drawing.Point(1, 136);
            this.lblGateNames.Name = "lblGateNames";
            this.lblGateNames.Size = new System.Drawing.Size(99, 234);
            this.lblGateNames.TabIndex = 2;
            this.lblGateNames.Text = "Or\r\nAnd\r\nNand\r\nNor\r\nXor\r\nXnor\r\n";
            // 
            // lblAndGate
            // 
            this.lblAndGate.AutoSize = true;
            this.lblAndGate.Location = new System.Drawing.Point(106, 190);
            this.lblAndGate.Name = "lblAndGate";
            this.lblAndGate.Size = new System.Drawing.Size(167, 13);
            this.lblAndGate.TabIndex = 3;
            this.lblAndGate.Text = "Output is ON if both inputs are on.";
            this.lblAndGate.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblNandGate
            // 
            this.lblNandGate.AutoSize = true;
            this.lblNandGate.Location = new System.Drawing.Point(106, 231);
            this.lblNandGate.Name = "lblNandGate";
            this.lblNandGate.Size = new System.Drawing.Size(181, 13);
            this.lblNandGate.TabIndex = 4;
            this.lblNandGate.Text = "Output is ON if 1 input is on, or none.\r\n";
            this.lblNandGate.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblNorGate
            // 
            this.lblNorGate.AutoSize = true;
            this.lblNorGate.Location = new System.Drawing.Point(106, 271);
            this.lblNorGate.Name = "lblNorGate";
            this.lblNorGate.Size = new System.Drawing.Size(158, 13);
            this.lblNorGate.TabIndex = 5;
            this.lblNorGate.Text = "Output is ON if no inputs are on.";
            // 
            // lblXorGate
            // 
            this.lblXorGate.AutoSize = true;
            this.lblXorGate.Location = new System.Drawing.Point(106, 310);
            this.lblXorGate.Name = "lblXorGate";
            this.lblXorGate.Size = new System.Drawing.Size(161, 13);
            this.lblXorGate.TabIndex = 6;
            this.lblXorGate.Text = "Output is ON if only 1 input is on.\r\n";
            // 
            // lblXnorGate
            // 
            this.lblXnorGate.AutoSize = true;
            this.lblXnorGate.Location = new System.Drawing.Point(106, 346);
            this.lblXnorGate.Name = "lblXnorGate";
            this.lblXnorGate.Size = new System.Drawing.Size(199, 26);
            this.lblXnorGate.TabIndex = 7;
            this.lblXnorGate.Text = "Output is ON if either, both inputs are on,\r\n or none.\r\n";
            this.lblXnorGate.Click += new System.EventHandler(this.label8_Click);
            // 
            // lblWarning
            // 
            this.lblWarning.AutoSize = true;
            this.lblWarning.ForeColor = System.Drawing.Color.Red;
            this.lblWarning.Location = new System.Drawing.Point(25, 89);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(0, 13);
            this.lblWarning.TabIndex = 9;
            this.lblWarning.Click += new System.EventHandler(this.label10_Click);
            // 
            // Explain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 394);
            this.Controls.Add(this.lblWarning);
            this.Controls.Add(this.lblXnorGate);
            this.Controls.Add(this.lblXorGate);
            this.Controls.Add(this.lblNorGate);
            this.Controls.Add(this.lblNandGate);
            this.Controls.Add(this.lblAndGate);
            this.Controls.Add(this.lblGateNames);
            this.Controls.Add(this.lblOrGate);
            this.Controls.Add(this.lblGatesText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Explain";
            this.Text = "Explain";
            this.Load += new System.EventHandler(this.Explain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGatesText;
        private System.Windows.Forms.Label lblOrGate;
        private System.Windows.Forms.Label lblGateNames;
        private System.Windows.Forms.Label lblAndGate;
        private System.Windows.Forms.Label lblNandGate;
        private System.Windows.Forms.Label lblNorGate;
        private System.Windows.Forms.Label lblXorGate;
        private System.Windows.Forms.Label lblXnorGate;
        private System.Windows.Forms.Label lblWarning;
    }
}