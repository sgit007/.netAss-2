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


        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd-MM-yyyy";
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();   
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if(usernameTextBox.Text != "" && reEnterPasswordTextBox.Text!="" && )
        }
    }
}
