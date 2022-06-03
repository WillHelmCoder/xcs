using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace xcs.DTO.Polls.Answers
{
	public class AnswerInput
	{
		[Required(ErrorMessage = "Required")]
		[Display(Name = "Encuesta")]
		public int PollId { set; get; }

		[Display(Name = "Respuestas")]
		public List<AnswerOption> Answers { set; get; }
	}
}
