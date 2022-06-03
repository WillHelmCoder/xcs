using System.ComponentModel.DataAnnotations;
using xcs.Models;

namespace xcs.DTO.Attachments
{
	public class PostInput
	{
		//[Required]
		public string Code { set; get; }

		[Required(ErrorMessage = "Required")]
		public string Description { set; get; }

		[Required(ErrorMessage = "Required")]
		public AttachmentTypes Type { set; get; }

		//[Required]
		//public DateTime CreationDate { set; get; }
	}
}