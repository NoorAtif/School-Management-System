using CRUD_Opeartions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class Form1 : Form
    {
        int PanelWidth;
        bool isCollapsed;
        public Form1()
        {
            InitializeComponent();
            timer2.Start();
            PanelWidth = panel1.Width;
            isCollapsed = false;


            //Getting Student Status From Lookup Id
            var con = Configuration.getInstance().getConnection();
            SqlCommand sc = new SqlCommand("SELECT CONCAT([LookupId], ', ', [Value]) FROM LookUp Where Category = 'Status'", con);
            List<String> data = new List<string>();
            data.Clear();
            SqlDataReader reader = sc.ExecuteReader();
            while (reader.Read())
            {
                data.Add(reader.GetValue(0).ToString());

            }
            reader.Close();
            comboBox1.DataSource = data;

            // Getting Student Gender From Lookup Id
            SqlCommand sc1 = new SqlCommand("SELECT CONCAT([LookupId], ', ', [Value]) FROM LookUp Where Category = 'Gender'", con);
            List<String> data1 = new List<string>();
            data1.Clear();
            SqlDataReader reader1 = sc1.ExecuteReader();
            while (reader1.Read())
            {
                data1.Add(reader1.GetValue(0).ToString());

            }
            reader1.Close();
            comboBox2.DataSource = data1;


            // Getting Student RegNo From Student For Fee
            SqlCommand sc2 = new SqlCommand("SELECT DISTINCT RegNo FROM Student ", con);
            List<String> data2 = new List<string>();
            data2.Clear();
            SqlDataReader reader2 = sc2.ExecuteReader();
            while (reader2.Read())
            {
                data2.Add(reader2.GetValue(0).ToString());

            }
            reader2.Close();
            comboBox3.DataSource = data2;

            // Getting Student Fee Status From Lookup
            SqlCommand sc3 = new SqlCommand("SELECT CONCAT([LookupId], ', ', [Value]) FROM LookUp Where Category = 'FeeStatus'", con);
            List<String> data3 = new List<string>();
            data3.Clear();
            SqlDataReader reader3 = sc3.ExecuteReader();
            while (reader3.Read())
            {
                data3.Add(reader3.GetValue(0).ToString());

            }
            reader3.Close();
            comboBox4.DataSource = data3;

            //Getting AttendanceStatus From Lookup
            SqlCommand sc4 = new SqlCommand("SELECT CONCAT([LookupId], ', ', [Value]) FROM LookUp Where Category = 'AttendanceStatus'", con);
            List<String> data4 = new List<string>();
            data4.Clear();
            SqlDataReader reader4 = sc4.ExecuteReader();
            while (reader4.Read())
            {
                data4.Add(reader4.GetValue(0).ToString());

            }
            reader4.Close();
            comboBox6.DataSource = data4;

            //Getting Reg No From Student For Student Attendance
            //SqlCommand sc5 = new SqlCommand("SELECT DISTINCT RegNo FROM Student ", con);
            //List<String> data5 = new List<string>();
            //data5.Clear();
            //SqlDataReader reader5 = sc5.ExecuteReader();
            //while (reader5.Read())
            //{
            //    data5.Add(reader5.GetValue(0).ToString());

            //}
            //reader5.Close();
            //comboBox5.DataSource = data5;

            //Getting Teacher Status From Lookup Id
            SqlCommand sc6 = new SqlCommand("SELECT CONCAT([LookupId], ', ', [Value]) FROM LookUp Where Category = 'Status'", con);
            List<String> data6 = new List<string>();
            data6.Clear();
            SqlDataReader reader6 = sc6.ExecuteReader();
            while (reader6.Read())
            {
                data6.Add(reader6.GetValue(0).ToString());

            }
            reader6.Close();
            comboBox8.DataSource = data6;

            // Getting Teacher Gender From Lookup Id
            SqlCommand sc7 = new SqlCommand("SELECT CONCAT([LookupId], ', ', [Value]) FROM LookUp Where Category = 'Gender'", con);
            List<String> data7 = new List<string>();
            data7.Clear();
            SqlDataReader reader7 = sc7.ExecuteReader();
            while (reader7.Read())
            {
                data7.Add(reader7.GetValue(0).ToString());

            }
            reader7.Close();
            comboBox7.DataSource = data7;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBFinalProjectDataSet9.Teacher' table. You can move, or remove it, as needed.
            this.teacherTableAdapter.Fill(this.dBFinalProjectDataSet9.Teacher);
            // TODO: This line of code loads data into the 'dBFinalProjectDataSet8.Student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.dBFinalProjectDataSet8.Student);


        }

        private void button6_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = Homepage;
        }

     

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = StudentPortal;
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select * from Student", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = StudentFee;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = TeacherPortal;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = CoursePortal;
        }

        private void button30_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = ExamPortal;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = TeacherSalary;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = TeacherAttendance;
        }

        private void label54_Click(object sender, EventArgs e)
        {

        }

        private void button44_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = TeacherPortal;
        }

        private void button45_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = TeacherPortal;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = StudentResult;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = StudentAttendance;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = StudentClass;
        }

        private void label57_Click(object sender, EventArgs e)
        {

        }

        private void button46_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = StudentPortal;
        }

        private void button62_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = StudentPortal;
        }

        private void button63_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = StudentPortal;
        }

        private void button64_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = StudentPortal;
        }

        private void button72_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = StudentClass;
        }

        private void button70_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = Section;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void TeacherAttendance_Click(object sender, EventArgs e)
        {

        }




        private void button71_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                panel1.Width = panel1.Width + 15;
                if (panel1.Width >= PanelWidth)
                {
                    timer1.Stop();
                    isCollapsed = false;
                    this.Refresh();
                }
            }
            else
            {
                panel1.Width = panel1.Width - 15;
                if (panel1.Width <= 59)
                {
                    timer1.Stop();
                    isCollapsed = true;
                    this.Refresh();
                }
            }
        }

        private void labelTime_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            labelTime.Text = dt.ToString("HH:MM:ss");
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Insert into Student values (@RegNo, @FirstName, @LastName, @Email,@Contact, @DOB, @Status, @Gender)", con);
            cmd.Parameters.AddWithValue("@RegNo", textBox11.Text);
            cmd.Parameters.AddWithValue("@FirstName", textBox6.Text);
            cmd.Parameters.AddWithValue("@LastName", textBox5.Text);
            cmd.Parameters.AddWithValue("@Email", textBox7.Text);
            cmd.Parameters.AddWithValue("@Contact", textBox8.Text);
            cmd.Parameters.AddWithValue("@DOB", dateTimePicker1.Value);
            //Console.WriteLine(comboBox1.Text);
            string resultString = Regex.Match(comboBox1.Text, @"\d+").Value;
            string resultString1 = Regex.Match(comboBox2.Text, @"\d+").Value;
            //MessageBox.Show(resultString);
            //MessageBox.Show(resultString1);
            cmd.Parameters.AddWithValue("@Status", resultString);
            cmd.Parameters.AddWithValue("@Gender", resultString1);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Successfully Inserted");
            textBox11.Clear();
            textBox6.Clear();
            textBox5.Clear();
            textBox7.Clear();
            textBox8.Clear();
            comboBox1.ResetText();
            comboBox2.ResetText();

        }

        private void button12_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Update Student set FirstName=@FirstName, LastName=@LastName, Email=@Email,Contact=@Contact, DOB=@DOB, Status=@Status, Gender=@Gender where RegNo= @RegNo", con);
            cmd.Parameters.AddWithValue("@RegNo", textBox11.Text);
            cmd.Parameters.AddWithValue("@FirstName", textBox6.Text);
            cmd.Parameters.AddWithValue("@LastName", textBox5.Text);
            cmd.Parameters.AddWithValue("@Email", textBox7.Text);
            cmd.Parameters.AddWithValue("@Contact", textBox8.Text);
            cmd.Parameters.AddWithValue("@DOB", dateTimePicker1.Value);
            //cmd.Parameters.AddWithValue("@Status", comboBox1.Text);
            string resultString = Regex.Match(comboBox1.Text, @"\d+").Value;
            string resultString1 = Regex.Match(comboBox2.Text, @"\d+").Value;
            cmd.Parameters.AddWithValue("@Status", resultString);
            cmd.Parameters.AddWithValue("@Gender", resultString1);

            //cmd.Parameters.AddWithValue("@Gender", comboBox2.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Successfully Updated");
            textBox11.Clear();
            textBox6.Clear();
            textBox5.Clear();
            textBox7.Clear();
            textBox8.Clear();
            comboBox1.ResetText();
            comboBox2.ResetText();
        }

        private void button11_Click(object sender, EventArgs e)
        {

            var con = Configuration.getInstance().getConnection();
            string reg = textBox11.Text;
            SqlCommand cmd = new SqlCommand("Delete FROM Student WHERE RegNo= '" + reg + "' ", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Successfully Deleted");
            textBox11.Clear();
            textBox6.Clear();
            textBox5.Clear();
            textBox7.Clear();
            textBox8.Clear();
            comboBox1.ResetText();
            comboBox2.ResetText();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select *from Student where RegNo=@RegNo", con);
            cmd.Parameters.AddWithValue("@RegNo", textBox11.Text);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            MessageBox.Show("The Searched Data Is Displayed");
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int indexRow = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[indexRow];
            textBox11.Text = row.Cells[0].Value.ToString();
            textBox6.Text = row.Cells[1].Value.ToString();
            textBox5.Text = row.Cells[2].Value.ToString();
            textBox7.Text = row.Cells[3].Value.ToString();
            textBox8.Text = row.Cells[4].Value.ToString();
            comboBox1.Text = row.Cells[6].Value.ToString();
            comboBox2.Text = row.Cells[7].Value.ToString();

        }

        private void button54_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Insert into StudentFee values (@RegNo, @AdminId,@PayedDate,@Deadline,@FeeStatus)", con);
            cmd.Parameters.AddWithValue("@AdminId", textBox40.Text);
            cmd.Parameters.AddWithValue("@PayedDate", dateTimePicker6.Value);
            cmd.Parameters.AddWithValue("@Deadline", dateTimePicker5.Value);

            string resultString3 = Regex.Match(comboBox3.Text, @"\d+").Value;
            string resultString4 = Regex.Match(comboBox4.Text, @"\d+").Value;
            cmd.Parameters.AddWithValue("@RegNo", resultString3);
            cmd.Parameters.AddWithValue("@FeeStatus", resultString4);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Successfully Inserted");
            textBox40.Clear();
            comboBox3.ResetText();
            comboBox4.ResetText();

        }

        private void label58_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button61_Click(object sender, EventArgs e)
        {
            //var con = Configuration.getInstance().getConnection();
            //SqlCommand cmd = new SqlCommand("Insert into StudentAttendance values (@Regno,@AttendanceStatus,@AttendanceDate)", con);
            //cmd.Parameters.AddWithValue("@Regno", comboBox5.Text);
            //cmd.Parameters.AddWithValue("@AttendanceDate", dateTimePicker7.Value);
            //string resultString5 = Regex.Match(comboBox6.Text, @"\d+").Value;
            //cmd.Parameters.AddWithValue("@AttendanceStatus", resultString5);
            //cmd.ExecuteNonQuery();
            //MessageBox.Show("Successfully Inserted");
            //comboBox5.ResetText();
            //comboBox6.ResetText();
        }

        private void button60_Click(object sender, EventArgs e)
        {
            //var con = Configuration.getInstance().getConnection();
            //SqlCommand cmd = new SqlCommand("Select * from StudentAttendance", con);
            //SqlDataAdapter da = new SqlDataAdapter(cmd);
            //DataTable dt = new DataTable();
            //da.Fill(dt);
            //dataGridView9.DataSource = dt;
        }

        private void button47_Click(object sender, EventArgs e)
        {
            //var con = Configuration.getInstance().getConnection();
            //SqlCommand cmd = new SqlCommand("Update StudentAttendance set AttendanceStatus=@AttendanceStatus,AttendanceDate=@AttendanceDate where Regno=@Regno", con);
            //cmd.Parameters.AddWithValue("@Regno", comboBox5.Text);
            //cmd.Parameters.AddWithValue("@AttendanceDate", dateTimePicker7.Value);
            //string resultString6 = Regex.Match(comboBox6.Text, @"\d+").Value;
            //cmd.Parameters.AddWithValue("@AttendanceStatus", resultString6);
            //cmd.ExecuteNonQuery();
            //MessageBox.Show("Successfully Updated");
            //comboBox5.ResetText();
            //comboBox6.ResetText();
        }

        private void button48_Click(object sender, EventArgs e)
        {
            //var con = Configuration.getInstance().getConnection();
            //string reg1 = comboBox5.Text;
            //SqlCommand cmd = new SqlCommand("Delete FROM StudentAttendance WHERE Regno= '" + reg1 + "' ", con);
            //cmd.ExecuteNonQuery();
            //MessageBox.Show("Successfully Deleted");
            //comboBox5.ResetText();
            //comboBox6.ResetText();
        }

        private void button49_Click(object sender, EventArgs e)
        {
            //var con = Configuration.getInstance().getConnection();
            //SqlCommand cmd = new SqlCommand("Select *from StudentAttendance where Regno=@Regno", con);
            //cmd.Parameters.AddWithValue("@Regno", comboBox5.Text);
            //SqlDataAdapter da = new SqlDataAdapter(cmd);
            //DataTable dt = new DataTable();
            //da.Fill(dt);
            //dataGridView9.DataSource = dt;
            //MessageBox.Show("The Searched Data Is Displayed");
        }

        private void dataGridView9_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //int indexRow = e.RowIndex;
            //DataGridViewRow row = dataGridView9.Rows[indexRow];
            //comboBox5.Text = row.Cells[0].Value.ToString();
            //comboBox6.Text = row.Cells[1].Value.ToString();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Insert into Teacher values (@TID, @FirstName, @LastName,@Contact, @Email,@Gender, @DOB, @Status)", con);
            cmd.Parameters.AddWithValue("@TID", textBox12.Text);
            cmd.Parameters.AddWithValue("@FirstName", textBox17.Text);
            cmd.Parameters.AddWithValue("@LastName", textBox16.Text);
            cmd.Parameters.AddWithValue("@Contact", textBox15.Text);
            cmd.Parameters.AddWithValue("@Email", textBox14.Text);
            cmd.Parameters.AddWithValue("@DOB", dateTimePicker2.Value);
            string resultString6 = Regex.Match(comboBox8.Text, @"\d+").Value;
            string resultString7 = Regex.Match(comboBox7.Text, @"\d+").Value;
            cmd.Parameters.AddWithValue("@Status", resultString6);
            cmd.Parameters.AddWithValue("@Gender", resultString7);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Successfully Inserted");
            textBox12.Clear();
            textBox17.Clear();
            textBox16.Clear();
            textBox15.Clear();
            textBox14.Clear();
            comboBox8.ResetText();
            comboBox7.ResetText();
        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button23_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select * from Teacher", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Update  Teacher set  FirstName=@FirstName, LastName=@LastName,Contact=@Contact, Email=@Email,Gender=@Gender, DOB=@DOB, Status=@Status where TID=@TID", con);
            cmd.Parameters.AddWithValue("@TID", textBox12.Text);
            cmd.Parameters.AddWithValue("@FirstName", textBox17.Text);
            cmd.Parameters.AddWithValue("@LastName", textBox16.Text);
            cmd.Parameters.AddWithValue("@Contact", textBox15.Text);
            cmd.Parameters.AddWithValue("@Email", textBox14.Text);
            cmd.Parameters.AddWithValue("@DOB", dateTimePicker2.Value);
            string resultString6 = Regex.Match(comboBox8.Text, @"\d+").Value;
            string resultString7 = Regex.Match(comboBox7.Text, @"\d+").Value;
            cmd.Parameters.AddWithValue("@Status", resultString6);
            cmd.Parameters.AddWithValue("@Gender", resultString7);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Successfully Updated");
            textBox12.Clear();
            textBox17.Clear();
            textBox16.Clear();
            textBox15.Clear();
            textBox14.Clear();
            comboBox8.ResetText();
            comboBox7.ResetText();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            int indexRow = e.RowIndex;
            DataGridViewRow row = dataGridView2.Rows[indexRow];
            textBox12.Text = row.Cells[0].Value.ToString();
            textBox17.Text = row.Cells[1].Value.ToString();
            textBox16.Text = row.Cells[2].Value.ToString();
            textBox15.Text = row.Cells[3].Value.ToString();
            textBox14.Text = row.Cells[4].Value.ToString();
            comboBox7.Text = row.Cells[5].Value.ToString();
            comboBox8.Text = row.Cells[7].Value.ToString();

        }

        private void button21_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            string tid = textBox12.Text;
            SqlCommand cmd = new SqlCommand("Delete FROM Teacher WHERE TID= '" + tid + "' ", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Successfully Deleted");
            textBox12.Clear();
            textBox17.Clear();
            textBox16.Clear();
            textBox15.Clear();
            textBox14.Clear();
            comboBox8.ResetText();
            comboBox7.ResetText();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select *from Teacher where TID=@TID", con);
            cmd.Parameters.AddWithValue("@TID", textBox12.Text);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView2.DataSource = dt;
            MessageBox.Show("The Searched Data Is Displayed");

        }

        private void Homepage_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void textBox21_TextChanged(object sender, EventArgs e)
        {
                    }

        private void label67_Click(object sender, EventArgs e)
        {

        }

        private void label63_Click(object sender, EventArgs e)
        {

        }

        private void label65_Click(object sender, EventArgs e)
        {

        }

        private void panel12_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
