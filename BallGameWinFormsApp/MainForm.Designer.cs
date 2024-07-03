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
            SuspendLayout();
            // 
            // createButton
            // 
            createButton.Location = new Point(42, 12);
            createButton.Name = "createButton";
            createButton.Size = new Size(223, 29);
            createButton.TabIndex = 1;
            createButton.Text = "Создать";
            createButton.UseVisualStyleBackColor = true;
            createButton.Click += createButton_Click;
            // 
            // stopButton
            // 
            stopButton.Location = new Point(298, 12);
            stopButton.Name = "stopButton";
            stopButton.Size = new Size(223, 29);
            stopButton.TabIndex = 2;
            stopButton.Text = "Остановить";
            stopButton.UseVisualStyleBackColor = true;
            stopButton.Click += stopButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(800, 450);
            Controls.Add(stopButton);
            Controls.Add(createButton);
            Name = "MainForm";
            Text = "Balls";
            Load += MainForm_Load;
            MouseDown += MainForm_MouseDown;
            ResumeLayout(false);
        }

        #endregion
        private Button createButton;
        private Button stopButton;
    }
}
