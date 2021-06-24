using System.Collections.Generic;
using Data.Entities;

namespace Data.Providers
{
	/// <summary>
	///		Represents a enrollment provider. 
	/// </summary>
	public interface IEnrollmentProvider
	{
		/// <summary>
		///		Creates a new course. 
		/// </summary>
		/// <param name="student"> The student to be enrolled. </param>
		/// <param name="course"> The course to enroll the student into. </param>
		/// <param name="professor"> The professor the instructs the course. </param>
		/// <returns> The created course. </returns>
		Enrollment Enroll(Student student, Course course, Professor professor);

	}
}
