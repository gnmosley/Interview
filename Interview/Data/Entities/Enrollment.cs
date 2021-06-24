using Data.Common;

namespace Data.Entities
{
	/// <summary>
	///		Represents an enrollment. 
	/// </summary>
	public class Enrollment
	{
		/// <summary>
		///		Gets or sets the unique enrollment id. 
		/// </summary>
		public int Id { get; set; }

		/// <summary>
		///		Gets or sets the student id. 
		/// </summary>
		public int StudentId { get; set; }

		/// <summary>
		///		Gets or sets the student. 
		/// </summary>
		public Student Student { get; set; }

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
