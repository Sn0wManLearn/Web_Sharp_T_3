using Web_Sharp_T_3.Models;

namespace Web_Sharp_T_3.Contracts.Requests.Store
{
    public class StoreUpdateRequest
    {
        public int Id { get; set; }
        public int Count { get; set; } = 0;
        public Models.Store StoreGetEntity()
        {
            return new Models.Store()
            {
                Id = Id,
                Count = Count
            };
        }
    }
}
