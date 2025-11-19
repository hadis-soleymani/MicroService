using System.ComponentModel.DataAnnotations;

namespace IDP.Domain.Entites.BaseEntites
{
    public class BaseEntity
    {
        public BaseEntity()
        {
            this.CreateDate = DateTime.UtcNow;
        }

        [Key]
        public Int64 ID { get; set; }

        public DateTime CreateDate { get; set; }

        public DateTime UpdateDate { get; set; }
    }
}
