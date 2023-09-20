using Crud_Produto.Controllers;
using Crud_Produto.Model;

namespace Crud_Produto
{
    public partial class Form1 : Form
    {
        ProductController productController;
        public Form1()
        {
            InitializeComponent();
            productController = new ProductController();
            ProductsDetails.DataSource = productController.getAllProducts();
        }
        private void ClearControls()
        {
            InputId.Text = "";
            inputName.Text = "";
            InputDescription.Text = "";
            InputQuantity.Text = "";
            InputPrice.Text = "";
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {
            this.productController = new ProductController();
            if (string.IsNullOrWhiteSpace(inputName.Text) && string.IsNullOrWhiteSpace(InputId.Text))
            {
                MessageBox.Show("Preencha o Id e Nome do produto");
                return; 
            }
            if (string.IsNullOrWhiteSpace(InputQuantity.Text) && string.IsNullOrWhiteSpace(InputPrice.Text))
            {
                MessageBox.Show("Preencha a Quantidade e Preco");
                return;
            }
            var productId = Convert.ToInt32(InputId.Text);
            var productName = inputName.Text;
            var productQuantity = Convert.ToInt32(InputQuantity.Text);
            var productPrice = Convert.ToDouble(InputPrice.Text);
            var productDescription = InputDescription.Text;
            var sucess = productController.insertProduct(productId, productName, productQuantity, productPrice, productDescription);

            ProductsDetails.DataSource = productController.getAllProducts();

            if (sucess)
            {
                ClearControls();
                MessageBox.Show("Add succesfuly");
            }
            else
            {
                MessageBox.Show("Error");

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClearControls();
        }

        private void Update_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(inputName.Text) && string.IsNullOrWhiteSpace(InputId.Text))
            {
                MessageBox.Show("Preencha o Id e Nome do produto");
                return;
            }
            if (string.IsNullOrWhiteSpace(InputQuantity.Text) && string.IsNullOrWhiteSpace(InputPrice.Text))
            {
                MessageBox.Show("Preencha a Quantidade e Preco");
                return;
            }
            this.productController = new ProductController();
            var productId = Convert.ToInt32(InputId.Text);
            var productName = inputName.Text;
            var productQuantity = Convert.ToInt32(InputQuantity.Text);
            var productPrice = Convert.ToDouble(InputPrice.Text);
            var productDescription = InputDescription.Text;

            var sucess = productController.UpdateProduct(productId, productName, productQuantity, productPrice, productDescription);
            ProductsDetails.DataSource = productController.getAllProducts();

            if (sucess)
            {
                ClearControls();
                MessageBox.Show("Update succesfuly");
            }
            else
            {
                MessageBox.Show("Error");

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(inputName.Text) && string.IsNullOrWhiteSpace(InputId.Text))
            {
                MessageBox.Show("Selecione o produto na listagem pra excluir");
                return;
            }
            this.productController = new ProductController();
            var productId = Convert.ToInt32(InputId.Text);
            var success = productController.DeleteProduct(productId);

            ProductsDetails.DataSource = productController.getAllProducts();

            if (success)
            {
                // Clear controls once the employee is inserted successfully
                ClearControls();
                MessageBox.Show("Deletado");
            }
            else
                MessageBox.Show("Error occured. Please try again...");
        }

        private void ProductsDetails_RowHeaderMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {

            var index = e.RowIndex;
            InputId.Text = ProductsDetails.Rows[index].Cells[0].Value.ToString();
            inputName.Text = ProductsDetails.Rows[index].Cells[1].Value.ToString();
            InputQuantity.Text = ProductsDetails.Rows[index].Cells[2].Value.ToString();
            InputPrice.Text = ProductsDetails.Rows[index].Cells[3].Value.ToString();

        }
    }
}