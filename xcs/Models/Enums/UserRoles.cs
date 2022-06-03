using System.ComponentModel.DataAnnotations;
namespace xcs.Models;

public enum UserRoles
{
	[Display(Name = "Ninguno")]
	None = 0,

	[Display(Name = "Usuario")]
	User = 1,




	[Display(Name = "Staff")]
	Staff = 90,

	[Display(Name = "Admin")]
	Admin = 100,
}