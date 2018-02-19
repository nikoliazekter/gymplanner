﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gym_Planner
{
    public partial class AuthorizationForm : Form
    {
        NewGymPlannerDataSetTableAdapters.CheckUserExistsAdapter checkUserExistsAdapter;
        public AuthorizationForm()
        {
            InitializeComponent();
            checkUserExistsAdapter = new NewGymPlannerDataSetTableAdapters.CheckUserExistsAdapter();
            this.LoginTextBox.Text = "admin";
            this.PassTextBox.Text = "admin";
        }

        private void NewAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            NewAccountForm newAccountForm = new NewAccountForm();
            newAccountForm.Show();
        }

        private void SignInButton_Click(object sender, EventArgs e)
        {
            if (checkUserExistsAdapter.CheckUserExists(LoginTextBox.Text, PassTextBox.Text) == 1)
            {
                User user = new User(this.LoginTextBox.Text, this.PassTextBox.Text);
                MainForm mainForm = new MainForm(user);
                mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Неправильний логін чи пароль! Спробуйте ще раз!", "Помилка!");
            }

        }
    }
}
