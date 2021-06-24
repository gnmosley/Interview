using Data.Entities;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Data.Validation
{
	public class EnrollmentCountRule
		: IValidationRule<Enrollment>
	{
		private readonly UniversityContext _context;

		/// <summary>
		///		Represents an enrollment count rule. 
		/// </summary>
		/// <param name="context"></param>
		public EnrollmentCountRule(UniversityContext context)
		{
			_context = context;
		}

		/// <summary>
		///		Determines if the target is valid based on this validation rule.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="target"> The object to be validated. </param>
		/// <param name="errors"> The key/value pair representing the collection of errors. </param>
		/// <returns> The value indicating whether the target object passed the validation rule. </returns>
		public void Enforce(Enrollment target, IDictionary<string, string> errors)
        {
			// Query: Checks for the Professors that match the target's ProfessorId
			//		&& Checks the course ids that the Professor teaches with the target's CoruseId
			// Gets that amount of results from the query
			var c = _context.Professors.Include(p => p.CourseProfessors).ThenInclude(p => p.Course);

			foreach (var p in c)
			{
				foreach (var item in p.CourseProfessors)
				{
                    Console.WriteLine(item.Course.Name);
				}
			}

			// If nothing returns from the query, then the professor does not teach the course
			//if (professorCheck == 0)
			//	// Adds the error to throw the exception if occurs
			//	errors?.Add("Enrollments", "Professor does not teach the course.");

			// Query to get the number of enrollments for a student based on the studentId provided from target
			var studentCount = _context.Enrollments.Where(a => a.StudentId == target.StudentId).Count();
			// Checks to see if number of enrollments is more than two (count = len(query) - 1)
			if (studentCount >= 2)
				errors?.Add("Enrollments", "A student can only enroll in a maximum of 2 courses.");
			return;
		}
	}

}
