namespace SchoolManagementSystem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.login = new System.Windows.Forms.Button();
            this.cms = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.close = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Forte", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(192, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(534, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "WELCOME TO SCHOOL MANAGEMENT SYSTEM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bauhaus 93", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(289, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 33);
            this.label2.TabIndex = 1;
            this.label2.Text = "ADMIN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bauhaus 93", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(237, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 33);
            this.label3.TabIndex = 2;
            this.label3.Text = "PASSWORD";
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(553, 242);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(131, 41);
            this.login.TabIndex = 3;
            this.login.Text = "LOGIN";
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // cms
            // 
            this.cms.Location = new System.Drawing.Point(433, 88);
            this.cms.Name = "cms";
            this.cms.Size = new System.Drawing.Size(195, 35);
            this.cms.TabIndex = 4;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(433, 156);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(195, 35);
            this.password.TabIndex = 5;
            // 
            // close
            // 
            this.close.Location = new System.Drawing.Point(295, 242);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(131, 41);
            this.close.TabIndex = 6;
            this.close.Text = "CLOSE";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(295, 364);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(405, 54);
            this.progressBar1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(951, 611);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.close);
            this.Controls.Add(this.password);
            this.Controls.Add(this.cms);
            this.Controls.Add(this.login);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Bauhaus 93", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SchoolManagementSystem";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.TextBox cms;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

