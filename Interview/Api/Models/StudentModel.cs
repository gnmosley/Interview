using Data.Common;
using Newtonsoft.Json;

namespace Api.Models
{
	/// <summary>
	///		Represents a student model.
	/// </summary>
	public class StudentModel	
		: IName
	{
		/// <summary>
		///		Gets or sets the student id. 
		/// </summary>
		[JsonProperty("id")]
		public int Id { get; set; }

		/// <summary>
		///		Gets or sets the student name. 
		/// </summary>
		[JsonProperty("name")]
		public string Name { get; set; }
	}
}
