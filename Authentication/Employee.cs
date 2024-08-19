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
            button5.Visible=false;
            button3.Visible=false;
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
            cnn.Parameters.AddWithValue("@Dob", DateTime.Parse(dateTimePicker1.Text));
            cnn.Parameters.AddWithValue("@Benefit", textBox7.Text);

            cnn.ExecuteNonQuery();

            con.Close();

            BindData();
            MessageBox.Show("Employee added successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);


            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            dateTimePicker1.Text = "";
            textBox7.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text =  "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            dateTimePicker1.Text = "";
            textBox7.Text = "";



            button5.Visible = true;
            
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\Local;Initial Catalog=employeedb;Integrated Security=True");
            con.Open();

            SqlCommand cnn = new SqlCommand("Delete emptab where id=@id",con);

            cnn.Parameters.AddWithValue("@Id", int.Parse(textBox1.Text));
            

            cnn.ExecuteNonQuery();

            con.Close();

            DialogResult res;
            res = MessageBox.Show("Are you sure you want to delete data?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                MessageBox.Show("Data Deleted");
            }
            else
            {

                this.Show();
            }
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

        private void button5_Click(object sender, EventArgs e)
        {
            con.Open();

            SqlCommand cnn = new SqlCommand("UPDATE emptab SET name = @name, age = @age, email = @email, salary = @salary, dob = @dob, benefit = @benefit WHERE Id = @Id", con);

            cnn.Parameters.AddWithValue("@Id", int.Parse(textBox1.Text));
            cnn.Parameters.AddWithValue("@name", textBox2.Text);
            cnn.Parameters.AddWithValue("@age", int.Parse(textBox3.Text));
            cnn.Parameters.AddWithValue("@email", textBox4.Text);
            cnn.Parameters.AddWithValue("@salary", int.Parse(textBox5.Text));
            cnn.Parameters.AddWithValue("@dob", DateTime.Parse(dateTimePicker1.Text));
            cnn.Parameters.AddWithValue("@benefit", textBox7.Text);

            cnn.ExecuteNonQuery();

            con.Close();

            BindData();
            MessageBox.Show("Information updated successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            dateTimePicker1.Text = "";
            textBox7.Text = "";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int id))
            {
                SqlConnection con = new SqlConnection("Data Source=(localdb)\\Local;Initial Catalog=employeedb;Integrated Security=True");
                con.Open();

                SqlCommand cmd = new SqlCommand("Select name, age, email, salary, dob, benefit from emptab where Id = @id", con);
                cmd.Parameters.AddWithValue("@Id", id);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        textBox2.Text = reader.GetValue(0).ToString();
                        textBox3.Text = reader.GetValue(1).ToString();
                        textBox4.Text = reader.GetValue(2).ToString();
                        textBox5.Text = reader.GetValue(3).ToString();
                        dateTimePicker1.Text = reader.GetValue(4).ToString();
                        textBox7.Text = reader.GetValue(5).ToString();

                        button5.Visible = true;
                        button3.Visible = true;
                    }
                }
                else
                {
                    // Clear the other text boxes if the ID doesn't exist
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    textBox5.Text = "";
                    dateTimePicker1.Text = "";
                    textBox7.Text = "";

                    button5.Visible = false; 
                    button1.Visible = true;
                    button3.Visible = true;

                }
                con.Close();
            }
            else
            {
                // Clear the other text boxes if the input in textBox1 is not a valid integer
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                dateTimePicker1.Text = "";
                textBox7.Text = "";

                button5.Visible = false;
                button1.Visible = true;
                button3.Visible= false;
            }
        }
    }
}