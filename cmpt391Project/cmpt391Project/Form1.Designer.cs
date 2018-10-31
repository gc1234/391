namespace cmpt391Project
{
    partial class Form1
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
            this.Instructors = new System.Windows.Forms.Button();
            this.Students = new System.Windows.Forms.Button();
            this.Courses = new System.Windows.Forms.Button();
            this.Semesters = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Instructors
            // 
            this.Instructors.Location = new System.Drawing.Point(114, 101);
            this.Instructors.Name = "Instructors";
            this.Instructors.Size = new System.Drawing.Size(114, 57);
            this.Instructors.TabIndex = 0;
            this.Instructors.Text = "Instructors";
            this.Instructors.UseVisualStyleBackColor = true;
            // 
            // Students
            // 
            this.Students.Location = new System.Drawing.Point(277, 101);
            this.Students.Name = "Students";
            this.Students.Size = new System.Drawing.Size(90, 57);
            this.Students.TabIndex = 1;
            this.Students.Text = "Students";
            this.Students.UseVisualStyleBackColor = true;
            // 
            // Courses
            // 
            this.Courses.Location = new System.Drawing.Point(114, 194);
            this.Courses.Name = "Courses";
            this.Courses.Size = new System.Drawing.Size(114, 52);
            this.Courses.TabIndex = 2;
            this.Courses.Text = "Courses";
            this.Courses.UseVisualStyleBackColor = true;
            // 
            // Semesters
            // 
            this.Semesters.Location = new System.Drawing.Point(277, 194);
            this.Semesters.Name = "Semesters";
            this.Semesters.Size = new System.Drawing.Size(90, 52);
            this.Semesters.TabIndex = 3;
            this.Semesters.Text = "Semesters";
            this.Semesters.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(375, 356);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 4;
            this.button5.Text = "Exit";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 422);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.Semesters);
            this.Controls.Add(this.Courses);
            this.Controls.Add(this.Students);
            this.Controls.Add(this.Instructors);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Instructors;
        private System.Windows.Forms.Button Students;
        private System.Windows.Forms.Button Courses;
        private System.Windows.Forms.Button Semesters;
        private System.Windows.Forms.Button button5;
    }
}

