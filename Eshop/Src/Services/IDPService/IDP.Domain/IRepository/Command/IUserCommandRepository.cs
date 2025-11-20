using IDP.Domain.Entites;
using IDP.Domain.IRepository.Command.Base;

namespace IDP.Domain.IRepository.Command
{
    public interface IUserCommandRepository: ICommandRepository<User>
    {
    }
}
