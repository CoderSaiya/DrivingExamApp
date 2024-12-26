using Microsoft.EntityFrameworkCore;
using QuestionService.Models;

namespace QuestionService.Data
{
    public class QuestionDbContext : DbContext
    {
        public QuestionDbContext(DbContextOptions<QuestionDbContext> options) : base(options)
        {
        }

        public DbSet<Question> Questions { get; set; }
    }
}
