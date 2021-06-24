using System.Collections.Generic;

namespace Data.Validation
{
	/// <summary>
	///		Represents a rule validator.
	/// </summary>
	public interface IValidator<in T>
	{
		/// <summary>
		///		Determines if the target object is valid. 
		/// </summary>
		/// <param name="target"> The object to be validated. </param>
		/// <param name="errors"> The key/value pairs indicating the collection of errors. </param>
		/// <returns> The value indicating whether the object is valid. </returns>
		bool IsValid(T target, out Dictionary<string, string> errors); 
	}
}
