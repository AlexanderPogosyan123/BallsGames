namespace CatchMeWinFormsApp
{
    partial class StartForm
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            colorsComboBox = new ComboBox();
            OkButton = new Button();
            levelsComboBox = new ComboBox();
            label2 = new Label();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(76, 25);
            label1.Name = "label1";
            label1.Size = new Size(245, 23);
            label1.TabIndex = 0;
            label1.Text = "Выберите цвет фона экрана";
            // 
            // colorsComboBox
            // 
            colorsComboBox.FormattingEnabled = true;
            colorsComboBox.Items.AddRange(new object[] { "Черный", "Белый", "Красный", "Синий" });
            colorsComboBox.Location = new Point(97, 75);
            colorsComboBox.Name = "colorsComboBox";
            colorsComboBox.Size = new Size(151, 28);
            colorsComboBox.TabIndex = 1;
            // 
            // OkButton
            // 
            OkButton.BackColor = SystemColors.ActiveCaption;
            OkButton.FlatStyle = FlatStyle.Popup;
            OkButton.ForeColor = SystemColors.ActiveCaptionText;
            OkButton.Location = new Point(340, 233);
            OkButton.Name = "OkButton";
            OkButton.Size = new Size(128, 29);
            OkButton.TabIndex = 2;
            OkButton.Text = "Начать";
            OkButton.UseVisualStyleBackColor = false;
            OkButton.Click += OkButton_Click;
            // 
            // levelsComboBox
            // 
            levelsComboBox.FormattingEnabled = true;
            levelsComboBox.Items.AddRange(new object[] { "Легкий", "Средний", "Сложный" });
            levelsComboBox.Location = new Point(530, 75);
            levelsComboBox.Name = "levelsComboBox";
            levelsComboBox.Size = new Size(151, 28);
            levelsComboBox.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(516, 25);
            label2.Name = "label2";
            label2.Size = new Size(234, 23);
            label2.TabIndex = 5;
            label2.Text = "Выберите сложность игры";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // StartForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(877, 323);
            Controls.Add(label2);
            Controls.Add(levelsComboBox);
            Controls.Add(OkButton);
            Controls.Add(colorsComboBox);
            Controls.Add(label1);
            Name = "StartForm";
            Text = "StartForm";
            FormClosing += StartForm_FormClosing;
            Load += StartForm_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox colorsComboBox;
        private Button OkButton;
        private ComboBox levelsComboBox;
        private Label label2;
        private ErrorProvider errorProvider1;
    }
}