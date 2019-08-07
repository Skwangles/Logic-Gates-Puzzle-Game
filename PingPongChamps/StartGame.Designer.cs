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
            this.button1 = new System.Windows.Forms.Button();
            this.lblhighscoretxt = new System.Windows.Forms.Label();
            this.lbllvl1num = new System.Windows.Forms.Label();
            this.pbhighscorebckgrnd = new System.Windows.Forms.PictureBox();
            this.lblLvl2num = new System.Windows.Forms.Label();
            this.lblLvl3num = new System.Windows.Forms.Label();
            this.lbllvl1txt = new System.Windows.Forms.Label();
            this.lbllvl2txt = new System.Windows.Forms.Label();
            this.lblLvl3txt = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbhighscorebckgrnd)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(185, 12);
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
            this.listBoxlvlselect.Location = new System.Drawing.Point(135, 133);
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
            this.btnExplainsLGbtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnExplainsLGbtn.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.btnExplainsLGbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.btnExplainsLGbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnExplainsLGbtn.Location = new System.Drawing.Point(0, 0);
            this.btnExplainsLGbtn.Name = "btnExplainsLGbtn";
            this.btnExplainsLGbtn.Size = new System.Drawing.Size(79, 440);
            this.btnExplainsLGbtn.TabIndex = 3;
            this.btnExplainsLGbtn.Text = "Logic Gates Explained";
            this.btnExplainsLGbtn.UseVisualStyleBackColor = false;
            this.btnExplainsLGbtn.Click += new System.EventHandler(this.ExplainsLGbtn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RosyBrown;
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.Location = new System.Drawing.Point(384, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 440);
            this.button1.TabIndex = 4;
            this.button1.Text = "Game Instructions";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblhighscoretxt
            // 
            this.lblhighscoretxt.AutoSize = true;
            this.lblhighscoretxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhighscoretxt.Location = new System.Drawing.Point(128, 254);
            this.lblhighscoretxt.Name = "lblhighscoretxt";
            this.lblhighscoretxt.Size = new System.Drawing.Size(180, 39);
            this.lblhighscoretxt.TabIndex = 5;
            this.lblhighscoretxt.Text = "Highscore:";
            // 
            // lbllvl1num
            // 
            this.lbllvl1num.AutoSize = true;
            this.lbllvl1num.BackColor = System.Drawing.Color.White;
            this.lbllvl1num.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllvl1num.Location = new System.Drawing.Point(201, 308);
            this.lbllvl1num.Name = "lbllvl1num";
            this.lbllvl1num.Size = new System.Drawing.Size(60, 31);
            this.lbllvl1num.TabIndex = 6;
            this.lbllvl1num.Text = "N/A";
            // 
            // pbhighscorebckgrnd
            // 
            this.pbhighscorebckgrnd.BackColor = System.Drawing.Color.White;
            this.pbhighscorebckgrnd.Location = new System.Drawing.Point(166, 296);
            this.pbhighscorebckgrnd.Name = "pbhighscorebckgrnd";
            this.pbhighscorebckgrnd.Size = new System.Drawing.Size(98, 132);
            this.pbhighscorebckgrnd.TabIndex = 7;
            this.pbhighscorebckgrnd.TabStop = false;
            // 
            // lblLvl2num
            // 
            this.lblLvl2num.AutoSize = true;
            this.lblLvl2num.BackColor = System.Drawing.Color.White;
            this.lblLvl2num.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLvl2num.Location = new System.Drawing.Point(201, 349);
            this.lblLvl2num.Name = "lblLvl2num";
            this.lblLvl2num.Size = new System.Drawing.Size(60, 31);
            this.lblLvl2num.TabIndex = 8;
            this.lblLvl2num.Text = "N/A";
            // 
            // lblLvl3num
            // 
            this.lblLvl3num.AutoSize = true;
            this.lblLvl3num.BackColor = System.Drawing.Color.White;
            this.lblLvl3num.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLvl3num.Location = new System.Drawing.Point(201, 394);
            this.lblLvl3num.Name = "lblLvl3num";
            this.lblLvl3num.Size = new System.Drawing.Size(60, 31);
            this.lblLvl3num.TabIndex = 9;
            this.lblLvl3num.Text = "N/A";
            // 
            // lbllvl1txt
            // 
            this.lbllvl1txt.AutoSize = true;
            this.lbllvl1txt.Location = new System.Drawing.Point(130, 308);
            this.lbllvl1txt.Name = "lbllvl1txt";
            this.lbllvl1txt.Size = new System.Drawing.Size(30, 13);
            this.lbllvl1txt.TabIndex = 10;
            this.lbllvl1txt.Text = "Lvl 1";
            // 
            // lbllvl2txt
            // 
            this.lbllvl2txt.AutoSize = true;
            this.lbllvl2txt.Location = new System.Drawing.Point(130, 364);
            this.lbllvl2txt.Name = "lbllvl2txt";
            this.lbllvl2txt.Size = new System.Drawing.Size(30, 13);
            this.lbllvl2txt.TabIndex = 11;
            this.lbllvl2txt.Text = "Lvl 2";
            // 
            // lblLvl3txt
            // 
            this.lblLvl3txt.AutoSize = true;
            this.lblLvl3txt.Location = new System.Drawing.Point(130, 412);
            this.lblLvl3txt.Name = "lblLvl3txt";
            this.lblLvl3txt.Size = new System.Drawing.Size(30, 13);
            this.lblLvl3txt.TabIndex = 12;
            this.lblLvl3txt.Text = "Lvl 3";
            // 
            // StartGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 440);
            this.Controls.Add(this.lblLvl3txt);
            this.Controls.Add(this.lbllvl2txt);
            this.Controls.Add(this.lbllvl1txt);
            this.Controls.Add(this.lblLvl3num);
            this.Controls.Add(this.lblLvl2num);
            this.Controls.Add(this.lblhighscoretxt);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnExplainsLGbtn);
            this.Controls.Add(this.lblDiffucltylbl);
            this.Controls.Add(this.listBoxlvlselect);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lbllvl1num);
            this.Controls.Add(this.pbhighscorebckgrnd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "StartGame";
            this.Text = "Logic Gates Game";
            this.Load += new System.EventHandler(this.StartGame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbhighscorebckgrnd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ListBox listBoxlvlselect;
        private System.Windows.Forms.Label lblDiffucltylbl;
        private System.Windows.Forms.Button btnExplainsLGbtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblhighscoretxt;
        private System.Windows.Forms.Label lbllvl1num;
        private System.Windows.Forms.PictureBox pbhighscorebckgrnd;
        private System.Windows.Forms.Label lblLvl2num;
        private System.Windows.Forms.Label lblLvl3num;
        private System.Windows.Forms.Label lbllvl1txt;
        private System.Windows.Forms.Label lbllvl2txt;
        private System.Windows.Forms.Label lblLvl3txt;
    }
}