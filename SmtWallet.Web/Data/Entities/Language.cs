using System.ComponentModel.DataAnnotations;

namespace SmtWallet.Web.Data.Entities
{
    public class Language: BaseEntity<int>
    {
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
    }
}
