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
            button = new Button();
            button1 = new Button();
            moveButton = new Button();
            SuspendLayout();
            // 
            // button
            // 
            button.Location = new Point(135, 12);
            button.Name = "button";
            button.Size = new Size(94, 29);
            button.TabIndex = 0;
            button.Text = "Рисовать шарик";
            button.UseVisualStyleBackColor = true;
            button.Click += button_Click;
            // 
            // button1
            // 
            button1.Location = new Point(375, 12);
            button1.Name = "button1";
            button1.Size = new Size(223, 29);
            button1.TabIndex = 1;
            button1.Text = "Рисовать случайный  шарик";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // moveButton
            // 
            moveButton.Location = new Point(624, 12);
            moveButton.Name = "moveButton";
            moveButton.Size = new Size(94, 29);
            moveButton.TabIndex = 2;
            moveButton.Text = "Двигать";
            moveButton.UseVisualStyleBackColor = true;
            moveButton.Click += moveButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(800, 450);
            Controls.Add(moveButton);
            Controls.Add(button1);
            Controls.Add(button);
            Name = "MainForm";
            Text = "Balls";
            Load += MainForm_Load;
            MouseDown += MainForm_MouseDown;
            ResumeLayout(false);
        }

        #endregion

        private Button button;
        private Button button1;
        private Button moveButton;
    }
}
