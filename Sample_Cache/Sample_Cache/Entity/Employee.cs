﻿using System.ComponentModel.DataAnnotations;

namespace Sample_Cache.Entity
{
	public class Employee
	{
		public int Id { get; set; }

		[Required]
		public string FirstName { get; set; }

		[Required]
		public string LastName { get; set; }

		[Required]
		public string EmailId { get; set; }
	}
}
