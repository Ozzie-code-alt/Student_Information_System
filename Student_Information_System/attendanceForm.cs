using System;
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
    public partial class attendanceForm : Form
    {
        public attendanceForm()
        {
            InitializeComponent();
        }

        private void attendanceForm_Load(object sender, EventArgs e)
        {
            cmbShortDROP.Items.Add("P - Present");
            cmbShortDROP.Items.Add("0 - Absent");
            cmbShortDROP.Items.Add("S - Sick");
            cmbShortDROP.Items.Add("E - Excused");





        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cmbShortDROP.Text == "P - Present")
            {
                comboBox1.Text = "Present";
                comboBox2.Text = "Present";
                comboBox3.Text = "Present";
                comboBox4.Text = "Present";
                comboBox5.Text = "Present";
                comboBox6.Text = "Present";
                comboBox7.Text = "Present";
                comboBox8.Text = "Present";
                comboBox9.Text = "Present";
                comboBox10.Text = "Present";
                comboBox11.Text = "Present";
                comboBox12.Text = "Present";
                comboBox13.Text = "Present";
                comboBox14.Text = "Present";
                comboBox15.Text = "Present";
                comboBox16.Text = "Present";
                comboBox17.Text = "Present";
                comboBox18.Text = "Present";
                comboBox19.Text = "Present";
                comboBox20.Text = "Present";

            }
            else if(cmbShortDROP.Text == "0 - Absent")
            {
                comboBox1.Text = "Absent";
                comboBox2.Text = "Absent";
                comboBox3.Text = "Absent";
                comboBox4.Text = "Absent";
                comboBox5.Text = "Absent";
                comboBox6.Text = "Absent";
                comboBox7.Text = "Absent";
                comboBox8.Text = "Absent";
                comboBox9.Text = "Absent";
                comboBox10.Text = "Absent";
                comboBox11.Text = "Absent";
                comboBox12.Text = "Absent";
                comboBox13.Text = "Absent";
                comboBox14.Text = "Absent";
                comboBox15.Text = "Absent";
                comboBox16.Text = "Absent";
                comboBox17.Text = "Absent";
                comboBox18.Text = "Absent";
                comboBox19.Text = "Absent";
                comboBox20.Text = "Absent";
            }






        }
    }
}
