namespace D_DCreator
{
    public partial class SettingsForm : Form
    {
        private Color selectedTextColor;

        public SettingsForm()
        {
            InitializeComponent();
            InitializeTextSizeComboBox();
            InitializeResolutionComboBox();

        }

        private void InitializeTextSizeComboBox()
        {
            comboBox1.Items.Add("Small");
            comboBox1.Items.Add("Normal");
            comboBox1.Items.Add("Large");
        }

        private void InitializeResolutionComboBox()
        {
            comboBox2.Items.Add("1920x1080 16:9");
            comboBox2.Items.Add("1280x720 16:9");
            comboBox2.Items.Add("640x480 4:3");
        }

        private void colorPickerButton_Click(object sender, EventArgs e)
        {
            // Open the ColorDialog and set the selectedTextColor.
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                selectedTextColor = colorDialog1.Color;
                // Update a visual representation of the selected color, e.g., a panel.
                // colorPanel.BackColor = selectedTextColor; // Uncomment if you have a colorPanel control.
            }
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            // Save the selected settings (text size, text color, resolution) and close the form.
            string selectedTextSize = comboBox1.SelectedItem.ToString();
            string selectedResolution = comboBox2.SelectedItem.ToString();

            // You can save these settings to a configuration file or another storage mechanism.
            // For now, we'll just display a message with the selected settings.
            MessageBox.Show($"Selected Text Size: {selectedTextSize}\nSelected Text Color: {selectedTextColor}\nSelected Resolution: {selectedResolution}", "Settings Saved");

            this.Close(); // Close the SettingsForm.
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            // Cancel button: Close the form without saving any changes.
            this.Close();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Handle the Resolution ComboBox selection change event.
            string selectedResolution = comboBox2.SelectedItem.ToString();
            // You can perform actions based on the selected resolution here.
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Handle the Text Size ComboBox selection change event.
            string selectedTextSize = comboBox1.SelectedItem.ToString();
            // You can perform actions based on the selected text size here.
        }
    }
}
