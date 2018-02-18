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
using LibraryGymPlanner;

namespace Gym_Planner
{
    public partial class MainForm : Form
    {
        private LibraryGymPlanner.Gym_PlannerEntities entities;
        public MainForm()
        {
            InitializeComponent();
            entities = new LibraryGymPlanner.Gym_PlannerEntities();
            //тут я закінчив
            //entities.Вправи.Load();
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

        private void ChooseExerciseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String exerciseName = "";
            ExerciseChooseForm exerciseChooseForm = new ExerciseChooseForm(exerciseName);
            exerciseChooseForm.Show();
        }
    }
}
