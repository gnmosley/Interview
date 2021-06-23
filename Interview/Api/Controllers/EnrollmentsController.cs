using Api.Models;
using Data.Providers;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Api.Controllers
{
	/// <summary>
	///		An API controller used to manage student enrollments. 
	/// </summary>
	public class EnrollmentsController
		: Controller
	{
		// TODO : Need to create an endpoint to allow a student to enroll in a course. 
		private readonly IEnrollmentProvider _enrollmentProvider;

		public EnrollmentsController(IEnrollmentProvider enrollmentProvider)
		{
			_enrollmentProvider = enrollmentProvider;
		}

	}
}
