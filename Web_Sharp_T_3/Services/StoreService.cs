using AutoMapper;
using Web_Sharp_T_3.Contexts;
using Web_Sharp_T_3.Contracts.Requests.Store;
using Web_Sharp_T_3.Contracts.Responses;
using Web_Sharp_T_3.Interfaces;
using Web_Sharp_T_3.Models;

namespace Web_Sharp_T_3.Services
{
    public class StoreService : IStoreServices
    {
        private readonly IMapper _mapper;
        private readonly StoreContext _storeContext;

        public StoreService(StoreContext storeContext, IMapper mapper)
        {
            _storeContext = storeContext;
            _mapper = mapper;
        }
        public int AddStore(StoreCreateRequest createStoreRequest)
        {
            var mapEntity = _mapper.Map<Store>(createStoreRequest);
            _storeContext.Stores.Add(mapEntity);
            _storeContext.SaveChanges();

            return mapEntity.Id;
        }

        public IEnumerable<ProductResponse> GetProductsInStore(int id)
        {
            Store? store = _storeContext.Stores.FirstOrDefault(s => s.Id == id);
            IEnumerable<ProductResponse> products = store.Products.Select(_mapper.Map<ProductResponse>).ToList();

            return products;
        }
        public int GetCountInStore(int id)
        {
            Store? store = _storeContext.Stores.FirstOrDefault(s => s.Id == id);
            return store.Count;
        }
    }
}
