namespace BillyardBallsWinFormsApp
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            LeftSideLabel = new Label();
            DownSideLabel = new Label();
            RightSideLabel = new Label();
            TopSideLabel = new Label();
            SuspendLayout();
            // 
            // LeftSideLabel
            // 
            LeftSideLabel.AutoSize = true;
            LeftSideLabel.Location = new Point(-4, 188);
            LeftSideLabel.Name = "LeftSideLabel";
            LeftSideLabel.Size = new Size(17, 20);
            LeftSideLabel.TabIndex = 0;
            LeftSideLabel.Text = "0";
            // 
            // DownSideLabel
            // 
            DownSideLabel.AutoSize = true;
            DownSideLabel.Location = new Point(380, 412);
            DownSideLabel.Name = "DownSideLabel";
            DownSideLabel.Size = new Size(17, 20);
            DownSideLabel.TabIndex = 1;
            DownSideLabel.Text = "0";
            // 
            // RightSideLabel
            // 
            RightSideLabel.AutoSize = true;
            RightSideLabel.Location = new Point(771, 188);
            RightSideLabel.Name = "RightSideLabel";
            RightSideLabel.Size = new Size(17, 20);
            RightSideLabel.TabIndex = 2;
            RightSideLabel.Text = "0";
            // 
            // TopSideLabel
            // 
            TopSideLabel.AutoSize = true;
            TopSideLabel.Location = new Point(380, 9);
            TopSideLabel.Name = "TopSideLabel";
            TopSideLabel.Size = new Size(17, 20);
            TopSideLabel.TabIndex = 3;
            TopSideLabel.Text = "0";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(TopSideLabel);
            Controls.Add(RightSideLabel);
            Controls.Add(DownSideLabel);
            Controls.Add(LeftSideLabel);
            Name = "MainForm";
            Text = "BillyardForm";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Label LeftSideLabel;
        public Label DownSideLabel;
        public Label RightSideLabel;
        public Label TopSideLabel;
    }
}
