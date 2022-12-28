using System;

namespace Apex.GameZone.API.ViewModels
{
    public class CommonViewModel
    {
        public int Id { get; set; }
        public DateTime? AddedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public bool IsDeleted { get; set; } = false;
    }
}
