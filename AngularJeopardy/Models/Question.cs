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
        ///    Some questions from api do not have values so default to 100
        /// </remarks>
        public int Value { get; set; } = 100;

        /// <summary>
        /// Category that the question belongs to
        /// </summary>
        public Category Category { get; set; }
    }
}