namespace LabGUI
{
    partial class Form1
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
            ColourCheckBox = new CheckBox();
            messageTextBox = new TextBox();
            SuspendLayout();
            // 
            // ColourCheckBox
            // 
            ColourCheckBox.AutoSize = true;
            ColourCheckBox.Location = new Point(123, 180);
            ColourCheckBox.Name = "ColourCheckBox";
            ColourCheckBox.Size = new Size(46, 19);
            ColourCheckBox.TabIndex = 0;
            ColourCheckBox.Text = "Red";
            ColourCheckBox.UseVisualStyleBackColor = true;
            ColourCheckBox.CheckedChanged += ColourCheckBox_CheckedChanged;
            // 
            // messageTextBox
            // 
            messageTextBox.Location = new Point(123, 92);
            messageTextBox.Name = "messageTextBox";
            messageTextBox.Size = new Size(100, 23);
            messageTextBox.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(369, 280);
            Controls.Add(messageTextBox);
            Controls.Add(ColourCheckBox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox ColourCheckBox;
        private TextBox messageTextBox;
    }
}
