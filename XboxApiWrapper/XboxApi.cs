﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace XboxApiWrapper
{
	/// <summary>
	/// Functionality to connect to the Xbox Leaders API on Mashape.
	/// </summary>
	public partial class XboxApi
	{
		#region Private data.
		/// <summary>
		/// Header to use when passing the authorization/API key.
		/// </summary>
		private const string authorizationHeader = "X-Mashape-Authorization";
		/// <summary>
		/// Base URL of the API, reading for String.Format (passing format then method path).
		/// </summary>
		private const string apiUrl = "https://xboxapi.p.mashape.com/{0}/{1}";
		#endregion

		/// <summary>
		/// Key for use with Mashape.
		/// </summary>
		public string ApiKey { get; set; }
		/// <summary>
		/// Format of the data to return.
		/// </summary>
		public ResultFormat Format { get; set; }
		/// <summary>
		/// Timeout (in milliseconds) to use when making a request.
		/// </summary>
		public int Timeout { get; set; }
		/// <summary>
		/// Region of the user.
		/// </summary>
		public string Region { get; set; }

		/// <summary>
		/// Initialize a new instances of the API. Defaults to JSON results and en-us region.
		/// </summary>
		public XboxApi()
		{
			this.Format = ResultFormat.Json;
			this.Timeout = 15000;
			this.Region = "en-us";
		}

		/// <summary>
		/// Initialize a new instance of the API with a particular key, and the base defaults.
		/// </summary>
		/// <param name="apiKey">API key to use when querying Mashape.</param>
		public XboxApi(string apiKey)
			: this()
		{
			this.ApiKey = apiKey;
		}

		/// <summary>
		/// Validate a gamertag according to the rules that it must be 15 alpha-numeric characters and spaces.
		/// </summary>
		/// <param name="gamertag">Gamertag to test.</param>
		/// <returns>True if the gamertag is valid.</returns>
		public bool ValidateGamertag(string gamertag)
		{
			return Regex.Match(gamertag, "^[a-zA-z0-9 ]{1,15}$").Success;
		}
	}
}