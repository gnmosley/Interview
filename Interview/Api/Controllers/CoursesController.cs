using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Models;
using Data.Providers;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
	/// <summary>
	///		An Api controller responsible for managing courses.
	/// </summary>
	public class CoursesController
		: Controller
	{
		private readonly ICourseProvider _courseProvider;

		/// <summary>
		///		Creates a new instance of a <see cref="CoursesController"/>. 
		/// </summary>
		/// <param name="courseProvider"> Provider for course information. </param>
		public CoursesController(ICourseProvider courseProvider)
		{
			_courseProvider = courseProvider;
		}

		/// <summary>
		///		Gets a list of all courses.
		/// </summary>
		[HttpGet]
		[Route("api/courses")]
		public IEnumerable<CourseModel> Get()
		{
			var result = new List<CourseModel>();
			var courses = _courseProvider.GetAll();
			foreach (var course in courses)
			{
				var courseModel = new CourseModel
				{
					Id = course.Id, 
					Name = course.Name
				};

				var professors = new List<ProfessorModel>();
				courseModel.Professors = professors;
				professors.AddRange(course.CourseProfessors.Select(c => new ProfessorModel { Id = c.ProfessorId, Name =  c.Professor?.Name } ));
				result.Add(courseModel);
			}
			return result;
		}
	}
}
