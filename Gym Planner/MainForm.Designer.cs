namespace Gym_Planner
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.MainTabControl = new System.Windows.Forms.TabControl();
            this.PersonalInfoTab = new System.Windows.Forms.TabPage();
            this.CalendarTab = new System.Windows.Forms.TabPage();
            this.Calendar = new System.Windows.Forms.MonthCalendar();
            this.ExercisesTab = new System.Windows.Forms.TabPage();
            this.ExercisesTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.ExerciseInfoLabel = new System.Windows.Forms.Label();
            this.ExercisesDataGridView = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.informationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.muscleGroupsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workoutsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exercisesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ExercisesMenuStrip = new System.Windows.Forms.MenuStrip();
            this.AddNewExerciseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RemoveExerciseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StatTab = new System.Windows.Forms.TabPage();
            this.MainTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.StatMenuStrip = new System.Windows.Forms.MenuStrip();
            this.ChooseExToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExerciseStatisticChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.MainTabControl.SuspendLayout();
            this.CalendarTab.SuspendLayout();
            this.ExercisesTab.SuspendLayout();
            this.ExercisesTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExercisesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exercisesBindingSource)).BeginInit();
            this.ExercisesMenuStrip.SuspendLayout();
            this.StatTab.SuspendLayout();
            this.MainTableLayout.SuspendLayout();
            this.StatMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExerciseStatisticChart)).BeginInit();
            this.SuspendLayout();
            // 
            // MainTabControl
            // 
            this.MainTabControl.Controls.Add(this.PersonalInfoTab);
            this.MainTabControl.Controls.Add(this.CalendarTab);
            this.MainTabControl.Controls.Add(this.ExercisesTab);
            this.MainTabControl.Controls.Add(this.StatTab);
            this.MainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTabControl.Location = new System.Drawing.Point(3, 83);
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(818, 396);
            this.MainTabControl.TabIndex = 0;
            // 
            // PersonalInfoTab
            // 
            this.PersonalInfoTab.AutoScroll = true;
            this.PersonalInfoTab.Location = new System.Drawing.Point(4, 25);
            this.PersonalInfoTab.Name = "PersonalInfoTab";
            this.PersonalInfoTab.Padding = new System.Windows.Forms.Padding(3);
            this.PersonalInfoTab.Size = new System.Drawing.Size(810, 367);
            this.PersonalInfoTab.TabIndex = 0;
            this.PersonalInfoTab.Text = "Персональна Інформація";
            this.PersonalInfoTab.UseVisualStyleBackColor = true;
            // 
            // CalendarTab
            // 
            this.CalendarTab.Controls.Add(this.Calendar);
            this.CalendarTab.Location = new System.Drawing.Point(4, 25);
            this.CalendarTab.Name = "CalendarTab";
            this.CalendarTab.Padding = new System.Windows.Forms.Padding(3);
            this.CalendarTab.Size = new System.Drawing.Size(810, 367);
            this.CalendarTab.TabIndex = 1;
            this.CalendarTab.Text = "Календар";
            this.CalendarTab.UseVisualStyleBackColor = true;
            // 
            // Calendar
            // 
            this.Calendar.CalendarDimensions = new System.Drawing.Size(3, 1);
            this.Calendar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Calendar.Location = new System.Drawing.Point(3, 3);
            this.Calendar.Name = "Calendar";
            this.Calendar.TabIndex = 0;
            this.Calendar.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.CalendarDayClicked);
            // 
            // ExercisesTab
            // 
            this.ExercisesTab.Controls.Add(this.ExercisesTableLayoutPanel);
            this.ExercisesTab.Controls.Add(this.ExercisesMenuStrip);
            this.ExercisesTab.Location = new System.Drawing.Point(4, 25);
            this.ExercisesTab.Name = "ExercisesTab";
            this.ExercisesTab.Size = new System.Drawing.Size(810, 367);
            this.ExercisesTab.TabIndex = 2;
            this.ExercisesTab.Text = "Вправи";
            this.ExercisesTab.UseVisualStyleBackColor = true;
            // 
            // ExercisesTableLayoutPanel
            // 
            this.ExercisesTableLayoutPanel.ColumnCount = 2;
            this.ExercisesTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.34568F));
            this.ExercisesTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.65432F));
            this.ExercisesTableLayoutPanel.Controls.Add(this.ExerciseInfoLabel, 1, 0);
            this.ExercisesTableLayoutPanel.Controls.Add(this.ExercisesDataGridView, 0, 0);
            this.ExercisesTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ExercisesTableLayoutPanel.Location = new System.Drawing.Point(0, 28);
            this.ExercisesTableLayoutPanel.Name = "ExercisesTableLayoutPanel";
            this.ExercisesTableLayoutPanel.RowCount = 1;
            this.ExercisesTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ExercisesTableLayoutPanel.Size = new System.Drawing.Size(810, 339);
            this.ExercisesTableLayoutPanel.TabIndex = 2;
            // 
            // ExerciseInfoLabel
            // 
            this.ExerciseInfoLabel.AutoSize = true;
            this.ExerciseInfoLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ExerciseInfoLabel.Location = new System.Drawing.Point(427, 0);
            this.ExerciseInfoLabel.Name = "ExerciseInfoLabel";
            this.ExerciseInfoLabel.Size = new System.Drawing.Size(380, 339);
            this.ExerciseInfoLabel.TabIndex = 1;
            this.ExerciseInfoLabel.Text = "Для інформації про вправу - натисніть на ній у списку зліва";
            // 
            // ExercisesDataGridView
            // 
            this.ExercisesDataGridView.AutoGenerateColumns = false;
            this.ExercisesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ExercisesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ExercisesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.informationDataGridViewTextBoxColumn,
            this.muscleGroupsDataGridViewTextBoxColumn,
            this.workoutsDataGridViewTextBoxColumn});
            this.ExercisesDataGridView.DataSource = this.exercisesBindingSource;
            this.ExercisesDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ExercisesDataGridView.Location = new System.Drawing.Point(3, 3);
            this.ExercisesDataGridView.Name = "ExercisesDataGridView";
            this.ExercisesDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.ExercisesDataGridView.RowHeadersVisible = false;
            this.ExercisesDataGridView.RowTemplate.Height = 24;
            this.ExercisesDataGridView.Size = new System.Drawing.Size(418, 333);
            this.ExercisesDataGridView.TabIndex = 2;
            this.ExercisesDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ExercisesDataGridView_CellContentClick);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Назва";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // informationDataGridViewTextBoxColumn
            // 
            this.informationDataGridViewTextBoxColumn.DataPropertyName = "Information";
            this.informationDataGridViewTextBoxColumn.HeaderText = "Information";
            this.informationDataGridViewTextBoxColumn.Name = "informationDataGridViewTextBoxColumn";
            this.informationDataGridViewTextBoxColumn.Visible = false;
            // 
            // muscleGroupsDataGridViewTextBoxColumn
            // 
            this.muscleGroupsDataGridViewTextBoxColumn.DataPropertyName = "MuscleGroups";
            this.muscleGroupsDataGridViewTextBoxColumn.HeaderText = "Група м\'язів";
            this.muscleGroupsDataGridViewTextBoxColumn.Name = "muscleGroupsDataGridViewTextBoxColumn";
            // 
            // workoutsDataGridViewTextBoxColumn
            // 
            this.workoutsDataGridViewTextBoxColumn.DataPropertyName = "Workouts";
            this.workoutsDataGridViewTextBoxColumn.HeaderText = "Workouts";
            this.workoutsDataGridViewTextBoxColumn.Name = "workoutsDataGridViewTextBoxColumn";
            this.workoutsDataGridViewTextBoxColumn.Visible = false;
            // 
            // exercisesBindingSource
            // 
            this.exercisesBindingSource.DataSource = typeof(LibraryGymPlanner.Exercises);
            this.exercisesBindingSource.CurrentChanged += new System.EventHandler(this.вправиBindingSource_CurrentChanged);
            // 
            // ExercisesMenuStrip
            // 
            this.ExercisesMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ExercisesMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddNewExerciseToolStripMenuItem,
            this.RemoveExerciseToolStripMenuItem});
            this.ExercisesMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.ExercisesMenuStrip.Name = "ExercisesMenuStrip";
            this.ExercisesMenuStrip.Size = new System.Drawing.Size(810, 28);
            this.ExercisesMenuStrip.TabIndex = 1;
            this.ExercisesMenuStrip.Text = "menuStrip1";
            // 
            // AddNewExerciseToolStripMenuItem
            // 
            this.AddNewExerciseToolStripMenuItem.Name = "AddNewExerciseToolStripMenuItem";
            this.AddNewExerciseToolStripMenuItem.Size = new System.Drawing.Size(161, 24);
            this.AddNewExerciseToolStripMenuItem.Text = "Додати нову вправу";
            this.AddNewExerciseToolStripMenuItem.Click += new System.EventHandler(this.AddNewExerciseToolStripMenuItem_Click);
            // 
            // RemoveExerciseToolStripMenuItem
            // 
            this.RemoveExerciseToolStripMenuItem.Name = "RemoveExerciseToolStripMenuItem";
            this.RemoveExerciseToolStripMenuItem.Size = new System.Drawing.Size(140, 24);
            this.RemoveExerciseToolStripMenuItem.Text = "Видалити вправу";
            // 
            // StatTab
            // 
            this.StatTab.Controls.Add(this.ExerciseStatisticChart);
            this.StatTab.Controls.Add(this.StatMenuStrip);
            this.StatTab.Location = new System.Drawing.Point(4, 25);
            this.StatTab.Name = "StatTab";
            this.StatTab.Size = new System.Drawing.Size(810, 367);
            this.StatTab.TabIndex = 3;
            this.StatTab.Text = "Статистика";
            this.StatTab.UseVisualStyleBackColor = true;
            // 
            // MainTableLayout
            // 
            this.MainTableLayout.BackgroundImage = global::Gym_Planner.Properties.Resources.MainFrom;
            this.MainTableLayout.ColumnCount = 1;
            this.MainTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MainTableLayout.Controls.Add(this.MainTabControl, 0, 1);
            this.MainTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTableLayout.Location = new System.Drawing.Point(0, 0);
            this.MainTableLayout.Name = "MainTableLayout";
            this.MainTableLayout.RowCount = 2;
            this.MainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.71018F));
            this.MainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.28982F));
            this.MainTableLayout.Size = new System.Drawing.Size(824, 482);
            this.MainTableLayout.TabIndex = 2;
            // 
            // StatMenuStrip
            // 
            this.StatMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.StatMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ChooseExToolStripMenuItem});
            this.StatMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.StatMenuStrip.Name = "StatMenuStrip";
            this.StatMenuStrip.Size = new System.Drawing.Size(810, 28);
            this.StatMenuStrip.TabIndex = 0;
            this.StatMenuStrip.Text = "menuStrip1";
            // 
            // ChooseExToolStripMenuItem
            // 
            this.ChooseExToolStripMenuItem.Name = "ChooseExToolStripMenuItem";
            this.ChooseExToolStripMenuItem.Size = new System.Drawing.Size(133, 24);
            this.ChooseExToolStripMenuItem.Text = "Вибрати вправу";
            this.ChooseExToolStripMenuItem.Click += new System.EventHandler(this.ChooseExToolStripMenuItem_Click);
            // 
            // ExerciseStatisticChart
            // 
            chartArea1.Name = "ChartArea1";
            this.ExerciseStatisticChart.ChartAreas.Add(chartArea1);
            this.ExerciseStatisticChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.ExerciseStatisticChart.Legends.Add(legend1);
            this.ExerciseStatisticChart.Location = new System.Drawing.Point(0, 28);
            this.ExerciseStatisticChart.Name = "ExerciseStatisticChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.ExerciseStatisticChart.Series.Add(series1);
            this.ExerciseStatisticChart.Size = new System.Drawing.Size(810, 339);
            this.ExerciseStatisticChart.TabIndex = 1;
            this.ExerciseStatisticChart.Text = "chart1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Gym_Planner.Properties.Resources.MainFrom;
            this.ClientSize = new System.Drawing.Size(824, 482);
            this.Controls.Add(this.MainTableLayout);
            this.MainMenuStrip = this.ExercisesMenuStrip;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.MainTabControl.ResumeLayout(false);
            this.CalendarTab.ResumeLayout(false);
            this.ExercisesTab.ResumeLayout(false);
            this.ExercisesTab.PerformLayout();
            this.ExercisesTableLayoutPanel.ResumeLayout(false);
            this.ExercisesTableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExercisesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exercisesBindingSource)).EndInit();
            this.ExercisesMenuStrip.ResumeLayout(false);
            this.ExercisesMenuStrip.PerformLayout();
            this.StatTab.ResumeLayout(false);
            this.StatTab.PerformLayout();
            this.MainTableLayout.ResumeLayout(false);
            this.StatMenuStrip.ResumeLayout(false);
            this.StatMenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExerciseStatisticChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl MainTabControl;
        private System.Windows.Forms.TabPage PersonalInfoTab;
        private System.Windows.Forms.TabPage CalendarTab;
        private System.Windows.Forms.MenuStrip ExercisesMenuStrip;
        private System.Windows.Forms.MonthCalendar Calendar;
        private System.Windows.Forms.TabPage ExercisesTab;
        private System.Windows.Forms.TabPage StatTab;
        private System.Windows.Forms.TableLayoutPanel MainTableLayout;
        private System.Windows.Forms.ToolStripMenuItem AddNewExerciseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RemoveExerciseToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel ExercisesTableLayoutPanel;
        private System.Windows.Forms.Label ExerciseInfoLabel;
        private System.Windows.Forms.DataGridView ExercisesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn назваDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn інформаціяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn групимязівDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn тренуванняDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource exercisesBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn informationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn muscleGroupsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn workoutsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataVisualization.Charting.Chart ExerciseStatisticChart;
        private System.Windows.Forms.MenuStrip StatMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem ChooseExToolStripMenuItem;
    }
}