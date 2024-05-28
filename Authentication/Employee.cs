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

namespace Authentication
{
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\Local;Initial Catalog=employeedb;Integrated Security=True");

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Employee_Load(object sender, EventArgs e)
        {
            BindData();
        }

        void BindData()
        {
            SqlCommand cnn = new SqlCommand("Select * from emptab", con);

            SqlDataAdapter da = new SqlDataAdapter(cnn);

            DataTable dt = new DataTable();

            da.Fill(dt);

            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();

            SqlCommand cnn = new SqlCommand("Insert into emptab(id,name,age,email,salary,dob,benefit) values(@id,@name,@age,@email,@salary,@dob,@benefit)", con);

            cnn.Parameters.AddWithValue("@Id", int.Parse(textBox1.Text));
            cnn.Parameters.AddWithValue("@Name", textBox2.Text);
            cnn.Parameters.AddWithValue("@Age", int.Parse(textBox3.Text));
            cnn.Parameters.AddWithValue("Email", textBox4.Text);
            cnn.Parameters.AddWithValue("@Salary", int.Parse(textBox5.Text));
            cnn.Parameters.AddWithValue("@Dob", DateTime.Parse(textBox6.Text)); // Assuming textBox4 contains the date in a valid format
            cnn.Parameters.AddWithValue("@Benefit", textBox7.Text);

            cnn.ExecuteNonQuery();

            con.Close();

            BindData();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text =  "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\Local;Initial Catalog=employeedb;Integrated Security=True");
            con.Open();

            SqlCommand cnn = new SqlCommand("Delete emptab where id=@id",con);

            cnn.Parameters.AddWithValue("@Id", int.Parse(textBox1.Text));
            
            cnn.ExecuteNonQuery();

            con.Close();

            MessageBox.Show("Data Deleted");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main main =  new Main();
            main.Show();

        }
    }
}