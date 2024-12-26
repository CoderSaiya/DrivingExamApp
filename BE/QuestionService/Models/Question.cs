namespace QuestionService.Models
{
    public class Question
    {
        public int Id { get; set; }
        public string Content { get; set; } = string.Empty;
        public string? ImgUrl { get; set; }
        public List<Answer> Answers { get; set; } = new List<Answer>();
    }
}
