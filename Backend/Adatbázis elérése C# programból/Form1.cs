using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace autodb1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "datasource=localhost;port=3306;username=root;password=;database=autodb;";
            string query = "SELECT * FROM autok";
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            MySqlDataReader reader;
            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        string[] row = { reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3) };
                        richTextBox1.Text += row[0] + " " + row[1] + " " + row[2] + " " + row[3];
                        richTextBox1.Text += "\n";
                    }
                }
                else
                {
                    richTextBox1.Text = "Nincs sor";
                }
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                richTextBox1.Text = "Nagy a baj";
                richTextBox1.Text += ex.ToString();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }


        private void button2_Click(object sender, EventArgs e)
        {
            string connectionString = "datasource=localhost;port=3306;username=root;password=;database=autodb;";
            string query = "INSERT INTO `autok` (`rendszam`, `szin`, `markanev`, `vegsebesseg`) VALUES ('";
            query += textBox1.Text;
            query += "', '";
            query += textBox2.Text;
            query += "', '";
            query += textBox3.Text;
            query += "', '";     
            query += textBox6.Text;
            query += "');";
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            try
            {
                databaseConnection.Open();
                commandDatabase.Prepare();
                commandDatabase.ExecuteNonQuery();
                databaseConnection.Clone();
            }
            catch (Exception ex)
            {
                richTextBox1.Text = "Nagy a baj";
                richTextBox1.Text += ex.ToString();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string connectionString = "datasource=localhost;port=3306;username=root;password=;database=autodb;";
            string query = "SELECT * FROM `autok` WHERE `szin` LIKE @szin";
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);


        }

        private void label5_Click(object sender, EventArgs e)
        {

        }


        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string connectionString = "datasource=localhost;port=3306;username=root;password=;database=autodb;";
            string query = "SELECT * FROM `autok` WHERE `markanev` LIKE @markanev";
            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }
    }
}
