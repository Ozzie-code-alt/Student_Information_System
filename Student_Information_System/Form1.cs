﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Information_System
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void StudentSignup_Click(object sender, EventArgs e)
        {
          mainForm MainForms = new mainForm();
          MainForms.Close();

          StudentSignUpForm studentSignUp = new StudentSignUpForm();
          studentSignUp.Show();
            
        }
    }
}
