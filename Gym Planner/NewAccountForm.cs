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
    public partial class NewAccountForm : Form
    {
        NewGymPlannerDataSet newGymPlannerDataSet;
        NewGymPlannerDataSetTableAdapters.UsersTableAdapter usersTableAdapter;
        NewGymPlannerDataSetTableAdapters.CheckUserExistsAdapter checkUserExistsAdapter;
        public NewAccountForm()
        {
            InitializeComponent();
            newGymPlannerDataSet = new NewGymPlannerDataSet();
            usersTableAdapter = new NewGymPlannerDataSetTableAdapters.UsersTableAdapter();
            checkUserExistsAdapter = new NewGymPlannerDataSetTableAdapters.CheckUserExistsAdapter();
        }

        private void CreateAccountButton_Click(object sender, EventArgs e)
        {
            if (checkUserExistsAdapter.CheckLoginExists(LoginTextBox.Text) == 0)
            {
                newGymPlannerDataSet.Users.AddUsersRow(LoginTextBox.Text, PassTextBox.Text, NameTextBox.Text);
                usersTableAdapter.Update(newGymPlannerDataSet);
                this.Close();
            }
            else { MessageBox.Show("Користувач з таким логіном уже існує"); }
        }
    }
}
