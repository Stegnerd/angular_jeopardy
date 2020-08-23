using System.Collections.Generic;
using System.Threading.Tasks;
using AngularJeopardy.Models;

namespace AngularJeopardy.Services.Interface
{
    public interface IJeopardyService
    {
        Task<IList<Category>> GetQuestionsByCategoryAsync();
    }
}