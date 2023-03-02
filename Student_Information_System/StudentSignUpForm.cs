using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Student_Information_System
{
    public partial class StudentSignUpForm : Form
    {
        public StudentSignUpForm()
        {
            InitializeComponent();
        }

        //instantiate connection Strings 
        SQLiteConnection sqlcon;
        SQLiteCommand sql_cmd;

        //Connecting Student Db and Tables 
        SQLiteDataAdapter DB1;
        DataSet DS1= new DataSet();
        DataTable DT1 = new DataTable();


        private void MainPanel_Paint(object sender, PaintEventArgs e)
        {
            this.MainPanel.SendToBack();
        }

        private void StudentSignUpForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void setConnection()
        {
            this.sqlcon = new SQLiteConnection("Data Source = Project.db");
        }

        private void LoadData()
        {
            setConnection();
            sqlcon.Open();
            sql_cmd = sqlcon.CreateCommand();

            //Student Sign DGV

            string Commandtext1 = "select * from StudentSignUp";
            DB1 = new SQLiteDataAdapter(Commandtext1, sqlcon);
            DS1.Reset();
            DB1.Fill(DS1);
            DT1 = DS1.Tables[0];
            StudentSignDGV.DataSource = DT1;

            sqlcon.Close();

        }

        private void ExecuteQuery(string txtQuery)
        {
            setConnection();
            sqlcon.Open();
            sql_cmd = sqlcon.CreateCommand();
            sql_cmd.CommandText = txtQuery;
            sql_cmd.ExecuteNonQuery();
            sqlcon.Close();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string txtQuery = "insert into StudentSignUp (StudentName, StudentID, Course, PhoneNumber, Email) values ('"+txtStudentName.Text+"', '"+txtStudentID.Text+"', '"+txtCourse.Text+"', '"+txtPhone.Text+"', '"+txtEmail.Text+"')";
            ExecuteQuery(txtQuery);
            LoadData();
            MessageBox.Show("Value Added.");

            txtStudentName.Clear();
            txtStudentID.Clear();
            txtCourse.Clear();
            txtPhone.Clear();
            txtEmail.Clear();
        }

        private void StudentSignDGV_SelectionChanged(object sender, EventArgs e)
        {
            if(StudentSignDGV.SelectedRows.Count > 0)
            {
                txtStudentName.Text = StudentSignDGV.SelectedRows[0].Cells[0].Value.ToString();
                txtStudentID.Text = StudentSignDGV.SelectedRows[0].Cells[1].Value.ToString();
                txtCourse.Text = StudentSignDGV.SelectedRows[0].Cells[2].Value.ToString();
                txtPhone.Text = StudentSignDGV.SelectedRows[0].Cells[3].Value.ToString();
                txtEmail.Text = StudentSignDGV.SelectedRows[0].Cells[4].Value.ToString();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string txtQuery = "update StudentSignUp set StudentName = '" + txtStudentName.Text + "', StudentID = '" + txtStudentID.Text + "', Course = '" + txtCourse.Text +
                "', PhoneNumber = '" + txtPhone.Text + "', Email = '" + txtEmail.Text + "'";

            ExecuteQuery(txtQuery);
            LoadData();

            MessageBox.Show("Value Edited.");

            txtStudentName.Clear();
            txtStudentID.Clear();
            txtCourse.Clear();
            txtPhone.Clear();
            txtEmail.Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string txtQuery = "delete from StudentSignUp where StudentName = '" + txtStudentName.Text + "'";

            ExecuteQuery(txtQuery);
            LoadData();

            MessageBox.Show("Value Deleted.");

            txtStudentName.Clear();
            txtStudentID.Clear();
            txtCourse.Clear();
            txtPhone.Clear();
            txtEmail.Clear();
        }
    }
}
