
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
            if (colorsComboBox.Text.Trim() != string.Empty)
            {
                Color = colorsComboBox.Text.Trim();

            }
            if (levelsComboBox.Text.Trim() != string.Empty)
            {
                LevelChoice = levelsComboBox.Text.Trim();

            }
            Close();
        }
    }
}
