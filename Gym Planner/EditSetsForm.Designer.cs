namespace Gym_Planner
{
    partial class EditSetsForm
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
            this.AddApproachButton = new System.Windows.Forms.Button();
            this.RemoveApproachButton = new System.Windows.Forms.Button();
            this.RepsListView = new System.Windows.Forms.ListView();
            this.Reps = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Weight = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DoneButton = new System.Windows.Forms.Button();
            this.RepsLabel = new System.Windows.Forms.Label();
            this.WeightLabel = new System.Windows.Forms.Label();
            this.WeightTextBox = new System.Windows.Forms.TextBox();
            this.RepsTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // AddApproachButton
            // 
            this.AddApproachButton.Location = new System.Drawing.Point(232, 333);
            this.AddApproachButton.Name = "AddApproachButton";
            this.AddApproachButton.Size = new System.Drawing.Size(119, 45);
            this.AddApproachButton.TabIndex = 0;
            this.AddApproachButton.Text = "Додати підхід";
            this.AddApproachButton.UseVisualStyleBackColor = true;
            // 
            // RemoveApproachButton
            // 
            this.RemoveApproachButton.Location = new System.Drawing.Point(232, 384);
            this.RemoveApproachButton.Name = "RemoveApproachButton";
            this.RemoveApproachButton.Size = new System.Drawing.Size(119, 45);
            this.RemoveApproachButton.TabIndex = 1;
            this.RemoveApproachButton.Text = "Видалити підхід";
            this.RemoveApproachButton.UseVisualStyleBackColor = true;
            // 
            // RepsListView
            // 
            this.RepsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Reps,
            this.Weight});
            this.RepsListView.Location = new System.Drawing.Point(12, 12);
            this.RepsListView.Name = "RepsListView";
            this.RepsListView.Size = new System.Drawing.Size(433, 315);
            this.RepsListView.TabIndex = 2;
            this.RepsListView.UseCompatibleStateImageBehavior = false;
            // 
            // Reps
            // 
            this.Reps.Text = "Кількість повторів";
            // 
            // Weight
            // 
            this.Weight.Text = "Вага";
            // 
            // DoneButton
            // 
            this.DoneButton.Location = new System.Drawing.Point(357, 333);
            this.DoneButton.Name = "DoneButton";
            this.DoneButton.Size = new System.Drawing.Size(88, 96);
            this.DoneButton.TabIndex = 3;
            this.DoneButton.Text = "Готово!";
            this.DoneButton.UseVisualStyleBackColor = true;
            this.DoneButton.Click += new System.EventHandler(this.DoneButton_Click);
            // 
            // RepsLabel
            // 
            this.RepsLabel.AutoSize = true;
            this.RepsLabel.Location = new System.Drawing.Point(12, 350);
            this.RepsLabel.Name = "RepsLabel";
            this.RepsLabel.Size = new System.Drawing.Size(105, 17);
            this.RepsLabel.TabIndex = 4;
            this.RepsLabel.Text = "Повтори, разів";
            // 
            // WeightLabel
            // 
            this.WeightLabel.AutoSize = true;
            this.WeightLabel.Location = new System.Drawing.Point(12, 398);
            this.WeightLabel.Name = "WeightLabel";
            this.WeightLabel.Size = new System.Drawing.Size(58, 17);
            this.WeightLabel.TabIndex = 5;
            this.WeightLabel.Text = "Вага, кг";
            // 
            // WeightTextBox
            // 
            this.WeightTextBox.Location = new System.Drawing.Point(123, 402);
            this.WeightTextBox.Name = "WeightTextBox";
            this.WeightTextBox.Size = new System.Drawing.Size(100, 22);
            this.WeightTextBox.TabIndex = 6;
            // 
            // RepsTextBox
            // 
            this.RepsTextBox.Location = new System.Drawing.Point(123, 350);
            this.RepsTextBox.Name = "RepsTextBox";
            this.RepsTextBox.Size = new System.Drawing.Size(100, 22);
            this.RepsTextBox.TabIndex = 7;
            // 
            // SetApproachesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 436);
            this.Controls.Add(this.RepsTextBox);
            this.Controls.Add(this.WeightTextBox);
            this.Controls.Add(this.WeightLabel);
            this.Controls.Add(this.RepsLabel);
            this.Controls.Add(this.DoneButton);
            this.Controls.Add(this.RepsListView);
            this.Controls.Add(this.RemoveApproachButton);
            this.Controls.Add(this.AddApproachButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "SetApproachesForm";
            this.Text = "Редагування підходів";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddApproachButton;
        private System.Windows.Forms.Button RemoveApproachButton;
        private System.Windows.Forms.ListView RepsListView;
        private System.Windows.Forms.ColumnHeader Reps;
        private System.Windows.Forms.ColumnHeader Weight;
        private System.Windows.Forms.Button DoneButton;
        private System.Windows.Forms.Label RepsLabel;
        private System.Windows.Forms.Label WeightLabel;
        private System.Windows.Forms.TextBox WeightTextBox;
        private System.Windows.Forms.TextBox RepsTextBox;
    }
}