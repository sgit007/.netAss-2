using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextEditor
{
    public partial class NewUser : Form
    {
        public NewUser()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();   
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if (usernameTextBox.Text != "" && passwordTextBox.Text != "" && reEnterPasswordTextBox.Text != "" && FirstNameBox.Text != "" && LastNameBox.Text != "" && userTypeComboBox.Text != "")
            {
                if (passwordTextBox.Text == reEnterPasswordTextBox.Text)
                {
                    if (FirstNameBox == LastNameBox)
                    {
                        var isNumeric = int.TryParse("123", out int n);
                        MessageBox.Show("successful!", "Congrats");
                    }
                }
            }
            else
                MessageBox.Show("Please fill out all the details", "Error"); 
        }
    }
}
