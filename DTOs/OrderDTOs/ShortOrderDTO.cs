using DTOs.GoodDTOs;

namespace DTOs.OrderDTOs
{
    public class ShortOrderDTO : BaseDTO
    {
        public double Total { get; set; }
        public DateTime OrderTime { get; set; }
    }
}
