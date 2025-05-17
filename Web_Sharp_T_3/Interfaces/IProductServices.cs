using Web_Sharp_T_3.Contracts.Requests.Products;
using Web_Sharp_T_3.Contracts.Responses;

namespace Web_Sharp_T_3.Interfaces
{
    public interface IProductServices
    {
        public int AddProduct(ProductCreateRequest product);
        public IEnumerable<ProductResponse> GetProducts();

        public ProductResponse GetProductById(int id);
        public bool DeleteProduct(int id);
        public bool UpdatePrice(int idProduct, int price);
        public bool DeleteCategory(string category);
    }
}
