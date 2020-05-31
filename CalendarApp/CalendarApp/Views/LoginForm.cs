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
        #region Methods
        public LoginForm()
        {
            InitializeComponent();
            UserController.LoadUsers();
        }

        private bool CheckIfUsernameExists(string loginUsername)
        {
            foreach (User user in UserController.Users)
            {
                if (loginUsername.Equals(user.Username))
                {
                    return true;
                }
            }
            return false;
        }

        private void Login(string loginUsername)
        {
            UserController.LoggedUsername = loginUsername;
            this.Hide();
            CalendarForm calendarForm = new CalendarForm();
            calendarForm.ShowDialog();
            this.Close();
        }

        private void Register(string loginUsername)
        {
            User newUser = new User(loginUsername);
            UserController.SaveUser(newUser);
            MessageBox.Show("Successfully created user");
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            bool isValidUsername = !String.IsNullOrWhiteSpace(usernameTextBox.Text);
            if (isValidUsername)
            {
                string loginUsername = usernameTextBox.Text;
                bool userAlreadyExists = CheckIfUsernameExists(loginUsername);
                if (userAlreadyExists)
                {
                    Login(loginUsername);
                }
                else
                {
                    MessageBox.Show("There is no user with that username");
                }
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
                string loginUsername = usernameTextBox.Text;
                bool userAlreadyExists = CheckIfUsernameExists(loginUsername);
                if (!userAlreadyExists)
                {
                    Register(loginUsername);
                    Login(loginUsername);
                }
                else
                {
                    MessageBox.Show("A user already exists with that username, choose another username");
                }
            }
            else
            {
                MessageBox.Show("You should enter a username");
            }
        }
        #endregion
    }
}
