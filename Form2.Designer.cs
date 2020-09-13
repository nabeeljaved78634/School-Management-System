namespace SchoolManagementSystem
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.login = new System.Windows.Forms.Button();
            this.fiance = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.button4 = new System.Windows.Forms.Button();
            this.grades = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Forte", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = global::SchoolManagementSystem.Properties.Resources.pic;
            this.label1.Location = new System.Drawing.Point(122, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(534, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "WELCOME TO SCHOOL MANAGEMENT SYSTEM";
            // 
            // login
            // 
            this.login.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login.Image = global::SchoolManagementSystem.Properties.Resources.eedeCapture;
            this.login.Location = new System.Drawing.Point(112, 79);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(230, 141);
            this.login.TabIndex = 4;
            this.login.Text = "STUDENT RECORD";
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // fiance
            // 
            this.fiance.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fiance.Image = global::SchoolManagementSystem.Properties.Resources.eeeeCapture;
            this.fiance.Location = new System.Drawing.Point(427, 79);
            this.fiance.Name = "fiance";
            this.fiance.Size = new System.Drawing.Size(229, 141);
            this.fiance.TabIndex = 5;
            this.fiance.Text = "FIANCE";
            this.fiance.UseVisualStyleBackColor = true;
            this.fiance.Click += new System.EventHandler(this.fiance_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Image = global::SchoolManagementSystem.Properties.Resources.kkCapture;
            this.button4.Location = new System.Drawing.Point(112, 288);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(230, 141);
            this.button4.TabIndex = 7;
            this.button4.Text = "FACULTY RECORD";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // grades
            // 
            this.grades.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grades.Image = global::SchoolManagementSystem.Properties.Resources.eeeCapture1;
            this.grades.Location = new System.Drawing.Point(427, 288);
            this.grades.Name = "grades";
            this.grades.Size = new System.Drawing.Size(230, 141);
            this.grades.TabIndex = 8;
            this.grades.Text = "GRADES";
            this.grades.UseVisualStyleBackColor = true;
            this.grades.Click += new System.EventHandler(this.grades_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SchoolManagementSystem.Properties.Resources.download__2_;
            this.ClientSize = new System.Drawing.Size(800, 661);
            this.Controls.Add(this.grades);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.fiance);
            this.Controls.Add(this.login);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SchoolMangementSystem";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.Button fiance;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button grades;
    }
}