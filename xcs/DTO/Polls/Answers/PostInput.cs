using System.Collections.Generic;

namespace xcs.DTO.Polls.Answers
{
	public class PostInput
	{
		public string PollQuestionId { set; get; }
		public string PollOptionId { set; get; }
	}
}
