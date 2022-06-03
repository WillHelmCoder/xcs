using System.ComponentModel.DataAnnotations;

namespace xcs.DTO.Articles
{
	public class PostPutInput
	{
		[Required(ErrorMessage = "Required")]
		[MaxLength(255, ErrorMessage = "MaxLength")]
		public string Title { set; get; }

		[Display(Name = "Cuerpo de la noticia")]
		[Required(ErrorMessage = "Required")]
		[MaxLength(5000, ErrorMessage = "MaxLength")]
		public string Body { set; get; }

		[Display(Name = "Autor")]
		[Required(ErrorMessage = "Required")]
		[MaxLength(255, ErrorMessage = "MaxLength")]
		public string Author { set; get; }

		public int Id { set; get; }
	}
}