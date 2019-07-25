namespace PingPongChamps
{
    partial class StartGame
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
            this.btnStart = new System.Windows.Forms.Button();
            this.listBoxlvlselect = new System.Windows.Forms.ListBox();
            this.lblDiffucltylbl = new System.Windows.Forms.Label();
            this.btnExplainsLGbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(176, 12);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(76, 45);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Play";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.Startbtn_Click);
            // 
            // listBoxlvlselect
            // 
            this.listBoxlvlselect.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxlvlselect.FormattingEnabled = true;
            this.listBoxlvlselect.ItemHeight = 25;
            this.listBoxlvlselect.Items.AddRange(new object[] {
            "Level 1 - Or, And.",
            "Level 2 - Nor, Nand.",
            "Level 3 - Xnor, Xor."});
            this.listBoxlvlselect.Location = new System.Drawing.Point(124, 133);
            this.listBoxlvlselect.Name = "listBoxlvlselect";
            this.listBoxlvlselect.Size = new System.Drawing.Size(184, 79);
            this.listBoxlvlselect.TabIndex = 1;
            this.listBoxlvlselect.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // lblDiffucltylbl
            // 
            this.lblDiffucltylbl.AutoSize = true;
            this.lblDiffucltylbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiffucltylbl.Location = new System.Drawing.Point(180, 105);
            this.lblDiffucltylbl.Name = "lblDiffucltylbl";
            this.lblDiffucltylbl.Size = new System.Drawing.Size(84, 25);
            this.lblDiffucltylbl.TabIndex = 2;
            this.lblDiffucltylbl.Text = "Difficulty";
            this.lblDiffucltylbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnExplainsLGbtn
            // 
            this.btnExplainsLGbtn.BackColor = System.Drawing.Color.Teal;
            this.btnExplainsLGbtn.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btnExplainsLGbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnExplainsLGbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnExplainsLGbtn.Location = new System.Drawing.Point(-4, 391);
            this.btnExplainsLGbtn.Name = "btnExplainsLGbtn";
            this.btnExplainsLGbtn.Size = new System.Drawing.Size(467, 49);
            this.btnExplainsLGbtn.TabIndex = 3;
            this.btnExplainsLGbtn.Text = "Logic Gates Explained";
            this.btnExplainsLGbtn.UseVisualStyleBackColor = false;
            this.btnExplainsLGbtn.Click += new System.EventHandler(this.ExplainsLGbtn_Click);
            // 
            // StartGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 438);
            this.Controls.Add(this.btnExplainsLGbtn);
            this.Controls.Add(this.lblDiffucltylbl);
            this.Controls.Add(this.listBoxlvlselect);
            this.Controls.Add(this.btnStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "StartGame";
            this.Text = "StartGame";
            this.Load += new System.EventHandler(this.StartGame_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ListBox listBoxlvlselect;
        private System.Windows.Forms.Label lblDiffucltylbl;
        private System.Windows.Forms.Button btnExplainsLGbtn;
    }
}