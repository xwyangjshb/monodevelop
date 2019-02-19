//
// CredentialService.cs
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

using System;
using System.Net;
using System.Threading;
using System.Threading.Tasks;

namespace MonoDevelop.Core.Web
{
	/// <summary>
	/// Task based wrapper around the synchronous ICredentialProvider
	/// </summary>
	class CredentialService : ICredentialService
	{
		/// <summary>
		/// Provides credentials for http requests.
		/// </summary>
		/// <param name="uri">
		/// The URI of a web resource for which credentials are needed.
		/// </param>
		/// <param name="proxy">
		/// The currently configured proxy. It may be necessary for CredentialProviders
		/// to use this proxy in order to acquire credentials from their authentication source.
		/// </param>
		/// <param name="type">
		/// The type of credential request that is being made.
		/// </param>
		/// <param name="cancellationToken">A cancellation token.</param>
		/// <returns>A credential object, or null if no credentials could be acquired.</returns>
		public Task<ICredentials> GetCredentialsAsync (
			Uri uri,
			IWebProxy proxy,
			CredentialType type,
			bool isRetry,
			CancellationToken cancellationToken)
		{
			if (uri == null)
				throw new ArgumentNullException (nameof (uri));

			var cp = WebRequestHelper.CredentialProvider;
			if (cp == null)
				return null;

			return Task.Run (() => {
				return cp.GetCredentials (uri, proxy, type, isRetry);
			});
		}
	}
}
