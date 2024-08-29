using ConsumeAPIExample.DTO;

namespace ConsumeApiExample.Services
{
    public interface IReqresService
    {
        Task<UserDTO> GetUserByIdAsync(int id);
        Task<UsersDTO> GetUsers();
    }
}
