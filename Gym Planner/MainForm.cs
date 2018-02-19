using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace Gym_Planner
{
    public partial class MainForm : Form
    {
        private User user;
        public MainForm(User user)
        {
            this.user = user;
            InitializeComponent();
            if (this.user.isAdmin())
                ExercisesMenuStrip.Visible = true;
            else
                ExercisesMenuStrip.Visible = false;

        }
        public MainForm()
        {
            InitializeComponent();
            /*
             * connect muscle group combo box to DB
             * */
        }

        private void CalendarDayClicked(object sender, DateRangeEventArgs e)
        {
            DayForm dayForm = new DayForm(e.Start);
            dayForm.Show();
        }

        private void AddNewExerciseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewExerciseForm newExerciseForm = new NewExerciseForm();
            newExerciseForm.Show();
        }

        private void AllExercisesListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            //
        }

        private void ExercisesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //
        }

        private void вправиBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            //
        }

        private void ChooseExToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string exerciseName;
            using (ExerciseChooseForm Window = new ExerciseChooseForm())
            {
                if (Window.ShowDialog() != DialogResult.OK)
                {
                    return;
                }
                exerciseName = Window.exerciseName;
            }
            /*
             * do some load stuff for our chart
             */
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'newGymPlannerDataSet.Exercises' table. You can move, or remove it, as needed.
            this.exercisesTableAdapter.Fill(this.newGymPlannerDataSet.Exercises);

        }

        private void ExercisesDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.ExercisesDataGridView.SelectedCells.Count != 0)
            {
                int rowIndex = this.ExercisesDataGridView.SelectedCells[0].RowIndex;
                this.ExerciseInfoLabel.Text = this.ExercisesDataGridView.Rows[rowIndex].Cells[1].Value.ToString();
            }
        }

        private void exercisesBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void MuscleGroupToolStripComboBox_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Add Muscle Groups");
        }
    }
}
