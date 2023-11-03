using DTOs.GoodDTOs;
using DTOs.OrderDTOs;

namespace Services.Interfaces
{
    public interface IGoodService
    {
        Task<List<ShortGoodDTO>> GetShortGoodsListAsync(CancellationToken cancellationToken);

        Task<GoodDTO> GetGoodsFullInformationAsync(int id, CancellationToken cancellationToken);

        Task UpdateGoodSizeAsync(int id, double size, CancellationToken cancellationToken);
    }
}
