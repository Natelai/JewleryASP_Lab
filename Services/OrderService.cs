using AutoMapper;
using DAL.Repositories.Interfaces;
using DTOs.OrderDTOs;
using Services.Interfaces;

namespace Services
{
    public class OrderService : IOrderService
    {
        private readonly IMapper _mapper;
        private readonly IOrderRepository _orderRepository;

        public OrderService(IOrderRepository orderRepository, IMapper mapper)
        {
            _orderRepository = orderRepository;
            _mapper = mapper;
        }

        public async Task DeleteManyOrdersAsync(IEnumerable<int> ids, CancellationToken cancellationToken)
        {
            foreach (var id in ids)
            {
                var order = await _orderRepository.GetByConditionAsync(o => o.Id == id, cancellationToken);
                if (order.Count > 0)
                {
                    await _orderRepository.DeleteAsync(order[0], cancellationToken);
                }
            }
        }

        public async Task DeleteOrderAsync(int id, CancellationToken cancellationToken)
        {
            var order = await _orderRepository.GetByConditionAsync(o => o.Id == id, cancellationToken);
            if (order.Count > 0)
            {
                await _orderRepository.DeleteAsync(order[0], cancellationToken);
            }
        }

        public async Task<OrderDTO> GetOrderFullInformationAsync(int id, CancellationToken cancellationToken)
        {
            var order = await _orderRepository.GetByConditionAsync(o => o.Id == id, cancellationToken);
            return _mapper.Map<OrderDTO>(order.FirstOrDefault());
        }

        public async Task<List<ShortOrderDTO>> GetShortOrderListAsync(CancellationToken cancellationToken)
        {
            var orders = await _orderRepository.GetAllAsync(cancellationToken);
            return _mapper.Map<List<ShortOrderDTO>>(orders);
        }
    }

}
