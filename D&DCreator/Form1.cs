namespace D_DCreator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void newGameButton_Click(object sender, EventArgs e)
        {
            // Handle the "New Game" button click here.
        }

        private void loadGameButton_Click(object sender, EventArgs e)
        {
            // Handle the "Load Game" button click here.
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm();
            settingsForm.ShowDialog(); // Show the form as a modal dialog.
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Handle the "Exit" button click here.
            Application.Exit(); // This will close the application.
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}