
namespace CatchMeWinFormsApp
{
    public enum Level
    {
        easy,
        medium,
        hard
    }

    public enum Color
    {
        black,
        white,
        red,
        blue
    }
    public partial class StartForm : Form
    {
      
        public Color ColorChoice;
        public  Level LevelChoice;
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
            else
            {
                ColorChoice = (Color)colorsComboBox.SelectedIndex;
                LevelChoice = (Level)levelsComboBox.SelectedIndex;
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
