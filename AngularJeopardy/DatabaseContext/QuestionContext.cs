using AngularJeopardy.Models;
using Microsoft.EntityFrameworkCore;

namespace AngularJeopardy.DatabaseContext
{
    public class QuestionContext : DbContext
    {
        /// <summary>
        /// used for Dependency Injection from startup. allows us to take in DbContextOptions from start.cs
        /// and apply then to the base constructor
        /// </summary>
        /// <param name="options">Settings from the context of the startup file</param>
        public QuestionContext(DbContextOptions<QuestionContext> options): base(options){}
        
        /// <summary>
        /// This is the table that represents the Question table in the jeopardy database
        /// </summary>
        public DbSet<Question> Questions { get; set; }
        
        /// <summary>
        /// This is the table that represents the Category table in teh jeopardy database
        /// </summary>
        public DbSet<Category> Categories { get; set; }
    }
}