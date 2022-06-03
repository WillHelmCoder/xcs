using System.Collections.Generic;

namespace xcs.DTO.Polls.Answers
{
	public class Output
	{
		public int Id { set; get; }

		public string Name { set; get; }

		public int PollId { set; get; }

		public List<Questions.Answers.Output> QuestionAnswers { set; get; }
	}
}