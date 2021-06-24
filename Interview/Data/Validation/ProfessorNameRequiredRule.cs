using Data.Common;
using System.Collections.Generic;
using Data.Entities;

namespace Data.Validation
{
	/// <summary>
	///		Represents a name required rule. 
	/// </summary>
	public class ProfessorNameRequiredRule
		: IValidationRule<IName>, IValidationRule<Professor>
	{
		/// <summary>
		///		Determines if the target is valid based on this validation rule.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="target"> The object to be validated. </param>
		/// <param name="errors"> The key/value pair representing the collection of errors. </param>
		public void Enforce(IName target, IDictionary<string, string> errors)
		{
			if (!string.IsNullOrWhiteSpace(target.Name))
				return;
			errors?.Add("Name", "A value for name is required.");
		}

		/// <summary>
		///		Determines if the target is valid based on this validation rule.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="target"> The object to be validated. </param>
		/// <param name="errors"> The key/value pair representing the collection of errors. </param>
		/// <returns> The value indicating whether the target object passed the validation rule. </returns>
		public void Enforce(Professor target, IDictionary<string, string> errors)
		{
			Enforce((IName)target, errors);
		}
	}
}
