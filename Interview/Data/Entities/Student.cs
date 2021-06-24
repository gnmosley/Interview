using System.Collections.Generic;

namespace Data.Entities
{
	/// <summary>
	///		Represents a student. 
	/// </summary>
	public class Student
	{
		/// <summary>
		///		Gets or sets the student id. 
		/// </summary>
		public int Id { get; set; }

		/// <summary>
		///		Gets or sets the student name.
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		///		Gets or sets the collection of the student's enrollments. 
		/// </summary>
		public virtual ICollection<Enrollment> Enrollments { get; set; }
	}
}
