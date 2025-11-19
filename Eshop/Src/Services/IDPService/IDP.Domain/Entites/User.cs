namespace IDP.Domain.Entites
{
    public class User : BaseEntites.BaseEntity
    {
        public required string FullName { get; set; }

        public required string CodeNumber { get; set; }
    }
}
