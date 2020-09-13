namespace SchoolManagementSystem
{
    partial class DeleteRecord
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
            this.name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.TextBox();
            this.back = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.del = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(362, 120);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(151, 20);
            this.name.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(264, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(230, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Forte", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Image = global::SchoolManagementSystem.Properties.Resources.pic;
            this.label3.Location = new System.Drawing.Point(175, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(534, 26);
            this.label3.TabIndex = 5;
            this.label3.Text = "WELCOME TO SCHOOL MANAGEMENT SYSTEM";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(230, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "CMS";
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(362, 65);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(151, 20);
            this.id.TabIndex = 7;
            // 
            // back
            // 
            this.back.Font = new System.Drawing.Font("Bauhaus 93", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.Location = new System.Drawing.Point(108, 203);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(131, 41);
            this.back.TabIndex = 24;
            this.back.Text = "BACK";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // close
            // 
            this.close.Font = new System.Drawing.Font("Bauhaus 93", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.Location = new System.Drawing.Point(616, 203);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(131, 41);
            this.close.TabIndex = 23;
            this.close.Text = "CLOSE";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.clear_Click);
            // 
            // del
            // 
            this.del.Font = new System.Drawing.Font("Bauhaus 93", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.del.Location = new System.Drawing.Point(362, 203);
            this.del.Name = "del";
            this.del.Size = new System.Drawing.Size(131, 41);
            this.del.TabIndex = 22;
            this.del.Text = "DELETE";
            this.del.UseVisualStyleBackColor = true;
            this.del.Click += new System.EventHandler(this.del_Click);
            // 
            // search
            // 
            this.search.Font = new System.Drawing.Font("Bauhaus 93", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search.Location = new System.Drawing.Point(578, 83);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(131, 41);
            this.search.TabIndex = 31;
            this.search.Text = "SEARCH";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // DeleteRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SchoolManagementSystem.Properties.Resources.pic;
            this.ClientSize = new System.Drawing.Size(800, 661);
            this.Controls.Add(this.search);
            this.Controls.Add(this.back);
            this.Controls.Add(this.close);
            this.Controls.Add(this.del);
            this.Controls.Add(this.id);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "DeleteRecord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delete";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Button del;
        private System.Windows.Forms.Button search;
    }
}