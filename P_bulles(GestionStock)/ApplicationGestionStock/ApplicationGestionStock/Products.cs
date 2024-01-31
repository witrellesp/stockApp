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

namespace ApplicationGestionStock
{
    public partial class Products : Form
    {
        public Products()
        {
            InitializeComponent();
        }

        private void tittle3(object sender, EventArgs e)
        {

        }

        private void backButton(object sender, EventArgs e)
        {
            this.Hide();

            ApStock pagePrincipal = new ApStock();

            pagePrincipal.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        string connectionString = "Server=localhost;Port=6033;Database=db_stock;User Id=root;Password=root;";

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT name,price, stock FROM t_product"; 
                MySqlCommand cmd = new MySqlCommand(query, connection);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        // Aquí procesas cada fila
                        ListViewItem item = new ListViewItem(reader["name"].ToString());
                        item.SubItems.Add(reader["price"].ToString());
                        listView1.Items.Add(item);
                    }
                }
            }










        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                listView1.Items.Clear();
                connection.Open();
                string query = "SELECT name,price, stock FROM t_product";
                MySqlCommand cmd = new MySqlCommand(query, connection);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {

                        // Aquí procesas cada fila
                        ListViewItem item = new ListViewItem(reader["name"].ToString());
                        ListViewItem item2 = new ListViewItem(reader["price"].ToString());
                        item.SubItems.Add(reader["price"].ToString());
                        listView1.Items.Add(item);
                        listView1.Items.Add(item2);
                        
                    }
                }
            }
        }

        public void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Products_Load(object sender, EventArgs e)
        {

        }
    }
}
