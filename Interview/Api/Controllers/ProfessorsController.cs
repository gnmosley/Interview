using Api.Models;
using Data.Providers;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Api.Controllers
{
	/// <summary>
	///		An Api controller responsible for managing professors.
	/// </summary>
	public class ProfessorsController
		: Controller
	{
		private readonly IProfessorProvider _professorProvider;

		/// <summary>
		///		Creates a new instance of a <see cref="Api.Controllers.ProfessorsController"/>. 
		/// </summary>
		/// <param name="professorProvider"> Provider for professor information. </param>
		public ProfessorsController(IProfessorProvider professorProvider)
		{
			_professorProvider = professorProvider;
		}

		/// <summary>
		///		Gets a list of all professors.
		/// </summary>
		[HttpGet]
		[Route("api/professors")]
		public IEnumerable<ProfessorModel> Get()
		{
			var professors = _professorProvider.GetAll()
				.Select(professor =>
					new ProfessorModel
					{
						Id = professor.Id,
						Name = professor.Name
					});
			return professors;
		}
	}
}
