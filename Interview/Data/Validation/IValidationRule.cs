using System.Collections.Generic;

namespace Data.Validation
{
	/// <summary>
	///		Represents a validation rule. 
	/// </summary>
	public interface IValidationRule<in T>
	{
		/// <summary>
		///		Determines if the target is valid based on this validation rule.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="target"> The object to be validated. </param>
		/// <param name="errors"> The key/value pair representing the collection of errors. </param>
		/// <returns> The value indicating whether the target object passed the validation rule. </returns>
		void Enforce(T target, IDictionary<string, string> errors); 
	}
}
