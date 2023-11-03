using DTOs.MaterialDTOs;

namespace Services.Interfaces
{
    public interface IMaterialService
    {
        Task<List<MaterialDTO>> GetMaterialListAsync(CancellationToken cancellationToken);

        Task DeleteMaterialAsync(int id, CancellationToken cancellationToken);

        Task AddMaterial(MaterialDTO material, CancellationToken cancellationToken);

        Task AddMaterialRange(IEnumerable<MaterialDTO> materials, CancellationToken cancellationToken);

        Task UpdateMaterialPriceAsync(int id, int price, CancellationToken cancellationToken);
    }
}
