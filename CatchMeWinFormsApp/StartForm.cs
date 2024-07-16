﻿
namespace CatchMeWinFormsApp
{
    public partial class StartForm : Form
    {
        public string Color = "Белый";
        public string LevelChoice = "Легкий";
        public StartForm()
        {
            InitializeComponent();
        }

        private void StartForm_Load(object sender, EventArgs e)
        {

        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            bool t = true;

            if (colorsComboBox.SelectedIndex == -1)
            {
                errorProvider1.SetError(colorsComboBox, "Выберите значение!");
                t = false;
            }
            if (levelsComboBox.SelectedIndex == -1)
            {
                errorProvider1.SetError(levelsComboBox, "Выберите значение!");
                t = false;

            }

            if (!t)
            {
                return;
            }

            Hide();
        }

        private void StartForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();

            }
        }
    }
}
