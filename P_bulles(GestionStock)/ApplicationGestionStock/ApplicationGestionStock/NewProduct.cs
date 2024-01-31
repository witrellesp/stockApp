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
    public partial class NewProduct : Form
    {
        public NewProduct()
        {
            InitializeComponent();
        }
        //conexion avec la base de données

        private void button2_Click(object sender, EventArgs e)
        {

            string nameProduit = inputName.Text;

            int stockProduit;
            int priceProduit;

            bool isPriceValide = int.TryParse(inputPrice.Text, out priceProduit);
            bool isStockValide = int.TryParse(inputStock.Text, out stockProduit);


            string supplierProduit = inputSupplier.Text;
            string colorProduit = inputColor.Text;
            string descrptProduit = inputDescrpt.Text;


            if (!(isPriceValide)||!(isStockValide))
            {
                /*
                TypeError pageError = new TypeError();
                pageError.Show(); 
                */
                }
            else
            {string message = $"NameProduct: {nameProduit}\n" +
                                 $"Price: {priceProduit}\n" +
                                 $"Stock: {stockProduit}\n" +
                                 $"Supplier: {supplierProduit}\n" +
                                 $"Color: {colorProduit}\n" +
                                 $"Description: {descrptProduit}\n\n" +
                                 "Sont-ils corrects ces données?";

                DialogResult dialogResult = MessageBox.Show(message, "Confirmer les données", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        try
                        {
                            connection.Open();
                            Console.WriteLine("Connexion OK");
                        }
                        catch (MySqlException ex)
                        {
                            Console.WriteLine($"Erreur {ex.Message}");
                        }
                    }
                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        try
                        {
                            connection.Open();

                            string query = "INSERT INTO t_product (name,price,stock,color,supplier,description) " +
                                           "VALUES (@nameProduit, @priceProduit,@stockProduit,@colorProduit,@supplierProduit,@descrptProduit)";
                            MySqlCommand cmd = new MySqlCommand(query, connection);

                            cmd.Parameters.AddWithValue("@nameProduit", nameProduit);
                            cmd.Parameters.AddWithValue("@priceProduit", priceProduit);
                            cmd.Parameters.AddWithValue("@stockProduit", stockProduit);
                            cmd.Parameters.AddWithValue("@colorProduit", colorProduit);
                            cmd.Parameters.AddWithValue("@supplierProduit", supplierProduit);
                            cmd.Parameters.AddWithValue("@descrptProduit", descrptProduit);

                            cmd.ExecuteNonQuery();
                        }
                        catch (MySqlException ex)
                        {
                            Console.WriteLine($"Erreur {ex.Message}");
                        }
                    }
                }
                else
                {
                    this.Hide();
                    NewProduct pageProducts = new NewProduct();

                    pageProducts.Show();
                }
            }
        }
        string connectionString = "Server=localhost;Port=6033;Database=db_stock;User Id=root;Password=root;";
        

        private void backButton2(object sender, EventArgs e)
        {
            this.Hide();
            ApStock pagePrincipal = new ApStock();
            pagePrincipal.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        

        private void label5_Click(object sender, EventArgs e)
        {

        }

     

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void inputName_TextChanged(object sender, EventArgs e)
        {

        }

        private void inputPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void inputStock_TextChanged(object sender, EventArgs e)
        {

        }

        private void inputSupplier_TextChanged(object sender, EventArgs e)
        {

        }

        private void inputColor_TextChanged(object sender, EventArgs e)
        {

        }

        private void inputDescrpt_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void NewProduct_Load(object sender, EventArgs e)
        {

        }
    }
}
