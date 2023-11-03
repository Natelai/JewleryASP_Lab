
using DTOs.ClientDTOs;
using DTOs.GoodDTOs;

namespace DTOs.OrderDTOs
{
    public class OrderDTO : ShortOrderDTO
    {
        public ShortGoodDTO? Good { get; set; }
        public ShortClientDTO? Client { get; set; }
    }
}
