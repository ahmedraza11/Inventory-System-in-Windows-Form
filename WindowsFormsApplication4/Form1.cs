using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=LAB9-10\SQLSERVER2012ENT;Initial Catalog=Inventery;Integrated Security=True");
        SqlCommand cmd;

        private void display()
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAB9-10\SQLSERVER2012ENT;Initial Catalog=Inventery;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from data", con);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            ad.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
        private void clear()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'inventeryDataSet2.data' table. You can move, or remove it, as needed.
            this.dataTableAdapter.Fill(this.inventeryDataSet2.data);
            Timer timer1 = new Timer();
            timer1.Tick += new EventHandler(Times);
            timer1.Interval = 1000; // in miliseconds
            timer1.Start();

        }
        private void Times(object sender, EventArgs e)
        {
          

            label7.Text = DateTime.Now.Hour.ToString() + " : " + DateTime.Now.Minute.ToString() + " : " + DateTime.Now.Second.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label8.Text = "Add Product";

            try
            {
                con.Open();
                cmd = new SqlCommand("insert into data values ("+textBox1.Text+",'"+textBox2.Text+"',"+textBox3.Text+","+textBox4.Text+",'"+textBox5.Text+"')", con);
                cmd.ExecuteNonQuery();
                display();
                clear();
                label9.Text = "Data inserted Successfully";
                con.Close();
            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                cmd = new SqlCommand("select * from data where name LIKE '" + textBox6.Text + "%'", con);
                cmd.ExecuteNonQuery();
                SqlDataAdapter ad = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                ad.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();

            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label8.Text = "Update Product";

            try
            {
                con.Open();
                cmd = new SqlCommand("update data set id =" + textBox1.Text + ",name = '" + textBox2.Text + "',quantity= " + textBox3.Text + ",price =" + textBox4.Text + ",decript= '" + textBox5.Text + "' where id =  " + textBox1.Text, con);
                cmd.ExecuteNonQuery();
                display();
                label9.Text = "Data updated Successfully";
                con.Close();

            }
            catch (Exception ea)
            {
                MessageBox.Show(ea.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = (dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            textBox2.Text = (dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());
            textBox3.Text = (dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
            textBox4.Text = (dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());
            textBox5.Text = (dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label8.Text = "Delete Product";
            try
            {
                con.Open();
                cmd = new SqlCommand("delete data where id= " + textBox1.Text + "", con);
                cmd.ExecuteNonQuery();
                display();
                clear();
                label9.Text = "Data Deleted Successfully";
                con.Close();
            }
            catch (Exception ea)
            {
                MessageBox.Show(ea.Message);
            }
        }
    }
}
