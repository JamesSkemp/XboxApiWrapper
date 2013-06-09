namespace XboxApiWrapper
{
	public partial class XboxApi
	{
		/// <summary>
		/// Get games for an individual user.
		/// </summary>
		/// <param name="gamertag">Gamertag of the user to query.</param>
		/// <returns>String, of whichever format, for the user.</returns>
		public string GetGames(string gamertag)
		{
			var methodPath = string.Format("games/{0}", gamertag);
			return ApiRequest(methodPath);
		}
	}
}
