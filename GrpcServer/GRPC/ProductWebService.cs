using Grpc.Core;
using GrpcServer.Porotos;

namespace GrpcServer.GRPC
{
    public class ProductWebService: ProductServices.ProductServicesBase
    {
        static List<Product> products = new List<Product>()
        {
           new Product{Name="test",Brand="test",Price=50}
        };
        public override Task<ResponseAddNewProduct> AddNewProduct(RequestAddProductDto request, ServerCallContext context)
        {
           products.Add(new Product
           {
               Name=request.Name,
               Brand=request.Brand,
               Price=request.Price,
           });
            return Task.FromResult (new  ResponseAddNewProduct
            {
                IsSucess = true
            });
        }

        public override Task<ResponceAllProduct> GetAllProduct(RequestAllProduct request, ServerCallContext context)
        {
            var response = new ResponceAllProduct();
            response.Items.AddRange(products.Select(p => new ProductItem
            {
                Brand = p.Brand,
                Name = p.Name,
                Price = p.Price
            }));

            return Task.FromResult(response);
        }

    }
    public class Product
    {
        public string Name { get; set; }
        public string Brand { get; set; }
        public int Price { get; set; }
    }
}
