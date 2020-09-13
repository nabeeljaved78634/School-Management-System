namespace SchoolManagementSystem
{
    partial class SearchMarks
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
            this.label3 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.cms = new System.Windows.Forms.TextBox();
            this.back = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.del = new System.Windows.Forms.Button();
            this.textclass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Forte", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Image = global::SchoolManagementSystem.Properties.Resources.pic;
            this.label3.Location = new System.Drawing.Point(136, 33);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(534, 26);
            this.label3.TabIndex = 28;
            this.label3.Text = "WELCOME TO SCHOOL MANAGEMENT SYSTEM";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(402, 142);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(151, 20);
            this.name.TabIndex = 29;
            // 
            // cms
            // 
            this.cms.Location = new System.Drawing.Point(402, 87);
            this.cms.Name = "cms";
            this.cms.Size = new System.Drawing.Size(151, 20);
            this.cms.TabIndex = 30;
            // 
            // back
            // 
            this.back.Font = new System.Drawing.Font("Bauhaus 93", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.Location = new System.Drawing.Point(77, 280);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(131, 41);
            this.back.TabIndex = 35;
            this.back.Text = "BACK";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // close
            // 
            this.close.Font = new System.Drawing.Font("Bauhaus 93", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.Location = new System.Drawing.Point(585, 280);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(131, 41);
            this.close.TabIndex = 34;
            this.close.Text = "CLOSE";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // del
            // 
            this.del.Font = new System.Drawing.Font("Bauhaus 93", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.del.Location = new System.Drawing.Point(331, 280);
            this.del.Name = "del";
            this.del.Size = new System.Drawing.Size(131, 41);
            this.del.TabIndex = 33;
            this.del.Text = "SEARCH";
            this.del.UseVisualStyleBackColor = true;
            this.del.Click += new System.EventHandler(this.del_Click);
            // 
            // textclass
            // 
            this.textclass.Location = new System.Drawing.Point(402, 201);
            this.textclass.Name = "textclass";
            this.textclass.Size = new System.Drawing.Size(151, 20);
            this.textclass.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(308, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 24);
            this.label4.TabIndex = 37;
            this.label4.Text = "CMS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(308, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 24);
            this.label2.TabIndex = 38;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(308, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 24);
            this.label1.TabIndex = 39;
            this.label1.Text = "Class";
            // 
            // SearchMarks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SchoolManagementSystem.Properties.Resources.pic;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textclass);
            this.Controls.Add(this.back);
            this.Controls.Add(this.close);
            this.Controls.Add(this.del);
            this.Controls.Add(this.cms);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "SearchMarks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SearchMarks";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox cms;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Button del;
        private System.Windows.Forms.TextBox textclass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}