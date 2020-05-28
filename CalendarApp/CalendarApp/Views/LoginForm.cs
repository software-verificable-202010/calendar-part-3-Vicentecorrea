using CalendarApp.Controllers;
using CalendarApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalendarApp.Views
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            UserController.LoadUsers();
        }

        private bool CheckIfUserExists(User userLoggingIn)
        {
            foreach (User user in UserController.Users)
            {
                if (userLoggingIn.Username.Equals(user.Username))
                {
                    return true;
                }
            }
            return false;
        }

        private void Login()
        {
            User userLoggingIn = new User(usernameTextBox.Text);
            bool userAlreadyExists = CheckIfUserExists(userLoggingIn);
            if (userAlreadyExists)
            {
                UserController.LoggedUsername = userLoggingIn.Username;
                this.Hide();
                CalendarForm calendarForm = new CalendarForm();
                calendarForm.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("There is no user with that username");
            }
        }

        private void Register()
        {
            User userRegistering = new User(usernameTextBox.Text);
            bool userAlreadyExists = CheckIfUserExists(userRegistering);
            if (!userAlreadyExists)
            {
                UserController.SaveUser(userRegistering);
                MessageBox.Show("Successfully created user");
                Login();
            }
            else
            {
                MessageBox.Show("A user already exists with that username, choose another username");
            }
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            bool isValidUsername = !String.IsNullOrWhiteSpace(usernameTextBox.Text);
            if (isValidUsername)
            {
                Login();
            }
            else
            {
                MessageBox.Show("You should enter a username");
            }
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            bool isValidUsername = !String.IsNullOrWhiteSpace(usernameTextBox.Text);
            if (isValidUsername)
            {
                Register();
            }
            else
            {
                MessageBox.Show("You should enter a username");
            }
        }
    }
}
