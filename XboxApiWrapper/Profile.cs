namespace XboxApiWrapper
{
	public partial class XboxApi
	{
		/// <summary>
		/// Get the profile for an individual user.
		/// </summary>
		/// <param name="gamertag">Gamertag of the user to query.</param>
		/// <returns>String, of whichever format, for the user.</returns>
		public string GetProfile(string gamertag)
		{
			var methodPath = string.Format("profile/{0}", gamertag);
			return ApiRequest(methodPath);
		}
	}
}
