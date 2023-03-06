namespace Student_Information_System
{
    partial class mainForm
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
            this.StudentSignup = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StudentSignup
            // 
<<<<<<< HEAD
            this.StudentSignup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(0)))), ((int)(((byte)(130)))));
            this.StudentSignup.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.StudentSignup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(0)))), ((int)(((byte)(51)))));
            this.StudentSignup.Location = new System.Drawing.Point(556, 321);
            this.StudentSignup.Name = "StudentSignup";
            this.StudentSignup.Size = new System.Drawing.Size(107, 50);
=======
            this.StudentSignup.Location = new System.Drawing.Point(330, 245);
            this.StudentSignup.Name = "StudentSignup";
            this.StudentSignup.Size = new System.Drawing.Size(99, 23);
>>>>>>> edcc4c2efc04978da103c81fb43886262bb6e454
            this.StudentSignup.TabIndex = 1;
            this.StudentSignup.Text = "Student Signup";
            this.StudentSignup.UseVisualStyleBackColor = false;
            this.StudentSignup.Click += new System.EventHandler(this.StudentSignup_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(0)))), ((int)(((byte)(130)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(0)))), ((int)(((byte)(51)))));
            this.button1.Location = new System.Drawing.Point(138, 321);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 50);
            this.button1.TabIndex = 2;
            this.button1.Text = "Attendance";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Student_Information_System.Properties.Resources.LogIn;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(755, 435);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.StudentSignup);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CSDC 24 ";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button StudentSignup;
        private System.Windows.Forms.Button button1;
    }
}

