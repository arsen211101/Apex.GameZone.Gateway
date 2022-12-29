using System.ComponentModel.DataAnnotations;

namespace Apex.GameZone.Core.Models
{
    public class BaseModel
    {
        [Key]
        public int Id { get; set; }
        public DateTime AddedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsDeleted { get; set; } = false;
    }
}
