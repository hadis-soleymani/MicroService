using MediatR;
using System.ComponentModel.DataAnnotations;

namespace IDP.Application.Command.User
{
    public record UserCommand : IRequest<bool>
    {
        [Required(ErrorMessage = "نام اجباری است")]
        [MinLength(3)]
        public required string Name { get; set; }
    }
}
