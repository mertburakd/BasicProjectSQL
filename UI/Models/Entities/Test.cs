using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UI.Models.Entities
{
    [Table("Test", Schema = "dbo")]
    public class Test
    {
        [Key]
        public int Id { get; set; }
        public string? Names { get; set; }
    }
}
