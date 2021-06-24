using Data.Entities;
using Microsoft.EntityFrameworkCore.Internal;
using System.Collections.Generic;

namespace Data.Validation
{
	/// <summary>
	///		Represents a validator for student objects. 
	/// </summary>
	public class StudentValidator
		: IValidator<Student>
	{
		private readonly IEnumerable<IValidationRule<Student>> _studentValidationRules;

		/// <summary>
		///		Creates a new instance of a <see cref="StudentValidator"/>. 
		/// </summary>
		/// <param name="studentValidationRules"> The collection of student validation rules. </param>
		public StudentValidator(IEnumerable<IValidationRule<Student>> studentValidationRules)
		{
			_studentValidationRules = studentValidationRules;
		}

		/// <summary>
		///		Determines if the target object is valid. 
		/// </summary>
		/// <param name="target"> The object to be validated. </param>
		/// <param name="errors"> The key/value pairs indicating the collection of errors. </param>
		/// <returns> The value indicating whether the object is valid. </returns>
		public bool IsValid(Student target, out Dictionary<string, string> errors)
		{
			errors = new Dictionary<string, string>();
			foreach (var rule in _studentValidationRules)
				rule.Enforce(target, errors);
			return !errors.Any(); 
		}
	}
}
