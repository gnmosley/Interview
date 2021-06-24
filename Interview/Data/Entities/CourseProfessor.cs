namespace Data.Entities
{
	/// <summary>
	///		Represents a course and professor relationship entity.
	/// </summary>
	public class CourseProfessor
	{
		/// <summary>
		///		Gets or sets the id. 
		/// </summary>
		public int Id { get; set; }

		/// <summary>
		///		Gets or sets the course id. 
		/// </summary>
		public int CourseId { get; set; }

		/// <summary>
		///		Gets or sets the course. 
		/// </summary>
		public Course Course { get; set; }

		/// <summary>
		///		Gets or sets the professor id. 
		/// </summary>
		public int ProfessorId { get; set; }

		/// <summary>
		///		Gets or sets the professor. 
		/// </summary>
		public Professor Professor { get; set; }
	}
}
