using Data.Common;
using Newtonsoft.Json;

namespace Api.Models
{
	/// <summary>
	///		Represents a professor model.
	/// </summary>
	public class ProfessorModel
		: IName
	{
		/// <summary>
		///		Gets or sets the professor id. 
		/// </summary>
		[JsonProperty("id")]
		public int Id { get; set; }

		/// <summary>
		///		Gets or sets the professor name. 
		/// </summary>
		[JsonProperty("name")]
		public string Name { get; set; }
	}
}
