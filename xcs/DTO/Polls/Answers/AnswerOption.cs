using System.ComponentModel.DataAnnotations;

namespace xcs.DTO.Polls.Answers
{
	public class AnswerOption
	{
		[Required(ErrorMessage = "Required")]
		[Display(Name = "Pregunta")]
		public int Question { set; get; }

		[Display(Name = "Respuesta")]
		public int Option { set; get; }

		[Display(Name = "Texto")]
		public string Text { set; get; }
	}
}
