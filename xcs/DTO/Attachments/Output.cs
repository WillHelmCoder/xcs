using xcs.Models;

namespace xcs.DTO.Attachments
{
	public class Output
	{
		public int Id { set; get; }

		public string Code { set; get; }

		public string Description { set; get; }

		public AttachmentTypes Type { set; get; }

		//[Required]
		//public DateTime CreationDate { set; get; }
	}
}