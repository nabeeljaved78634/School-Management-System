namespace SchoolManagementSystem
{
    partial class Form6
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
            this.updatemarks = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.searchmarks = new System.Windows.Forms.Button();
            this.insertmarks = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Forte", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = global::SchoolManagementSystem.Properties.Resources.pic;
            this.label1.Location = new System.Drawing.Point(121, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(534, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "WELCOME TO SCHOOL MANAGEMENT SYSTEM";
            // 
            // updatemarks
            // 
            this.updatemarks.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatemarks.Location = new System.Drawing.Point(273, 191);
            this.updatemarks.Name = "updatemarks";
            this.updatemarks.Size = new System.Drawing.Size(229, 41);
            this.updatemarks.TabIndex = 35;
            this.updatemarks.Text = "UPDATE MARKS";
            this.updatemarks.UseVisualStyleBackColor = true;
            this.updatemarks.Click += new System.EventHandler(this.updatemarks_Click);
            // 
            // close
            // 
            this.close.Font = new System.Drawing.Font("Bauhaus 93", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.Location = new System.Drawing.Point(552, 236);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(131, 41);
            this.close.TabIndex = 34;
            this.close.Text = "CLOSE";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // back
            // 
            this.back.Font = new System.Drawing.Font("Bauhaus 93", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.Location = new System.Drawing.Point(58, 236);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(131, 41);
            this.back.TabIndex = 33;
            this.back.Text = "BACK";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // searchmarks
            // 
            this.searchmarks.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchmarks.Location = new System.Drawing.Point(273, 118);
            this.searchmarks.Name = "searchmarks";
            this.searchmarks.Size = new System.Drawing.Size(229, 41);
            this.searchmarks.TabIndex = 32;
            this.searchmarks.Text = "SEARCH MARKS";
            this.searchmarks.UseVisualStyleBackColor = true;
            this.searchmarks.Click += new System.EventHandler(this.searchmarks_Click);
            // 
            // insertmarks
            // 
            this.insertmarks.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertmarks.Location = new System.Drawing.Point(273, 58);
            this.insertmarks.Name = "insertmarks";
            this.insertmarks.Size = new System.Drawing.Size(229, 41);
            this.insertmarks.TabIndex = 31;
            this.insertmarks.Text = "INSERT MARKS";
            this.insertmarks.UseVisualStyleBackColor = true;
            this.insertmarks.Click += new System.EventHandler(this.insertmarks_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SchoolManagementSystem.Properties.Resources.pic1;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.updatemarks);
            this.Controls.Add(this.close);
            this.Controls.Add(this.back);
            this.Controls.Add(this.searchmarks);
            this.Controls.Add(this.insertmarks);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form6";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SchoolManagementSystem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button updatemarks;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button searchmarks;
        private System.Windows.Forms.Button insertmarks;
    }
}