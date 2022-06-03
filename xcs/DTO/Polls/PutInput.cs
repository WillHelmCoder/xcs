using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace xcs.DTO.Polls
{
	public class PutInput
	{
		[Display(Name = "Título")]
		[RegularExpression(@"^[áéíóúÁÉÍÓÚñÑa-zA-Z0-9/?¿!¡\s_#$%=\^*&.,;:)(@+-]*$", ErrorMessage = "{0} contiene caracteres invalidos.")]
		[Required(ErrorMessage = "{0} es requerido.")]
		public string Title { set; get; }

		[Display(Name = "Fecha de inicio")]
		[DataType(DataType.Date, ErrorMessage = "Formato de fecha inválido")]
		[Required(ErrorMessage = "{0} es requerida.")]
		public DateTime StartDate { set; get; }

		[Display(Name = "Fecha de cierre")]
		[DataType(DataType.Date, ErrorMessage = "Formato de fecha inválido")]
		public DateTime? EndDate { set; get; }

		[Display(Name = "Preguntas")]
		public List<Questions.PutInput> Questions { get; set; } = new List<Questions.PutInput>();

		public int Id { set; get; }
	}
}