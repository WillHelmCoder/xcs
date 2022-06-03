using System.ComponentModel.DataAnnotations;

namespace xcs.DTO.Events
{
	public class PostInput
	{
		[Display(Name = "Usuario")]
		[Required(ErrorMessage = "Required")]
		public int UserId { set; get; }

		[Display(Name = "Texto")]
		[Required(ErrorMessage = "Required")]
		public string Text { set; get; }

		[Display(Name = "XipeCoins")]
		[Required(ErrorMessage = "Required")]
		[Range(1, 999, ErrorMessage = "Range")]
		public int XipeCoins { set; get; }
	}
}