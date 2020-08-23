using System.Collections.Generic;

namespace AngularJeopardy.Models
{
    public class Category
    {
        /// <summary>
        /// Unique id of the category
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Name of the category
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// How many questions are available in this category
        /// </summary>
        public int ClueCount { get; set; }

        /// <summary>
        /// List of questions related to the category
        /// </summary>
        public IList<Question> Questions { get; set; }
    }
}