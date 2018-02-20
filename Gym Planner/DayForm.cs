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
    public partial class DayForm : Form
    {
        public DayForm()
        {
            InitializeComponent();
        }

        public DayForm(DateTime date)
        {
            InitializeComponent();
            this.Text = date.ToShortDateString();
        }

        private void DayForm_Load(object sender, EventArgs e)
        {

        }

        private void AddTrainToolStripMenuItem_Click(object sender, EventArgs e)
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
            
        }

        private void ChangeTrainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditSetsForm editSetsForm = new EditSetsForm();
            editSetsForm.Show();
        }
    }
}
