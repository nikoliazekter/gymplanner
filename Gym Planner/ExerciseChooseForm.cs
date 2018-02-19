using System;
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
    public partial class ExerciseChooseForm : Form
    {
        public string exerciseName;
        public ExerciseChooseForm()
        {
            InitializeComponent();

            try
            {
                DataTable dataTable = this.exercisesNameTableAdapter.GetData();
                this.ExercisesListBox.DisplayMember = dataTable.Columns[0].ToString();
                this.ExercisesListBox.ValueMember = dataTable.Columns[0].ToString();
                this.ExercisesListBox.DataSource = dataTable;
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void GetExerciseButton_Click(object sender, EventArgs e)
        {
            if (this.ExercisesListBox.SelectedItems.Count != 0)
            {
                this.exerciseName = this.ExercisesListBox.SelectedValue.ToString();
                this.Hide();
                return;
            }
            foreach (System.Data.DataRowView exercise in this.ExercisesListBox.Items)
                if (exercise[0].ToString() == this.ExerciseNameTExtBox.Text)
                {
                    this.exerciseName = this.ExercisesListBox.SelectedValue.ToString();
                    this.Hide();
                    return;
                }
            MessageBox.Show("\t\tТакої вправи немає!\n\r Будь ласка, виберіть зі списку, чи введіть правильну назву вправи! :)", "Помилка");
        }

        private void ExerciseNameTExtBox_TextChanged(object sender, EventArgs e)
        {
            this.ExercisesListBox.ClearSelected();
        }
    }
}
