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
        NewGymPlannerDataSetTableAdapters.QueryAdapter queryAdapter;
        NewGymPlannerDataSetTableAdapters.DaysTableAdapter daysAdapter;
        NewGymPlannerDataSetTableAdapters.User_DayTableAdapter userDayAdapter;
        public MainForm(User user)
        {
            this.user = user;
            InitializeComponent();
            queryAdapter = new NewGymPlannerDataSetTableAdapters.QueryAdapter();
            daysAdapter = new NewGymPlannerDataSetTableAdapters.DaysTableAdapter();
            userDayAdapter = new NewGymPlannerDataSetTableAdapters.User_DayTableAdapter();
            if (this.user.isAdmin())
                ExercisesMenuStrip.Visible = true;
            else
                ExercisesMenuStrip.Visible = false;

            DataTable dataTable = (new NewGymPlannerDataSetTableAdapters.MuscleGroupsTableAdapter()).GetData();
            this.MuscleGroupToolStripComboBox.ComboBox.DisplayMember = dataTable.Columns[0].ToString();
            this.MuscleGroupToolStripComboBox.ComboBox.ValueMember = dataTable.Columns[0].ToString();
            this.MuscleGroupToolStripComboBox.ComboBox.DataSource = dataTable;
        }
        public MainForm()
        {
            InitializeComponent();
        }

        private void CalendarDayClicked(object sender, DateRangeEventArgs e)
        {
            DataTable dt = daysAdapter.GetDataByLoginAndDate(user.Login, e.Start.ToShortDateString());
            int id = -1;
            if (dt.Rows.Count == 0)
            {
                NewGymPlannerDataSet.DaysRow dayRow = dataSet.Days.AddDaysRow(e.Start, "");
                daysAdapter.Update(dataSet);
                id = dayRow.ID_Day;

                NewGymPlannerDataSet.User_DayRow userDayRow = dataSet.User_Day.NewUser_DayRow();
                userDayRow.Login = user.Login;
                userDayRow.ID_Day = id;
                dataSet.User_Day.AddUser_DayRow(userDayRow);
                userDayAdapter.Update(dataSet);
            }
            else
            {
                id = (int)dt.Rows[0]["ID_Day"];
            }
            DayForm dayForm = new DayForm(e.Start, id);
            dayForm.Show();
        }

        private void AddNewExerciseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewExerciseForm newExerciseForm = new NewExerciseForm();
            using (NewExerciseForm Window = new NewExerciseForm())
            {
                if (Window.ShowDialog() == DialogResult.OK)
                {
                    this.exercisesTableAdapter.Fill(this.dataSet.Exercises);
                }
            }
        }

        private void ExercisesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //
        }

        private void ChooseExToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string exerciseName;
            using (ExerciseChooseForm Window = new ExerciseChooseForm())
            {
                if (Window.ShowDialog() == DialogResult.OK)
                {
                    exerciseName = Window.exerciseName;
                }
                else
                    return;
            }
            List<string> exercises = new List<string>();
            exercises.Add(exerciseName);
            this.UpdateChart(exercises);
        }

        private void UpdateChart(List<string> exercises)
        {
            this.ExerciseStatisticChart.Series.Clear();
            try
            {
                foreach (string exerciseName in exercises)
                {
                    this.ExerciseStatisticChart.Series.Add(exerciseName);
                    DataTable dataTable = this.recordsByDateAdapter1.GetData(this.user.Login, exerciseName);
                    List<double> weights = new List<double>(dataTable.Rows.Count);
                    foreach (DataRow row in dataTable.Rows)
                        weights.Add(Convert.ToDouble(row[1]));
                    this.ExerciseStatisticChart.Series[exerciseName].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                    this.ExerciseStatisticChart.Series[exerciseName].Points.DataBindY(weights);
                }
                this.ExerciseStatisticChart.ChartAreas[0].AxisX.Title = "Час";
                this.ExerciseStatisticChart.ChartAreas[0].AxisX.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Triangle;
                this.ExerciseStatisticChart.ChartAreas[0].AxisX.LabelStyle.Enabled = false;
                this.ExerciseStatisticChart.ChartAreas[0].AxisY.Title = "Вага";
                this.ExerciseStatisticChart.ChartAreas[0].AxisY.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Triangle;
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }


        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'newGymPlannerDataSet.Exercises' table. You can move, or remove it, as needed.
            this.exercisesTableAdapter.Fill(this.dataSet.Exercises);

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
            if (!this.MuscleGroupToolStripComboBox.Selected)
                return;
            DataTable dataTable = (new NewGymPlannerDataSetTableAdapters.ExerciseByMuscleGroupTableAdapter()).GetData(((System.Data.DataRowView)this.MuscleGroupToolStripComboBox.SelectedItem).Row.ItemArray[0].ToString());

            List<string> exercises = new List<string>();
            foreach (DataRow row in dataTable.Rows)
                exercises.Add(row[0].ToString());
            this.UpdateChart(exercises);
        }

        private void RemoveExerciseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            queryAdapter.DeleteExercise(ExercisesDataGridView.CurrentCell.Value.ToString());
            this.exercisesTableAdapter.Fill(this.dataSet.Exercises);
        }

        private void linkLabelLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            AuthorizationForm authorizationForm = new AuthorizationForm();
            authorizationForm.Show();
        }

        private void FindButton_Click(object sender, EventArgs e)
        {

        }
    }
}
