namespace AngularJeopardy.Models
{
    public class Question
    {
        /// <summary>
        /// Unique id of the category
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Text of the question
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        /// Answer to the question
        /// </summary>
        public string Answer { get; set; }

        /// <summary>
        /// How may points is the question worth
        /// </summary>
        /// <remarks>
        ///    Some questions from api do not have values
        /// </remarks>
        public int? Value { get; set; }

        /// <summary>
        /// Category identifier that the question belongs to
        /// </summary>
        public int CategoryId { get; set; }
    }
}