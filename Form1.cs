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
            if (ColourCheckBox.Checked == true)
            {
                outputTextBox.Text = messageTextBox.Text; // copy text to outputTextBox
                outputTextBox.ForeColor = Color.Red; // if checkbox checked, turn colour of text to red
                
            }
            else
            {
                messageTextBox.ForeColor = Color.Black; // else the text should be black
            }
        }
    }
}
