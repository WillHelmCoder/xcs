namespace xcs.DTO.Polls.Options
{
	public class Output
	{
		public int Id { set; get; }

		public string Text { set; get; }
		public int Index { set; get; }
		public int Answers { set; get; }
		public bool IsAnswer { set; get; }
		public decimal Percentage { set; get; }

		public int PollId { set; get; }
	}
}