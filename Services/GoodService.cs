using AutoMapper;
using DAL.Repositories.Interfaces;
using Domain.Entities;
using DTOs.GoodDTOs;
using Services.Interfaces;

namespace Services
{
    public class GoodService : IGoodService
    {
        private readonly IMapper _mapper;
        private readonly IGoodRepository _goodRepository;

        public GoodService(IGoodRepository goodRepository, IMapper mapper)
        {
            _goodRepository = goodRepository;
            _mapper = mapper;
        }

        public async Task<GoodDTO> GetGoodsFullInformationAsync(int id, CancellationToken cancellationToken)
        {
            var good = await _goodRepository.GetByConditionAsync(g => g.Id == id, cancellationToken);
            return _mapper.Map<GoodDTO>(good.FirstOrDefault());
        }

        public async Task<List<ShortGoodDTO>> GetShortGoodsListAsync(CancellationToken cancellationToken)
        {
            var goods = await _goodRepository.GetAllAsync(cancellationToken);
            return _mapper.Map<List<ShortGoodDTO>>(goods);
        }

        public async Task UpdateGoodSizeAsync(int id, double size, CancellationToken cancellationToken)
        {
            var good = await _goodRepository.GetByConditionAsync(g => g.Id == id, cancellationToken);
            if (good.Count > 0)
            {
                good[0].Size = size;
                await _goodRepository.UpdateAsync(good[0], cancellationToken);
            }
        }
    }
}
