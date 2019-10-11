﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace TextEditor
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e) //exits the form
        {
            this.Close(); 
        }

        private void loginButton_Click(object sender, EventArgs e) //logs the user in
        {
            
            try
            {
                string[] lines = System.IO.File.ReadAllLines("login.txt"); //reads the user details from login.txt

                foreach (string set in lines)
                {
                    string[] splitter = set.Split(',');
                    if (usernameTextBox.Text == splitter[0] && passwordTextBox.Text == splitter[1])
                    {
                        TextFile ss = new TextFile(splitter);
                        this.Hide();
                        ss.ShowDialog();
                        this.Show();
                    }
                }
            }
            catch (FileNotFoundException a)
            {
                Console.WriteLine(a.Message);
                Console.ReadKey();
            }
        }

        private void newUserButton_Click(object sender, EventArgs e) //opens new user form
        {
            NewUser n = new NewUser();
            n.Show();
        }
    }
}
