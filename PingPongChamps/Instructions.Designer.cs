namespace PingPongChamps
{
    partial class Instructions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Instructions));
            this.lblinfotxt = new System.Windows.Forms.Label();
            this.lblInfortxt2 = new System.Windows.Forms.Label();
            this.continueButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblinfotxt
            // 
            this.lblinfotxt.AutoSize = true;
            this.lblinfotxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblinfotxt.Location = new System.Drawing.Point(12, 9);
            this.lblinfotxt.Name = "lblinfotxt";
            this.lblinfotxt.Size = new System.Drawing.Size(654, 117);
            this.lblinfotxt.TabIndex = 0;
            this.lblinfotxt.Text = resources.GetString("lblinfotxt.Text");
            this.lblinfotxt.Click += new System.EventHandler(this.lblinfotxt_Click);
            // 
            // lblInfortxt2
            // 
            this.lblInfortxt2.AutoSize = true;
            this.lblInfortxt2.Location = new System.Drawing.Point(374, 225);
            this.lblInfortxt2.Name = "lblInfortxt2";
            this.lblInfortxt2.Size = new System.Drawing.Size(292, 78);
            this.lblInfortxt2.TabIndex = 4;
            this.lblInfortxt2.Text = resources.GetString("lblInfortxt2.Text");
            this.lblInfortxt2.Click += new System.EventHandler(this.label4_Click);
            // 
            // continueButton
            // 
            this.continueButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.continueButton.Location = new System.Drawing.Point(470, 387);
            this.continueButton.Name = "continueButton";
            this.continueButton.Size = new System.Drawing.Size(186, 51);
            this.continueButton.TabIndex = 10;
            this.continueButton.Text = "Continue";
            this.continueButton.UseVisualStyleBackColor = true;
            this.continueButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::PingPongChamps.Properties.Resources.GameModel;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 129);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(329, 329);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Instructions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 450);
            this.Controls.Add(this.continueButton);
            this.Controls.Add(this.lblInfortxt2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblinfotxt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Instructions";
            this.Text = "Game Instructions";
            this.Load += new System.EventHandler(this.Instructions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblinfotxt;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblInfortxt2;
        private System.Windows.Forms.Button continueButton;
    }
}