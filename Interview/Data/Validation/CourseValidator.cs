using Data.Entities;
using Microsoft.EntityFrameworkCore.Internal;
using System.Collections.Generic;

namespace Data.Validation
{
	/// <summary>
	///		Represents a validator for course objects. 
	/// </summary>
	public class CourseValidator
		: IValidator<Course>
	{
		private readonly IEnumerable<IValidationRule<Course>> _courseValidationRules;

		/// <summary>
		///		Creates a new instance of a <see cref="CourseValidator"/>. 
		/// </summary>
		/// <param name="courseValidationRules"> The collection of course validation rules. </param>
		public CourseValidator(IEnumerable<IValidationRule<Course>> courseValidationRules)
		{
			_courseValidationRules = courseValidationRules;
		}

		/// <summary>
		///		Determines if the target object is valid. 
		/// </summary>
		/// <param name="target"> The object to be validated. </param>
		/// <param name="errors"> The key/value pairs indicating the collection of errors. </param>
		/// <returns> The value indicating whether the object is valid. </returns>
		public bool IsValid(Course target, out Dictionary<string, string> errors)
		{
			errors = new Dictionary<string, string>();
			foreach (var rule in _courseValidationRules)
				rule.Enforce(target, errors);
			return !errors.Any(); 
		}
	}
}
