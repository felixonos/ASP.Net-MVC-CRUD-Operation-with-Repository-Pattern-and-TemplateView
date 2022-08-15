using System.ComponentModel.DataAnnotations;

namespace SmtWallet.Web.Data.Entities
{
    public class Nationality: BaseEntity<Guid>
    {
        [Required]
        [MaxLength(200)]
        public string Name { get; set; }

        [Required]
        [MaxLength(5)]
        public string Isocode { get; set; }

        [Required]
        [MaxLength(5)]
        public string Callcode { get; set; }
    }
}
