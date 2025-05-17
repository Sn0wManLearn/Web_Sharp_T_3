using Web_Sharp_T_3.Contracts.Responses;
using Web_Sharp_T_3.Contracts.Requests.Store;

namespace Web_Sharp_T_3.Interfaces
{
    public interface IStoreServices
    {
        int AddStore(StoreCreateRequest CreateStoreRequest);

        IEnumerable<ProductResponse> GetProductsInStore(int id);

        int GetCountInStore(int id);
    }
}
