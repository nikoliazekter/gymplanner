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
        public MainForm()
        {
            InitializeComponent();
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
            //change right label content
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
    }
}
