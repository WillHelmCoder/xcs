using System;

namespace xcs.DTO.Exams
{
	public class Output
	{
		public int Id { set; get; }
		public string Title { set; get; }

		public string Description { set; get; }

		public string Instructions { set; get; }

		public DateTime? StartDate { set; get; }

		public DateTime? EndDate { set; get; }
		public string GUID { set; get; }
	}
}
