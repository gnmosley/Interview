﻿using Data.Entities;
using System;
using Microsoft.EntityFrameworkCore.Internal;
using System.Collections.Generic;

namespace Data.Validation
{
	/// <summary>
	///		Represents an enrollment validator. 
	/// </summary>
	public class EnrollmentValidator
		: IValidator<Enrollment>
	{
		private readonly IEnumerable<IValidationRule<Enrollment>> _rules;

		/// <summary>
		///		Creates a new instance of a <see cref="EnrollmentValidator"/>.
		/// </summary>
		public EnrollmentValidator(IEnumerable<IValidationRule<Enrollment>> rules)
		{
			_rules = rules;
		}

		/// <summary>
		///		Determines if the target object is valid. 
		/// </summary>
		/// <param name="target"> The object to be validated. </param>
		/// <param name="errors"> The key/value pairs indicating the collection of errors. </param>
		/// <returns> The value indicating whether the object is valid. </returns>
		public bool IsValid(Enrollment target, out Dictionary<string, string> errors)
		{
			errors = new Dictionary<string, string>();
			foreach (var rule in _rules)
				rule.Enforce(target, errors);
			return !errors.Any();
		}
	}
}
