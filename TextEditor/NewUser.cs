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

        private void cancelButton_Click(object sender, EventArgs e) //closes the new user menu and returns to login
        {
            this.Hide();   
        }

        private void SubmitButton_Click(object sender, EventArgs e) //store the new user and return to login
        {
            if (usernameTextBox.Text != "" && passwordTextBox.Text != "" && reEnterPasswordTextBox.Text != "" && FirstNameBox.Text != "" && LastNameBox.Text != "" && userTypeComboBox.Text != "")
            {
                if (!containsNumber(FirstNameBox.Text) && !containsNumber(LastNameBox.Text))
                {
                    if (passwordTextBox.Text == reEnterPasswordTextBox.Text)
                    {
                        string user = usernameTextBox.Text + "," + passwordTextBox.Text + "," + userTypeComboBox.Text + "," + FirstNameBox.Text + "," + LastNameBox.Text + "," + dateTimePicker1.Text;
                        saveUser(user);
                        MessageBox.Show("Successfully created", "Congrats!");
                        this.Hide();
                    }
                    else
                    { MessageBox.Show("Password Doesnt Match", "Error"); }
                }
                else
                { MessageBox.Show("Name Cannot Contain Number!!", "Error"); }
            }
            else
            { MessageBox.Show("Please fill out all the details", "Error"); }
        }

        private bool containsNumber(string value) //validation checks
        {
            return value.Any(c => char.IsDigit(c));
        }
        private void saveUser(string user)
        {
            string[] temp = System.IO.File.ReadAllLines("login.txt"); //reads the user details from login.txt
            string[] database = new string[temp.Length+1];
            for(int i = 0; i<temp.Length; i++ )
            {
                database[i] = temp[i];
            }
            database[temp.Length] = user;
            System.IO.File.WriteAllLines("login.txt",database); //writes the new user data into login.txt
        }

    }
}
