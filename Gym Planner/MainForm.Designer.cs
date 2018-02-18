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
            this.MainTabControl = new System.Windows.Forms.TabControl();
            this.PersonalInfoTab = new System.Windows.Forms.TabPage();
            this.CalendarTab = new System.Windows.Forms.TabPage();
            this.Calendar = new System.Windows.Forms.MonthCalendar();
            this.ExercisesTab = new System.Windows.Forms.TabPage();
            this.ExercisesTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.ExerciseInfoLabel = new System.Windows.Forms.Label();
            this.ExercisesDataGridView = new System.Windows.Forms.DataGridView();
            this.назваDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.інформаціяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.групимязівDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.тренуванняDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.вправиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ExercisesMenuStrip = new System.Windows.Forms.MenuStrip();
            this.AddNewExerciseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RemoveExerciseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StatTab = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.MainTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.MainTabControl.SuspendLayout();
            this.CalendarTab.SuspendLayout();
            this.ExercisesTab.SuspendLayout();
            this.ExercisesTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExercisesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.вправиBindingSource)).BeginInit();
            this.ExercisesMenuStrip.SuspendLayout();
            this.StatTab.SuspendLayout();
            this.MainTableLayout.SuspendLayout();
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
            this.назваDataGridViewTextBoxColumn,
            this.інформаціяDataGridViewTextBoxColumn,
            this.групимязівDataGridViewTextBoxColumn,
            this.тренуванняDataGridViewTextBoxColumn});
            this.ExercisesDataGridView.DataSource = this.вправиBindingSource;
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
            // назваDataGridViewTextBoxColumn
            // 
            this.назваDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.назваDataGridViewTextBoxColumn.DataPropertyName = "Назва";
            this.назваDataGridViewTextBoxColumn.HeaderText = "Назва";
            this.назваDataGridViewTextBoxColumn.Name = "назваDataGridViewTextBoxColumn";
            this.назваDataGridViewTextBoxColumn.Width = 77;
            // 
            // інформаціяDataGridViewTextBoxColumn
            // 
            this.інформаціяDataGridViewTextBoxColumn.DataPropertyName = "Інформація";
            this.інформаціяDataGridViewTextBoxColumn.HeaderText = "Інформація";
            this.інформаціяDataGridViewTextBoxColumn.Name = "інформаціяDataGridViewTextBoxColumn";
            this.інформаціяDataGridViewTextBoxColumn.Visible = false;
            // 
            // групимязівDataGridViewTextBoxColumn
            // 
            this.групимязівDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.групимязівDataGridViewTextBoxColumn.DataPropertyName = "Групи_м_язів";
            this.групимязівDataGridViewTextBoxColumn.HeaderText = "М\'язова група";
            this.групимязівDataGridViewTextBoxColumn.Name = "групимязівDataGridViewTextBoxColumn";
            this.групимязівDataGridViewTextBoxColumn.Width = 129;
            // 
            // тренуванняDataGridViewTextBoxColumn
            // 
            this.тренуванняDataGridViewTextBoxColumn.DataPropertyName = "Тренування";
            this.тренуванняDataGridViewTextBoxColumn.HeaderText = "Тренування";
            this.тренуванняDataGridViewTextBoxColumn.Name = "тренуванняDataGridViewTextBoxColumn";
            this.тренуванняDataGridViewTextBoxColumn.Visible = false;
            // 
            // вправиBindingSource
            // 
            this.вправиBindingSource.DataSource = typeof(LibraryGymPlanner.Exercises);
            this.вправиBindingSource.CurrentChanged += new System.EventHandler(this.вправиBindingSource_CurrentChanged);
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
            this.StatTab.Controls.Add(this.tableLayoutPanel1);
            this.StatTab.Controls.Add(this.label2);
            this.StatTab.Controls.Add(this.label1);
            this.StatTab.Controls.Add(this.listView1);
            this.StatTab.Controls.Add(this.textBox1);
            this.StatTab.Location = new System.Drawing.Point(4, 25);
            this.StatTab.Name = "StatTab";
            this.StatTab.Size = new System.Drawing.Size(810, 367);
            this.StatTab.TabIndex = 3;
            this.StatTab.Text = "Статистика";
            this.StatTab.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(465, 119);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(51, 108);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(121, 97);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(74, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 0;
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
            ((System.ComponentModel.ISupportInitialize)(this.вправиBindingSource)).EndInit();
            this.ExercisesMenuStrip.ResumeLayout(false);
            this.ExercisesMenuStrip.PerformLayout();
            this.StatTab.ResumeLayout(false);
            this.StatTab.PerformLayout();
            this.MainTableLayout.ResumeLayout(false);
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView ExercisesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn назваDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn інформаціяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn групимязівDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn тренуванняDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource вправиBindingSource;
    }
}