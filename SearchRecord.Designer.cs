namespace SchoolManagementSystem
{
    partial class SearchRecord
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
            this.back = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.del = new System.Windows.Forms.Button();
            this.cms = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // back
            // 
            this.back.Font = new System.Drawing.Font("Bauhaus 93", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.Location = new System.Drawing.Point(59, 258);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(131, 41);
            this.back.TabIndex = 32;
            this.back.Text = "BACK";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // close
            // 
            this.close.Font = new System.Drawing.Font("Bauhaus 93", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.Location = new System.Drawing.Point(567, 258);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(131, 41);
            this.close.TabIndex = 31;
            this.close.Text = "CLOSE";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.clear_Click);
            // 
            // del
            // 
            this.del.Font = new System.Drawing.Font("Bauhaus 93", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.del.Location = new System.Drawing.Point(313, 258);
            this.del.Name = "del";
            this.del.Size = new System.Drawing.Size(131, 41);
            this.del.TabIndex = 30;
            this.del.Text = "SEARCH";
            this.del.UseVisualStyleBackColor = true;
            this.del.Click += new System.EventHandler(this.del_Click);
            // 
            // cms
            // 
            this.cms.Location = new System.Drawing.Point(313, 120);
            this.cms.Name = "cms";
            this.cms.Size = new System.Drawing.Size(151, 20);
            this.cms.TabIndex = 29;
            this.cms.TextChanged += new System.EventHandler(this.cms_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(181, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 24);
            this.label4.TabIndex = 28;
            this.label4.Text = "CMS";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Forte", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Image = global::SchoolManagementSystem.Properties.Resources.pic;
            this.label3.Location = new System.Drawing.Point(126, 64);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(534, 26);
            this.label3.TabIndex = 27;
            this.label3.Text = "WELCOME TO SCHOOL MANAGEMENT SYSTEM";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(181, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 24);
            this.label2.TabIndex = 26;
            this.label2.Text = "Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(313, 175);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(151, 20);
            this.name.TabIndex = 25;
            this.name.TextChanged += new System.EventHandler(this.name_TextChanged);
            // 
            // SearchRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SchoolManagementSystem.Properties.Resources.pic;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.back);
            this.Controls.Add(this.close);
            this.Controls.Add(this.del);
            this.Controls.Add(this.cms);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SearchRecord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SearchRecord";
            this.Load += new System.EventHandler(this.SearchRecord_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Button del;
        private System.Windows.Forms.TextBox cms;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox name;
    }
}