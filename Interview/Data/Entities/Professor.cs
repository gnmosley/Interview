using System.Collections.Generic;
using Data.Common;

namespace Data.Entities
{
	/// <summary>
	///		Represents a professor. 
	/// </summary>
	public class Professor
		: IName
	{

		/// <summary>
		///		Gets or sets the unique professor id. 
		/// </summary>
		public int Id { get; set; }

		/// <summary>
		///		Gets or sets the professor name.
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		///		Gets or sets the collection of course professors. 
		/// </summary>
		public virtual ICollection<CourseProfessor> CourseProfessors { get; set; } = new List<CourseProfessor>();

		/// <summary>
		///		Gets or sets the collection of the student's enrollments. 
		/// </summary>
		public virtual ICollection<Enrollment> Enrollments { get; set; }
	}
}
