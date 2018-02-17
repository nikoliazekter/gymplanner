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
    }
}
