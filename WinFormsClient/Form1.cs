using Grpc.Net.Client;
using GrpcServer.Porotos;

namespace WinFormsClient
{
    public partial class Form1 : Form
    {
        GrpcChannel _channel;
        ProductServices.ProductServicesClient _productServicesClient;
        public Form1()
        {
            InitializeComponent();
            _channel = GrpcChannel.ForAddress("https://localhost:7136/");
            _productServicesClient = new ProductServices.ProductServicesClient(_channel);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnGetProduct_Click(object sender, EventArgs e)
        {
            var result = _productServicesClient.GetAllProduct(new RequestAllProduct
            {
                Page = 1,
                PageSize = 200,
            });

            dataGridView1.Rows.Clear();
            foreach (var product in result.Items)
            {
                dataGridView1.Rows.Add(product.Name, product.Brand, product.Price);
            }
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            var result = _productServicesClient.AddNewProduct(new RequestAddProductDto
            {
                Name=txtName.Text,
                Brand=txtBrand.Text,
                Price=int.Parse(txtPrice.Text),
            });
        }
    }
}
