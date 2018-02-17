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
        public AuthorizationForm()
        {
            InitializeComponent();
        }

        private void NewAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            NewAccountForm newAccountForm = new NewAccountForm();
            newAccountForm.Show();
        }

        private void SignInButton_Click(object sender, EventArgs e)
        {
            if (this.PassTextBox.Text == "")
            {
                MainForm mainForm = new MainForm();
                mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Неправильний логін чи пароль! Спробуйте ще раз!","Помилка!");
            }

        }
    }
}