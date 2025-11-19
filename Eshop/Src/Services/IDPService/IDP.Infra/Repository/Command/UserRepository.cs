using IDP.Domain.Entites;
using IDP.Domain.IRepository.Command;

namespace IDP.Infra.Repository.Command
{
    public class UserRepository : IUserRepository
    {
        public Task<bool> Insert(User user)
        {
            return true;
        }
    }
}
