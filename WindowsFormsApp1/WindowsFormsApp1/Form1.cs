using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=(localdb)\\ProjectModels;Initial Catalog=StudentDatabase;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        public int StudentID;
        private void Form1_Load(object sender, EventArgs e)
        {
            getstudentrecord();
        }
        public void getstudentrecord()
        {
            SqlCommand cmd = new SqlCommand("select * from student",con);
            DataTable d = new DataTable();
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            d.Load(reader);
            con.Close();
            studentgrid.DataSource = d;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(Valid())
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO student VALUES (@FirstName,@LastName,@FatherName,@StudentAddress,@StudentReg) ",con);
                cmd.CommandType = CommandType.Text;
              
                cmd.Parameters.AddWithValue("@FirstName", txtstudentname.Text);
                cmd.Parameters.AddWithValue("@LastName", txtstudentlastname.Text);
                cmd.Parameters.AddWithValue("@FatherName", txtfathername.Text);
                cmd.Parameters.AddWithValue("@StudentAddress", txtstudentaddress.Text);
                cmd.Parameters.AddWithValue("@StudentReg", txtstudenid.Text);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("New Students Are Saved in db");
                getstudentrecord();



                Clear();




            }
        }
        private bool Valid()
        {
            if(txtstudentname.Text==string.Empty)
            {
                MessageBox.Show("Student FirstName is required");
                return false;
            }
            if(txtstudentlastname.Text==string.Empty)
            {
                MessageBox.Show("Student LasttName is required");
                return false;
            }
            if(txtstudentlastname.Text==string.Empty)
            {
                MessageBox.Show("FatherName is required");
                return false;
            }
            if(txtstudenid.Text==String.Empty)
            {
                MessageBox.Show("StudentId is requried");
                return false;
            }
            return true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Clear();   
        }
        public void Clear()
        {
            StudentID = 0;
            txtstudentname.Clear();
            txtstudentlastname.Clear();
            txtfathername.Clear();
            txtstudentaddress.Clear();
            txtstudenid.Clear();   
             txtstudentname.Focus();

        }

        private void studentgrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            StudentID = Convert.ToInt32(studentgrid.SelectedRows[0].Cells[0].Value);    
            txtstudentname.Text = studentgrid.SelectedRows[0].Cells[1].Value.ToString();
            txtstudentlastname.Text = studentgrid.SelectedRows[0].Cells[2].Value.ToString();
            txtfathername.Text = studentgrid.SelectedRows[0].Cells[3].Value.ToString();
            txtstudentaddress.Text = studentgrid.SelectedRows[0].Cells[4].Value.ToString(); 
            txtstudenid.Text= studentgrid.SelectedRows[0].Cells[5].Value.ToString();       

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(StudentID > 0)
            {
                SqlCommand cmd = new SqlCommand("UPDATE student SET FirstName=@FirstName,LastName=@LastName,FatherName=@FatherName,StudentAddress=@StudentAddress,StudentReg=@StudentReg WHERE StudentID = @ID ", con);
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@FirstName", txtstudentname.Text);
                cmd.Parameters.AddWithValue("@LastName", txtstudentlastname.Text);
                cmd.Parameters.AddWithValue("@FatherName", txtfathername.Text);
                cmd.Parameters.AddWithValue("@StudentAddress", txtstudentaddress.Text);
                cmd.Parameters.AddWithValue("@StudentReg", txtstudenid.Text);
                cmd.Parameters.AddWithValue("@ID", this.StudentID);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Student Information Is Updated");
                getstudentrecord();
                Clear();
                



                
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(StudentID>0)
            {
                SqlCommand cmd = new SqlCommand("DELETE student WHERE StudentID = @ID ", con);
                cmd.CommandType = CommandType.Text;

    
                cmd.Parameters.AddWithValue("@ID", this.StudentID);

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Student Is Deleted");
                getstudentrecord();
                Clear();
            }
            else
            {
                MessageBox.Show("Error");
            }
        }
    }
}
