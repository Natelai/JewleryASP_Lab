using AutoMapper;
using DAL.Repositories.Interfaces;
using DTOs.ClientDTOs;
using Services.Interfaces;

namespace Services
{
    public class ClientService : IClientService
    {
        private readonly IMapper _mapper;
        private readonly IClientRepository _clientRepository;

        public ClientService(IClientRepository clientRepository, IMapper mapper)
        {
            _clientRepository = clientRepository;
            _mapper = mapper;
        }
        public async Task DeleteClientAsync(int id, CancellationToken cancellationToken)
        {
            var client = await _clientRepository.GetByConditionAsync(c => c.Id == id, cancellationToken);
            if (client.Count > 0)
            {
                await _clientRepository.DeleteAsync(client[0], cancellationToken);
            }
        }

        public async Task<ClientDTO> GetClientFullInformationAsync(int id, CancellationToken cancellationToken)
        {
            var client = await _clientRepository.GetByConditionAsync(c => c.Id == id, cancellationToken);
            return _mapper.Map<ClientDTO>(client.FirstOrDefault());
        }

        public async Task<List<ShortClientDTO>> GetShortClientListAsync(CancellationToken cancellationToken)
        {
            var clients = await _clientRepository.GetAllAsync(cancellationToken);
            return _mapper.Map<List<ShortClientDTO>>(clients);
        }

        public async Task UpdateLastNameAsync(int id, string LastName, CancellationToken cancellationToken)
        {
            var client = await _clientRepository.GetByConditionAsync(c => c.Id == id, cancellationToken);
            if (client.Count > 0)
            {
                client[0].LastName = LastName;
                await _clientRepository.UpdateAsync(client[0], cancellationToken);
            }
        }
    }
}
