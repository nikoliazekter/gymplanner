namespace Gym_Planner
{
    partial class ExerciseChooseForm
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.GetExerciseButton = new System.Windows.Forms.Button();
            this.ExerciseNameLabel = new System.Windows.Forms.Label();
            this.ExerciseFindLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 37);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(262, 22);
            this.textBox1.TabIndex = 0;
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(12, 122);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(402, 327);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // GetExerciseButton
            // 
            this.GetExerciseButton.Location = new System.Drawing.Point(301, 25);
            this.GetExerciseButton.Name = "GetExerciseButton";
            this.GetExerciseButton.Size = new System.Drawing.Size(103, 47);
            this.GetExerciseButton.TabIndex = 2;
            this.GetExerciseButton.Text = "Вибрати";
            this.GetExerciseButton.UseVisualStyleBackColor = true;
            this.GetExerciseButton.Click += new System.EventHandler(this.GetExerciseButton_Click);
            // 
            // ExerciseNameLabel
            // 
            this.ExerciseNameLabel.AutoSize = true;
            this.ExerciseNameLabel.Location = new System.Drawing.Point(12, 9);
            this.ExerciseNameLabel.Name = "ExerciseNameLabel";
            this.ExerciseNameLabel.Size = new System.Drawing.Size(148, 17);
            this.ExerciseNameLabel.TabIndex = 3;
            this.ExerciseNameLabel.Text = "Введіть назву вправи";
            this.ExerciseNameLabel.UseMnemonic = false;
            // 
            // ExerciseFindLabel
            // 
            this.ExerciseFindLabel.AutoSize = true;
            this.ExerciseFindLabel.Location = new System.Drawing.Point(9, 87);
            this.ExerciseFindLabel.Name = "ExerciseFindLabel";
            this.ExerciseFindLabel.Size = new System.Drawing.Size(375, 17);
            this.ExerciseFindLabel.TabIndex = 4;
            this.ExerciseFindLabel.Text = "...або виберіть групу м\'язів та потрібну вправу зі списку";
            // 
            // ExerciseChooseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 461);
            this.Controls.Add(this.ExerciseFindLabel);
            this.Controls.Add(this.ExerciseNameLabel);
            this.Controls.Add(this.GetExerciseButton);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.textBox1);
            this.Name = "ExerciseChooseForm";
            this.Text = "Вибір вправи";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button GetExerciseButton;
        private System.Windows.Forms.Label ExerciseNameLabel;
        private System.Windows.Forms.Label ExerciseFindLabel;
    }
}