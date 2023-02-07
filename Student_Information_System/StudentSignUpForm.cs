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
            string txtQuery = "insert into StudentSignUp (StudentName, StudentID,Course,PhoneNumber,Email) values ('"+txtStudentName.Text+"', '"+txtStudentID.Text+"', '"+txtCourse.Text+"', '"+txtPhone.Text+"', '"+txtEmail.Text+"')";
            ExecuteQuery(txtQuery);
            LoadData();
            MessageBox.Show("Value Added");
        }
    }
}
