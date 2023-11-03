using DTOs.ClientDTOs;

namespace Services.Interfaces
{
    public interface IClientService
    {
        Task<List<ShortClientDTO>> GetShortClientListAsync(CancellationToken cancellationToken);

        Task<ClientDTO> GetClientFullInformationAsync(int id, CancellationToken cancellationToken);

        Task UpdateLastNameAsync(int id, string LastName, CancellationToken cancellationToken);

        Task DeleteClientAsync(int id, CancellationToken cancellationToken);
    }
}