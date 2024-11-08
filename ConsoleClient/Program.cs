using Grpc.Net.Client;
using GrpcServer.Porotos;

var channel=GrpcChannel.ForAddress("https://localhost:7136/");

var productClient=new ProductServices.ProductServicesClient(channel);

var result= productClient.AddNewProduct(new RequestAddProductDto
{
    Name="test2",
    Brand="test2",
    Price=200
});
Console.WriteLine(result);