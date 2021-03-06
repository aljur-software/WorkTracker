﻿using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.DataModels
{
    public class Job
	{
		public Guid Id { get; set; }
		public int? ContractorID { get; set; }		
		public string Name { get; set; } 
		public  string Status { get; set; } 
		public int? Floor { get; set; }
		public int? Room { get; set; }
		public string DelayReason { get; set; } 
		public DateTime? DateCreated { get; set; }
		public DateTime? DateCompleted { get; set; }
		public DateTime? DateDelayed { get; set; }
		public int? StatusNum { get; set; }
		public int? RJobID { get; set; }
        public Guid RoomTypeId { get; set; }
        [ForeignKey("RoomTypeId")]
        public RoomType Rx_RoomType { get; set; }

	}
}
