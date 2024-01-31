using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApplicationGestionStock
{
    public partial class ApStock : Form
    {
        public ApStock()
        {
            InitializeComponent();
        }

        private void addButton(object sender, EventArgs e)
        {
            this.Hide();
            NewProduct pageProducts = new NewProduct();

            pageProducts.Show();
        }   

        private void listProducts(object sender, EventArgs e)
        {
            this.Hide();
            Products pageListeProducts = new Products();

            pageListeProducts.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
