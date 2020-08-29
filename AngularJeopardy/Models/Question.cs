using System.Text.Json.Serialization;

namespace AngularJeopardy.Models
{
    public class Question
    {
        /// <summary>
        /// Unique id of the category
        /// </summary>
        [JsonPropertyName("id")]
        public int Id { get; set; }

        /// <summary>
        /// Text of the question
        /// </summary>
        [JsonPropertyName("question")]
        public string Text { get; set; }

        /// <summary>
        /// Answer to the question
        /// </summary>
        [JsonPropertyName("answer")]
        public string Answer { get; set; }

        /// <summary>
        /// How may points is the question worth
        /// </summary>
        /// <remarks>
        ///    Some questions from api do not have values
        /// </remarks>
        [JsonPropertyName("value")]
        public int? Value { get; set; }

        /// <summary>
        /// Category identifier that the question belongs to
        /// </summary>
        [JsonPropertyName("category_id")]
        public int CategoryId { get; set; }
    }
}