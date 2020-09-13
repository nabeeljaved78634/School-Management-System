namespace SchoolManagementSystem
{
    partial class Form5
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
            this.close = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.searchfee = new System.Windows.Forms.Button();
            this.insertfee = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.updatefee = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // close
            // 
            this.close.Font = new System.Drawing.Font("Bauhaus 93", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.Location = new System.Drawing.Point(530, 239);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(131, 41);
            this.close.TabIndex = 29;
            this.close.Text = "CLOSE";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // back
            // 
            this.back.Font = new System.Drawing.Font("Bauhaus 93", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.Location = new System.Drawing.Point(36, 239);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(131, 41);
            this.back.TabIndex = 28;
            this.back.Text = "BACK";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // searchfee
            // 
            this.searchfee.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchfee.Location = new System.Drawing.Point(251, 121);
            this.searchfee.Name = "searchfee";
            this.searchfee.Size = new System.Drawing.Size(229, 41);
            this.searchfee.TabIndex = 26;
            this.searchfee.Text = "SEARCH FIANCE";
            this.searchfee.UseVisualStyleBackColor = true;
            this.searchfee.Click += new System.EventHandler(this.searchfee_Click);
            // 
            // insertfee
            // 
            this.insertfee.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertfee.Location = new System.Drawing.Point(251, 61);
            this.insertfee.Name = "insertfee";
            this.insertfee.Size = new System.Drawing.Size(229, 41);
            this.insertfee.TabIndex = 25;
            this.insertfee.Text = "INSERT FIANCE";
            this.insertfee.UseVisualStyleBackColor = true;
            this.insertfee.Click += new System.EventHandler(this.insertfee_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Forte", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = global::SchoolManagementSystem.Properties.Resources.pic;
            this.label1.Location = new System.Drawing.Point(112, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(534, 26);
            this.label1.TabIndex = 24;
            this.label1.Text = "WELCOME TO SCHOOL MANAGEMENT SYSTEM";
            // 
            // updatefee
            // 
            this.updatefee.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatefee.Location = new System.Drawing.Point(251, 194);
            this.updatefee.Name = "updatefee";
            this.updatefee.Size = new System.Drawing.Size(229, 41);
            this.updatefee.TabIndex = 30;
            this.updatefee.Text = "UPDATE FIANCE";
            this.updatefee.UseVisualStyleBackColor = true;
            this.updatefee.Click += new System.EventHandler(this.updatefee_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SchoolManagementSystem.Properties.Resources.pic1;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.updatefee);
            this.Controls.Add(this.close);
            this.Controls.Add(this.back);
            this.Controls.Add(this.searchfee);
            this.Controls.Add(this.insertfee);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SchoolManagementSystem";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button searchfee;
        private System.Windows.Forms.Button insertfee;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button updatefee;
    }
}