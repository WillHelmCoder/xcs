using System.ComponentModel.DataAnnotations;

namespace xcs.DTO.Users
{
	public class PutInput
	{
		[Display(Name = "Email")]
		[EmailAddress(ErrorMessage = "EmailAddress")]
		[Required(ErrorMessage = "Required")]
		public string Email { set; get; }

		[Display(Name = "Nombre")]
		[MinLength(3, ErrorMessage = "MinLength")]
		[Required(ErrorMessage = "Required")]
		public string UserName { set; get; }

		[Display(Name = "Teléfono")]
		[StringLength(10, MinimumLength = 10, ErrorMessage = "ExactLength")]
		[Required(ErrorMessage = "Required")]
		public string Phone { set; get; }

		[Display(Name = "Contraseña")]
		[MinLength(6, ErrorMessage = "MinLength")]
		[Required(ErrorMessage = "Required")]
		public string Password { set; get; }

		public int Id { set; get; }
	}
}