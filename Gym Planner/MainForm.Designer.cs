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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.MainTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.MainTabControl = new System.Windows.Forms.TabControl();
            this.CalendarTab = new System.Windows.Forms.TabPage();
            this.Calendar = new System.Windows.Forms.MonthCalendar();
            this.ExercisesTab = new System.Windows.Forms.TabPage();
            this.ExercisesTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.ExerciseInfoLabel = new System.Windows.Forms.Label();
            this.ExercisesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumnInfo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exercisesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.newGymPlannerDataSet = new Gym_Planner.NewGymPlannerDataSet();
            this.ExercisesMenuStrip = new System.Windows.Forms.MenuStrip();
            this.AddNewExerciseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RemoveExerciseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StatTab = new System.Windows.Forms.TabPage();
            this.ExerciseStatisticChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.StatMenuStrip = new System.Windows.Forms.MenuStrip();
            this.ChooseExToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MuscleGroupToolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.exercisesTableAdapter = new Gym_Planner.NewGymPlannerDataSetTableAdapters.ExercisesTableAdapter();
            this.recordsByDateAdapter1 = new Gym_Planner.NewGymPlannerDataSetTableAdapters.RecordsByDateAdapter();
            this.MainTableLayout.SuspendLayout();
            this.MainTabControl.SuspendLayout();
            this.CalendarTab.SuspendLayout();
            this.ExercisesTab.SuspendLayout();
            this.ExercisesTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExercisesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exercisesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newGymPlannerDataSet)).BeginInit();
            this.ExercisesMenuStrip.SuspendLayout();
            this.StatTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExerciseStatisticChart)).BeginInit();
            this.StatMenuStrip.SuspendLayout();
            this.SuspendLayout();
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
            // MainTabControl
            // 
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
            this.ExercisesDataGridView.AllowUserToAddRows = false;
            this.ExercisesDataGridView.AllowUserToDeleteRows = false;
            this.ExercisesDataGridView.AllowUserToResizeColumns = false;
            this.ExercisesDataGridView.AllowUserToResizeRows = false;
            this.ExercisesDataGridView.AutoGenerateColumns = false;
            this.ExercisesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ExercisesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ExercisesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumnName,
            this.dataGridViewTextBoxColumnInfo});
            this.ExercisesDataGridView.DataSource = this.exercisesBindingSource;
            this.ExercisesDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ExercisesDataGridView.Location = new System.Drawing.Point(3, 3);
            this.ExercisesDataGridView.Name = "ExercisesDataGridView";
            this.ExercisesDataGridView.ReadOnly = true;
            this.ExercisesDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.ExercisesDataGridView.RowHeadersVisible = false;
            this.ExercisesDataGridView.RowTemplate.Height = 24;
            this.ExercisesDataGridView.Size = new System.Drawing.Size(418, 333);
            this.ExercisesDataGridView.TabIndex = 2;
            this.ExercisesDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ExercisesDataGridView_CellClick);
            this.ExercisesDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ExercisesDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumnName
            // 
            this.dataGridViewTextBoxColumnName.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumnName.HeaderText = "Назва";
            this.dataGridViewTextBoxColumnName.Name = "dataGridViewTextBoxColumnName";
            this.dataGridViewTextBoxColumnName.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumnInfo
            // 
            this.dataGridViewTextBoxColumnInfo.DataPropertyName = "Information";
            this.dataGridViewTextBoxColumnInfo.HeaderText = "Information";
            this.dataGridViewTextBoxColumnInfo.Name = "dataGridViewTextBoxColumnInfo";
            this.dataGridViewTextBoxColumnInfo.ReadOnly = true;
            this.dataGridViewTextBoxColumnInfo.Visible = false;
            // 
            // exercisesBindingSource
            // 
            this.exercisesBindingSource.DataMember = "Exercises";
            this.exercisesBindingSource.DataSource = this.newGymPlannerDataSet;
            this.exercisesBindingSource.CurrentChanged += new System.EventHandler(this.exercisesBindingSource_CurrentChanged);
            // 
            // newGymPlannerDataSet
            // 
            this.newGymPlannerDataSet.DataSetName = "NewGymPlannerDataSet";
            this.newGymPlannerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // ExerciseStatisticChart
            // 
            chartArea2.Name = "ChartArea1";
            this.ExerciseStatisticChart.ChartAreas.Add(chartArea2);
            this.ExerciseStatisticChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.ExerciseStatisticChart.Legends.Add(legend2);
            this.ExerciseStatisticChart.Location = new System.Drawing.Point(0, 32);
            this.ExerciseStatisticChart.Name = "ExerciseStatisticChart";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Series";
            this.ExerciseStatisticChart.Series.Add(series2);
            this.ExerciseStatisticChart.Size = new System.Drawing.Size(810, 335);
            this.ExerciseStatisticChart.TabIndex = 1;
            this.ExerciseStatisticChart.Text = "Статистика";
            title2.Name = "Title";
            this.ExerciseStatisticChart.Titles.Add(title2);
            // 
            // StatMenuStrip
            // 
            this.StatMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.StatMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ChooseExToolStripMenuItem,
            this.MuscleGroupToolStripComboBox});
            this.StatMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.StatMenuStrip.Name = "StatMenuStrip";
            this.StatMenuStrip.Size = new System.Drawing.Size(810, 32);
            this.StatMenuStrip.TabIndex = 0;
            this.StatMenuStrip.Text = "menuStrip1";
            // 
            // ChooseExToolStripMenuItem
            // 
            this.ChooseExToolStripMenuItem.Name = "ChooseExToolStripMenuItem";
            this.ChooseExToolStripMenuItem.Size = new System.Drawing.Size(133, 28);
            this.ChooseExToolStripMenuItem.Text = "Вибрати вправу";
            this.ChooseExToolStripMenuItem.Click += new System.EventHandler(this.ChooseExToolStripMenuItem_Click);
            // 
            // MuscleGroupToolStripComboBox
            // 
            this.MuscleGroupToolStripComboBox.Name = "MuscleGroupToolStripComboBox";
            this.MuscleGroupToolStripComboBox.Size = new System.Drawing.Size(121, 28);
            this.MuscleGroupToolStripComboBox.SelectedIndexChanged += new System.EventHandler(this.MuscleGroupToolStripComboBox_Click);
            // 
            // exercisesTableAdapter
            // 
            this.exercisesTableAdapter.ClearBeforeFill = true;
            // 
            // recordsByDateAdapter1
            // 
            this.recordsByDateAdapter1.ClearBeforeFill = true;
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
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MainTableLayout.ResumeLayout(false);
            this.MainTabControl.ResumeLayout(false);
            this.CalendarTab.ResumeLayout(false);
            this.ExercisesTab.ResumeLayout(false);
            this.ExercisesTab.PerformLayout();
            this.ExercisesTableLayoutPanel.ResumeLayout(false);
            this.ExercisesTableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExercisesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exercisesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newGymPlannerDataSet)).EndInit();
            this.ExercisesMenuStrip.ResumeLayout(false);
            this.ExercisesMenuStrip.PerformLayout();
            this.StatTab.ResumeLayout(false);
            this.StatTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExerciseStatisticChart)).EndInit();
            this.StatMenuStrip.ResumeLayout(false);
            this.StatMenuStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel MainTableLayout;
        private System.Windows.Forms.DataGridViewTextBoxColumn назваDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn інформаціяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn групимязівDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn тренуванняDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn informationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn muscleGroupsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn workoutsDataGridViewTextBoxColumn;
        private NewGymPlannerDataSet newGymPlannerDataSet;
        private System.Windows.Forms.BindingSource exercisesBindingSource;
        private NewGymPlannerDataSetTableAdapters.ExercisesTableAdapter exercisesTableAdapter;
        private System.Windows.Forms.TabControl MainTabControl;
        private System.Windows.Forms.TabPage CalendarTab;
        private System.Windows.Forms.MonthCalendar Calendar;
        private System.Windows.Forms.TabPage ExercisesTab;
        private System.Windows.Forms.TableLayoutPanel ExercisesTableLayoutPanel;
        private System.Windows.Forms.Label ExerciseInfoLabel;
        private System.Windows.Forms.DataGridView ExercisesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumnInfo;
        private System.Windows.Forms.MenuStrip ExercisesMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem AddNewExerciseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RemoveExerciseToolStripMenuItem;
        private System.Windows.Forms.TabPage StatTab;
        private System.Windows.Forms.DataVisualization.Charting.Chart ExerciseStatisticChart;
        private System.Windows.Forms.MenuStrip StatMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem ChooseExToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox MuscleGroupToolStripComboBox;
        private NewGymPlannerDataSetTableAdapters.RecordsByDateAdapter recordsByDateAdapter1;
    }
}