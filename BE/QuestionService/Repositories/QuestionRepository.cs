using Microsoft.EntityFrameworkCore;
using QuestionService.Data;
using QuestionService.Models;

namespace QuestionService.Repositories
{
    public class QuestionRepository : IQuestion
    {
        private readonly QuestionDbContext _context;

        public QuestionRepository(QuestionDbContext context)
        {
            _context = context;
        }

        public async void AddQuestion(Question question)
        {
            await _context.Questions.AddAsync(question);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Question>> GetAllQuestions()
        {
            return await _context.Questions.ToListAsync();
        }
    }
}
