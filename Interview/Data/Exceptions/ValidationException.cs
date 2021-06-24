using System;
using System.Collections.Generic;

namespace Data.Exceptions
{
	/// <summary>
	///		Represents a validation exception.
	/// </summary>
	public class ValidationException
		: Exception
	{
		/// <summary>
		///		Gets the collection of errors.
		/// </summary>
		public Dictionary<string, string> Errors { get; }

		/// <summary>
		///		Represents a <see cref="ValidationException"/>. 
		/// </summary>
		public ValidationException(Dictionary<string, string> errors)
		{
			Errors = errors;
		}
	}
}
