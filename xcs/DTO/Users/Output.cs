using xcs.Models;

namespace xcs.DTO.Users
{
	public class Output
	{
		public int Id { set; get; }
		public string Email { set; get; }
		public string UserName { set; get; }
		public string Phone { set; get; }
		public decimal Balance { set; get; }
		public UserRoles Role { set; get; }
		public DateTime CreationDate { set; get; }
		public string GUID { set; get; }
	}
}
