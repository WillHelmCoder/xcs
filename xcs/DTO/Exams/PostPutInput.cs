using System;
using System.ComponentModel.DataAnnotations;

namespace xcs.DTO.Exams
{
	public class PostPutInput
	{
		[Required(ErrorMessage = "Required")]
		public string Title { set; get; }

		[Required(ErrorMessage = "Required")]
		public string Description { set; get; }

		[Required(ErrorMessage = "Required")]
		public string Instructions { set; get; }

		//[Required]
		public DateTime? StartDate { set; get; }

		//[Required]
		public DateTime? EndDate { set; get; }
	}
}