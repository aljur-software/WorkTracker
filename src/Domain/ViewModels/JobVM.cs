using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.ViewModels
{
    public class JobVM
    {
        public Guid Id { get; set; }
        public int ContractorId { get; set; }
        public string Name { get; set; }
        public int? Floor { get; set; }
        public int? Room { get; set; }
        public string DelayReason { get; set; } //[Max 50]
        public DateTime? DateCreated { get; set; }
        public DateTime? DateCompleted { get; set; }
        public DateTime? DateDelayed { get; set; }
        public int? StatusNum { get; set; }
        public int? RJobID { get; set; }
        public RoomTypeVM RoomType { get; set; }
    }
}
