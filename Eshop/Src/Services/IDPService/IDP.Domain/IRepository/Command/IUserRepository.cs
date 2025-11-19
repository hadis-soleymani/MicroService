using IDP.Domain.Entites;

namespace IDP.Domain.IRepository.Command
{
    public interface IUserRepository
    {
        Task<bool> Insert(User user);
    }
}
    