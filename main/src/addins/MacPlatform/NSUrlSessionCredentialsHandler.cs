//
// NSUrlSessionCredentialsHandler.cs
//
// Author:
//       Matt Ward <matt.ward@microsoft.com>
//
// Copyright (c) 2018 Microsoft
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Foundation;
using MacPlatform;
using MonoDevelop.Core.Web;

namespace MonoDevelop.MacIntegration
{
	class NSUrlSessionCredentialsHandler : NSUrlSessionHandler, IHttpCredentialsHandler
	{
		public NSUrlSessionCredentialsHandler (NSUrlSessionConfiguration configuration)
			: base (configuration)
		{
		}

		/// <summary>
		/// Not supported.
		/// </summary>
		public bool UseDefaultCredentials { get; set; }

		/// <summary>
		/// Not all WWW-Authenticate basic auth responses are handled by the NSUrlSessionHandler, such as those
		/// from VSTS NuGet package sources, so an Authorization header is added to the request and re-sent
		/// if basic auth credentials can be found.
		/// </summary>
		protected override async Task<HttpResponseMessage> SendAsync (HttpRequestMessage request, CancellationToken cancellationToken)
		{
			bool retry = false;
			while (true) {
				var response = await base.SendAsync (request, cancellationToken).ConfigureAwait (false);

				if (retry || response.StatusCode != HttpStatusCode.Unauthorized)
					return response;

				if (!BasicAuthenticationHandler.Authenticate (request, response, Credentials))
					return response;

				retry = true;
			}
		}
	}
}
