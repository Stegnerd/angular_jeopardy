using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace AngularJeopardy.Models
{
    public class Category
    {
        /// <summary>
        /// Unique id of the category
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; set; }

        /// <summary>
        /// Name of the category
        /// </summary>
        [JsonPropertyName("title")]
        public string Name { get; set; }

        /// <summary>
        /// How many questions are available in this category
        /// </summary>
        [JsonPropertyName("clues_count")]
        public int ClueCount { get; set; }

        /// <summary>
        /// List of questions related to the category
        /// </summary>
        public IList<Question> Questions { get; set; }
    }
}