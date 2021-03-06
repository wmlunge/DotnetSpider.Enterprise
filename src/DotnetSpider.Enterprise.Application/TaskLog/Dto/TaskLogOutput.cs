﻿using System;
using System.ComponentModel.DataAnnotations;

namespace DotnetSpider.Enterprise.Application.TaskLog.Dto
{
	public class TaskLogOutput
	{
		public string Identity { get; set; }

		public string NodeId { get; set; }
	
		public DateTime? Logged { get; set; } 

		public string Level { get; set; }
		public string Message { get; set; }
		public string Exception { get; set; }
	}
}
