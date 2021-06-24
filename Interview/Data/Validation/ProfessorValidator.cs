using Data.Entities;
using Microsoft.EntityFrameworkCore.Internal;
using System.Collections.Generic;

namespace Data.Validation
{
	/// <summary>
	///		Represents a validator for professor objects. 
	/// </summary>
	public class ProfessorValidator
		: IValidator<Professor>
	{
		private readonly IEnumerable<IValidationRule<Professor>> _professorValidationRules;

		/// <summary>
		///		Creates a new instance of a <see cref="ProfessorValidator"/>. 
		/// </summary>
		/// <param name="professorValidationRules"> The collection of professor validation rules. </param>
		public ProfessorValidator(IEnumerable<IValidationRule<Professor>> professorValidationRules)
		{
			_professorValidationRules = professorValidationRules;
		}

		/// <summary>
		///		Determines if the target object is valid. 
		/// </summary>
		/// <param name="target"> The object to be validated. </param>
		/// <param name="errors"> The key/value pairs indicating the collection of errors. </param>
		/// <returns> The value indicating whether the object is valid. </returns>
		public bool IsValid(Professor target, out Dictionary<string, string> errors)
		{
			errors = new Dictionary<string, string>();
			foreach (var rule in _professorValidationRules)
				rule.Enforce(target, errors);
			return !errors.Any(); 
		}
	}
}
