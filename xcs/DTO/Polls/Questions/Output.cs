using System.Collections.Generic;

namespace xcs.DTO.Polls.Questions
{
	public class Output
	{
		public int Id { set; get; }

		public string Text { set; get; }
		public int Index { set; get; }
		public int Answers { set; get; }

		public List<Options.Output> PollOptions { set; get; }
	}
}