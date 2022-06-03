using System.Collections.Generic;

namespace xcs.DTO.Polls.Questions
{
	public class PostInput
	{
		public string Text { set; get; }

		public List<Options.PostInput> Answers { set; get; }
	}
}
