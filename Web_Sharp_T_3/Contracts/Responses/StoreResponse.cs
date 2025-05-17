using Web_Sharp_T_3.Models;

namespace Web_Sharp_T_3.Contracts.Responses
{
    public class StoreResponse
    {
        public int Id { get; set; }
        public int Count { get; set; }
        public virtual ICollection<Product> Products { get; set; } = new List<Product>();
    }
}
