using System.Collections.Generic;
using System.Threading.Tasks;
using AngularJeopardy.Models;

namespace AngularJeopardy.Api.Interface
{
    public interface IJeopardyClient
    {
        /// <summary>
        /// Gets a list of categories from the api endpoint
        /// </summary>
        /// <returns>A List of <see cref="Category"/></returns>
        Task<List<Category>> GetCategoriesAsync();

        /// <summary>
        /// Gets a list of questions from the api endpoint based on a category
        /// </summary>
        /// <param name="categoryId">Id of the <see cref="Category"/></param>
        /// <returns>A list of <see cref="Question"/></returns>
        Task<List<Question>> GetQuestionByCategoryAsync(int categoryId);
    }
}