using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace xcs.DTO.Polls
{
	public class Output
	{
		public int Id { set; get; }

		[Display(Name = "Título")]
		public string Title { set; get; }

		[Display(Name = "Miembros")]
		public int Members { set; get; }

		[Display(Name = "Preguntas")]
		public int Questions { set; get; }

		[Display(Name = "Respuestas")]
		public int Answers { set; get; }

		[Display(Name = "Fecha de inicio")]
		public DateTime StartDate { set; get; }

		[Display(Name = "Fecha de cierre")]
		public DateTime? EndDate { set; get; }

		[Display(Name = "Fecha de creación")]
		public DateTime CreationDate { set; get; }

		public List<Questions.Output> PollQuestions { set; get; } = new List<Questions.Output>();
		public List<Answers.Output> PollAnswers { set; get; } = new List<Answers.Output>();
	}
}