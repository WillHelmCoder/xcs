using System.ComponentModel.DataAnnotations;

namespace xcs.DTO.Account
{
	public class PostLoginInput
	{
		[Required(ErrorMessage = "Required")]
		public string Email { set; get; }

		[Required(ErrorMessage = "Required")]
		public string Password { set; get; }
	}
}