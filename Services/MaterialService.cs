using AutoMapper;
using DAL.Repositories.Interfaces;
using Domain.Entities;
using DTOs.MaterialDTOs;
using Services.Interfaces;

namespace Services
{
    public class MaterialService : IMaterialService
    {
        private readonly IMapper _mapper;
        private readonly IMaterialRepository _materialRepository;

        public MaterialService(IMaterialRepository materialRepository, IMapper mapper)
        {
            _materialRepository = materialRepository;
            _mapper = mapper;
        }

        public async Task AddMaterial(MaterialDTO material, CancellationToken cancellationToken)
        {
            var materialEntity = _mapper.Map<Material>(material);
            await _materialRepository.CreateAsync(materialEntity, cancellationToken);
        }

        public async Task DeleteMaterialAsync(int id, CancellationToken cancellationToken)
        {
            var material = await _materialRepository.GetByConditionAsync(m => m.Id == id, cancellationToken);
            if (material.Count > 0)
            {
                await _materialRepository.DeleteAsync(material[0], cancellationToken);
            }
        }

        public async Task<List<MaterialDTO>> GetMaterialListAsync(CancellationToken cancellationToken)
        {
            var materials = await _materialRepository.GetAllAsync(cancellationToken);
            return _mapper.Map<List<MaterialDTO>>(materials);
        }

        public async Task UpdateMaterialPriceAsync(int id, int price, CancellationToken cancellationToken)
        {
            var material = await _materialRepository.GetByConditionAsync(m => m.Id == id, cancellationToken);
            if (material.Count > 0)
            {
                material[0].Price = price;
                await _materialRepository.UpdateAsync(material[0], cancellationToken);
            }
        }

        public async Task AddMaterialRange(IEnumerable<MaterialDTO> materials, CancellationToken cancellationToken)
        {
            var materialEntities = _mapper.Map<List<Material>>(materials);
            await _materialRepository.CreateRangeAsync(materialEntities, cancellationToken);
        }
    }
}
