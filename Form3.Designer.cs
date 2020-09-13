namespace SchoolManagementSystem
{
    partial class Form3
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
            this.insertrecord = new System.Windows.Forms.Button();
            this.searchrecord = new System.Windows.Forms.Button();
            this.updaterecord = new System.Windows.Forms.Button();
            this.deleterecord = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Forte", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = global::SchoolManagementSystem.Properties.Resources.pic;
            this.label1.Location = new System.Drawing.Point(138, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(534, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "WELCOME TO SCHOOL MANAGEMENT SYSTEM";
            // 
            // insertrecord
            // 
            this.insertrecord.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertrecord.Location = new System.Drawing.Point(277, 61);
            this.insertrecord.Name = "insertrecord";
            this.insertrecord.Size = new System.Drawing.Size(229, 41);
            this.insertrecord.TabIndex = 5;
            this.insertrecord.Text = "INSERT";
            this.insertrecord.UseVisualStyleBackColor = true;
            this.insertrecord.Click += new System.EventHandler(this.insertrecord_Click);
            // 
            // searchrecord
            // 
            this.searchrecord.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchrecord.Location = new System.Drawing.Point(277, 134);
            this.searchrecord.Name = "searchrecord";
            this.searchrecord.Size = new System.Drawing.Size(229, 41);
            this.searchrecord.TabIndex = 6;
            this.searchrecord.Text = "SEARCH";
            this.searchrecord.UseVisualStyleBackColor = true;
            this.searchrecord.Click += new System.EventHandler(this.searchrecord_Click);
            // 
            // updaterecord
            // 
            this.updaterecord.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updaterecord.Location = new System.Drawing.Point(277, 205);
            this.updaterecord.Name = "updaterecord";
            this.updaterecord.Size = new System.Drawing.Size(229, 41);
            this.updaterecord.TabIndex = 7;
            this.updaterecord.Text = "UPDATE";
            this.updaterecord.UseVisualStyleBackColor = true;
            this.updaterecord.Click += new System.EventHandler(this.updaterecord_Click);
            // 
            // deleterecord
            // 
            this.deleterecord.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleterecord.Location = new System.Drawing.Point(277, 277);
            this.deleterecord.Name = "deleterecord";
            this.deleterecord.Size = new System.Drawing.Size(229, 41);
            this.deleterecord.TabIndex = 8;
            this.deleterecord.Text = "DELETE";
            this.deleterecord.UseVisualStyleBackColor = true;
            this.deleterecord.Click += new System.EventHandler(this.deleterecord_Click);
            // 
            // back
            // 
            this.back.Font = new System.Drawing.Font("Bauhaus 93", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.Location = new System.Drawing.Point(43, 317);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(131, 41);
            this.back.TabIndex = 22;
            this.back.Text = "BACK";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // close
            // 
            this.close.Font = new System.Drawing.Font("Bauhaus 93", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.Location = new System.Drawing.Point(561, 317);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(131, 41);
            this.close.TabIndex = 23;
            this.close.Text = "CLOSE";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SchoolManagementSystem.Properties.Resources.pic1;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.close);
            this.Controls.Add(this.back);
            this.Controls.Add(this.deleterecord);
            this.Controls.Add(this.updaterecord);
            this.Controls.Add(this.searchrecord);
            this.Controls.Add(this.insertrecord);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form3";
            this.Text = "SchoolManagementSystem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button insertrecord;
        private System.Windows.Forms.Button searchrecord;
        private System.Windows.Forms.Button updaterecord;
        private System.Windows.Forms.Button deleterecord;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button close;
    }
}