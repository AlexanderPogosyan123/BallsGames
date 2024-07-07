namespace BallGameWinFormsApp
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
            createButton = new Button();
            stopButton = new Button();
            ballsCountLabel = new Label();
            label2 = new Label();
            ClearButton = new Button();
            SuspendLayout();
            // 
            // createButton
            // 
            createButton.Location = new Point(12, 12);
            createButton.Name = "createButton";
            createButton.Size = new Size(223, 29);
            createButton.TabIndex = 1;
            createButton.Text = "Создать";
            createButton.UseVisualStyleBackColor = true;
            createButton.Click += createButton_Click;
            // 
            // stopButton
            // 
            stopButton.Location = new Point(271, 13);
            stopButton.Name = "stopButton";
            stopButton.Size = new Size(223, 29);
            stopButton.TabIndex = 2;
            stopButton.Text = "Остановить";
            stopButton.UseVisualStyleBackColor = true;
            stopButton.Click += stopButton_Click;
            // 
            // ballsCountLabel
            // 
            ballsCountLabel.AutoSize = true;
            ballsCountLabel.Location = new Point(720, 17);
            ballsCountLabel.Name = "ballsCountLabel";
            ballsCountLabel.Size = new Size(17, 20);
            ballsCountLabel.TabIndex = 3;
            ballsCountLabel.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(548, 17);
            label2.Name = "label2";
            label2.Size = new Size(124, 20);
            label2.TabIndex = 4;
            label2.Text = "Кол-во шариков";
            // 
            // ClearButton
            // 
            ClearButton.Location = new Point(12, 62);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(223, 29);
            ClearButton.TabIndex = 5;
            ClearButton.Text = "Очистить";
            ClearButton.UseVisualStyleBackColor = true;
            ClearButton.Click += ClearButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(800, 450);
            Controls.Add(ClearButton);
            Controls.Add(label2);
            Controls.Add(ballsCountLabel);
            Controls.Add(stopButton);
            Controls.Add(createButton);
            Name = "MainForm";
            Text = "Balls";
            Load += MainForm_Load;
            MouseDown += MainForm_MouseDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button createButton;
        private Button stopButton;
        private Label ballsCountLabel;
        private Label label2;
        private Button ClearButton;
    }
}
