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
        private String exerciseName;
        public ExerciseChooseForm()
        {
            InitializeComponent();
        }

        public ExerciseChooseForm(String exerciseName)
        {
            InitializeComponent();
            this.exerciseName = exerciseName;
        }

        private void GetExerciseButton_Click(object sender, EventArgs e)
        {
            //this.exerciseName.
            /*SetApproachesForm newApproachesForm = new SetApproachesForm();
            newApproachesForm.Show();*/
        }
    }
}
