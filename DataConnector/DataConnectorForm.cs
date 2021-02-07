using DataConnectorLibrary;
using DataConnectorLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataConnector
{
    public partial class DataConnectorForm : Form
    {
        public DataConnectorForm()
        {
            InitializeComponent();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                UserModel model = new UserModel();
                model.Username = usernameTextBox.Text;
                model.Password = passwordTextBox.Text;
                model.Email = emailTextBox.Text;

                GlobalConfig.Connections.AddUser(model);
                usernameTextBox.Text = "Username";
                passwordTextBox.Text = "Password";
                emailTextBox.Text = "Email";
                MessageBox.Show("Account Submitted");
            }
            else
            {
                MessageBox.Show("Form not valid");
                usernameTextBox.Text = "Username";
                passwordTextBox.Text = "Password";
                emailTextBox.Text = "Email";
            }
        
        }

        private bool ValidateForm()
        {
            bool isValid = true;
            if (usernameTextBox.Text.Length <= 0 || usernameTextBox.Text == "Username")
            {
                isValid = false;
            }
            if (passwordTextBox.Text.Length <= 0 || passwordTextBox.Text == "Password" )
            {
                isValid = false;
            }
            if (passwordTextBox.Text.Length <= 0 || emailTextBox.Text == "Email")
            {
                isValid = false;
            }

            if(textFileCheckBox.Checked && sqlTextBox.Checked)
            {
                isValid = false;
                MessageBox.Show("Only one save type can be checked");
            }
           
            

            return isValid;
        }

        private void passwordTextBox_Click(object sender, EventArgs e)
        {
            
        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {
            passwordTextBox.UseSystemPasswordChar = true;
        }
    }
}
