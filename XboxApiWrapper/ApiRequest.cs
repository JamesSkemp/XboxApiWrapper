using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace XboxApiWrapper
{
	public partial class XboxApi
	{
		/// <summary>
		/// Helper to make a request to the API.
		/// </summary>
		/// <param name="methodPath">Path to the method to call.</param>
		/// <returns>API response.</returns>
		private string ApiRequest(string methodPath)
		{
			var requestUrl = string.Format(XboxApi.apiUrl, this.Format.ToString().ToLower(), methodPath);

			var request = WebRequest.CreateHttp(requestUrl);
			request.Headers.Add(XboxApi.authorizationHeader, this.ApiKey);
			request.Timeout = this.Timeout;

			using (var response = request.GetResponse())
			{
				StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.UTF8);
				return reader.ReadToEnd();
			}
		}
	}
}
