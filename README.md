XboxApiWrapper
==============

.NET wrapper for using Mashape with the XboxApi.com API.

Video Games Spa example
===

The following is a C# example that will grab all information for a user for generating a Video Game Spa site.

	// See https://www.mashape.com/djekl/xboxapi-com
	var apiKey = "insert your api key here";
	// Ready the API.
	var api = new XboxApiWrapper.XboxApi(apiKey);
	api.Format = XboxApiWrapper.ResultFormat.Xml;
	// Create a request to get information for a particular user.
	var dataRequest = new XboxApiWrapper.XboxApi.DataRequest() {
		// Id of the user to pull information for.
		Gamertag = "strivinglife",
		// Where to output the XML returned by the API.
		OutputDirectory = @"C:\Users\James\Projects\GitHub\VideoGamesSpa\_output\{0}\xboxapi\",
		// Format of the actual file; adds .xml to the end.
		FileNameFormat = "{0}",
		// Backup existing files; adds '__' as a prefix and a dash and the current date/time as a prefix.
		BackupFiles = true,
		// Get the user's profile.
		GetProfile = true,
		// Get the user's friends.
		GetFriends = true,
		// Get the listing of all games played by the user.
		GetGames = true,
		// Get information about individual games.
		GetGameAchievementData = true,
		// Get only the last x games.
		GetLastGames = 1
	};
	// Pull the requested data.
	api.PullUserData(dataRequest);

Links
=======

Learn about the API: https://www.mashape.com/djekl/xboxapi-com

Learn about this unofficial Xbox API: https://xboxapi.com/

Learn about me: http://jamesrskemp.com/
