using DTOs.OrderDTOs;

namespace DTOs.ClientDTOs
{
    public class ClientDTO : ShortClientDTO
    {
        public List<ShortOrderDTO>? ShortOrders { get; set; }
    }
}
