using DTOs.OrderDTOs;

namespace Services.Interfaces
{
    public interface IOrderService
    {
        Task<List<ShortOrderDTO>> GetShortOrderListAsync(CancellationToken cancellationToken);

        Task<OrderDTO> GetOrderFullInformationAsync(int id, CancellationToken cancellationToken);

        Task DeleteOrderAsync(int id, CancellationToken cancellationToken);

        Task DeleteManyOrdersAsync(IEnumerable<int> ids, CancellationToken cancellationToken);
    }
}