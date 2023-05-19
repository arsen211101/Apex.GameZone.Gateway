using System.ComponentModel.DataAnnotations;

namespace Apex.GameZone.Data.Entities;

public class BaseEntity
{
    [Key] 
    public int Id { get; set; }
    public DateTime AddedDate { get; set; }
    public DateTime ModifiedDate { get; set; }
    public bool IsDeleted { get; set; } = false;
}