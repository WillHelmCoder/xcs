using System;

namespace xcs.DTO.Articles
{
	public class Output
	{
		public int Id { set; get; }
		public string Title { set; get; }
		public string Body { set; get; }
		public string Author { set; get; }
		public string GUID { set; get; }
		public DateTime CreationDate { set; get; }
	}
}
