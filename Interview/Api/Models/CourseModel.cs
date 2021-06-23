using System.Collections.Generic;
using Data.Common;
using Newtonsoft.Json;

namespace Api.Models
{
	/// <summary>
	///		Represents a course model.
	/// </summary>
	public class CourseModel
		: IName
	{
		/// <summary>
		///		Gets or sets the course id. 
		/// </summary>
		[JsonProperty("id")]
		public int Id { get; set; }

		/// <summary>
		///		Gets or sets the course name. 
		/// </summary>
		[JsonProperty("name")]
		public string Name { get; set; }

		/// <summary>
		///		Gets or sets the list of professors that instruct this course. 
		/// </summary>
		[JsonProperty("professors")]
		public IEnumerable<ProfessorModel> Professors { get; set; }
	}
}
