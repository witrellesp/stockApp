using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

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
                
                connection.Open();
                string query = "SELECT name,price, stock FROM t_product";
                MySqlCommand cmd = new MySqlCommand(query, connection);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    listView1.Items.Clear();
                    listView2.Items.Clear();
                    listView3.Items.Clear();
                    while (reader.Read())
                    {
                        ListViewItem item = new ListViewItem(reader["name"].ToString());
                        
                        ListViewItem item2 = new ListViewItem(reader["price"].ToString());
                        ListViewItem item3 = new ListViewItem(reader["stock"].ToString());
                        listView1.Columns.Add("Columna 1", -2, HorizontalAlignment.Left);
                        listView1.Columns.Add("Columna 2", -2, HorizontalAlignment.Left);
                        
                        listView1.Items.Add(item);
                        
                        listView2.Items.Add(item2);
                        listView3.Items.Add(item3);

                        listView1.CheckBoxes = true;
                        listView1.GridLines = true;

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

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
