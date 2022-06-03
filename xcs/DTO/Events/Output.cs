using System;

namespace xcs.DTO.Events
{
	public class Output
	{
		public int Id { set; get; }
		public string Text { set; get; }
		public int XipeCoins { set; get; }
		public DateTime CreationDate { set; get; }

		public int UserId { set; get; }
		public string UserName { set; get; }
	}
}