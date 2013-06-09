namespace XboxApiWrapper
{
	public partial class XboxApi
	{
		/// <summary>
		/// Get the friends for an individual user.
		/// </summary>
		/// <param name="gamertag">Gamertag of the user to query.</param>
		/// <returns>String, of whichever format, for the user.</returns>
		public string GetFriends(string gamertag)
		{
			var methodPath = string.Format("friends/{0}", gamertag);
			return ApiRequest(methodPath);
		}
	}
}
