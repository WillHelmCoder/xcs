using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace xcs.DTO.Polls.Questions
{
	public class PutInput
	{
		[Display(Name = "Texto")]
		[RegularExpression(@"^[áéíóúÁÉÍÓÚñÑa-zA-Z0-9/?¿!¡\s_#$%=\^*&.,;:)(@+-]*$", ErrorMessage = "{0} contiene caracteres invalidos.")]
		[Required(ErrorMessage = "{0} es requerido.")]
		public string Text { set; get; }

		[Display(Name = "Indice")]
		[Required(ErrorMessage = "{0} es requerido.")]
		public int Index { set; get; }

		public List<Options.PutInput> Options { set; get; }
	}
}
