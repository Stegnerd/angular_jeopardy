using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AngularJeopardy.Api.Interface;
using AngularJeopardy.Models;
using AngularJeopardy.Services.Interface;

namespace AngularJeopardy.Services
{
    public class JeopardyService : IJeopardyService
    {
        private readonly IJeopardyClient _client;
        public JeopardyService(IJeopardyClient client)
        {
            _client = client;
        }
        
        public  async Task<IList<Category>> GetQuestionsByCategoryAsync()
        {
            // Get a list of categories
            var categories = await _client.GetCategoriesAsync();

            // foreach category get questions
            foreach (var category in categories)
            {
                var questions = await _client.GetQuestionByCategoryAsync(category.Id);
                
                // Filter complete list into 
                var filteredQuestions = GenerateSafeListQuestion(questions);
                
                category.Questions = filteredQuestions;
            }

            return categories;
        }

        #region Private functions

        /// <summary>
        /// Generates a list of questions that abide by business logic
        /// </summary>
        /// <param name="potentialQuestions">List of all potential questions</param>
        /// <returns>A list of <see cref="Question"/></returns>
        /// <remarks>
        ///    Used to add values where null and get a set of 100 to 500 values
        ///     since a category can have more than 5 questions
        /// </remarks>
        private IList<Question> GenerateSafeListQuestion(List<Question> potentialQuestions)
        {
            var dictionary = new Dictionary<int, Question>();

            var incrementer = 200;

            var valueOrderedQuestions = potentialQuestions.OrderBy(_ => _.Value);
            
            foreach (var question in valueOrderedQuestions)
            {
                // only need 5 questions so stop iteration
                if (incrementer == 1200)
                {
                    break;
                }
                
                // if null value from api, set to current looking value
                if (question.Value == null)
                {
                    question.Value = incrementer;
                }
                
                // if question matches value looking for or if null
                if (question.Value == incrementer )
                {
                    // TODO Filter by context (answered before?) as well
                    if (!dictionary.ContainsKey(incrementer))
                    {
                        dictionary.Add(incrementer, question);
                        incrementer += 200;
                    }
                }
            }

            return dictionary.Values.ToList();
        }
        
        #endregion Private functions
    }
}