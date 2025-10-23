namespace LabGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ColourCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            messageTextBox.ForeColor = Color.Red;
        }
    }
}
