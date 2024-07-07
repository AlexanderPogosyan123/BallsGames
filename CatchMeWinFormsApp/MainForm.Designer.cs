namespace CatchMeWinFormsApp
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
            clearButton = new Button();
            label2 = new Label();
            ballsCountLabel = new Label();
            SuspendLayout();
            // 
            // createButton
            // 
            createButton.Location = new Point(72, 32);
            createButton.Name = "createButton";
            createButton.Size = new Size(94, 29);
            createButton.TabIndex = 0;
            createButton.Text = "Создать";
            createButton.UseVisualStyleBackColor = true;
            // 
            // clearButton
            // 
            clearButton.Location = new Point(548, 27);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(94, 29);
            clearButton.TabIndex = 1;
            clearButton.Text = "Очистить";
            clearButton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(233, 36);
            label2.Name = "label2";
            label2.Size = new Size(124, 20);
            label2.TabIndex = 5;
            label2.Text = "Кол-во шариков";
            // 
            // ballsCountLabel
            // 
            ballsCountLabel.AutoSize = true;
            ballsCountLabel.Location = new Point(376, 36);
            ballsCountLabel.Name = "ballsCountLabel";
            ballsCountLabel.Size = new Size(17, 20);
            ballsCountLabel.TabIndex = 6;
            ballsCountLabel.Text = "0";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ballsCountLabel);
            Controls.Add(label2);
            Controls.Add(clearButton);
            Controls.Add(createButton);
            Name = "MainForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button createButton;
        private Button clearButton;
        private Label label2;
        private Label ballsCountLabel;
    }
}
