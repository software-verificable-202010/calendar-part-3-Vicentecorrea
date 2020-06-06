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

        private static bool CheckIfUserNameExists(string loginUserName)
        {
            foreach (User user in UserController.Users)
            {
                if (loginUserName.Equals(user.UserName))
                {
                    return true;
                }
            }
            return false;
        }

        private void Login(string loginUserName)
        {
            UserController.LoggedUserName = loginUserName;
            this.Hide();
            CalendarForm calendarForm = new CalendarForm();
            calendarForm.ShowDialog();
            this.Close();
        }

        private static void Register(string loginUserName)
        {
            User newUser = new User(loginUserName);
            UserController.SaveUser(newUser);
            MessageBox.Show("Successfully created user");
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            bool isValidUserName = !String.IsNullOrWhiteSpace(userNameTextBox.Text);
            if (isValidUserName)
            {
                string loginUserName = userNameTextBox.Text;
                bool userAlreadyExists = CheckIfUserNameExists(loginUserName);
                if (userAlreadyExists)
                {
                    Login(loginUserName);
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
            bool isValidUserName = !String.IsNullOrWhiteSpace(userNameTextBox.Text);
            if (isValidUserName)
            {
                string loginUserName = userNameTextBox.Text;
                bool userAlreadyExists = CheckIfUserNameExists(loginUserName);
                if (!userAlreadyExists)
                {
                    Register(loginUserName);
                    Login(loginUserName);
                }
                else
                {
                    MessageBox.Show("A user already exists with that userName, choose another username");
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
