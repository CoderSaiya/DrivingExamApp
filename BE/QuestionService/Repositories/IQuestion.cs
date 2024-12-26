using QuestionService.Models;

namespace QuestionService.Repositories
{
    public  interface IQuestion
    {
        Task<List<Question>> GetAllQuestions();
        void AddQuestion(Question question);
    }
}
