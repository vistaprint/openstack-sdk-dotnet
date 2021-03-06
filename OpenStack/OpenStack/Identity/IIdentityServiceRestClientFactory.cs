﻿// /* ============================================================================
// Copyright 2014 Hewlett Packard
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ============================================================================ */

using System.Threading;
using OpenStack.Common.ServiceLocation;

namespace OpenStack.Identity
{
    /// <summary>
    /// Constructs clients that can be used to interact with REST interfaces related to the OpenStack identity service.
    /// </summary>
    public interface IIdentityServiceRestClientFactory
    {
        /// <summary>
        /// Creates a client that can be used to interact with the remote OpenStack service.
        /// </summary>
        /// <param name="credential">The credential to be used when interacting with OpenStack.</param>
        /// <param name="cancellationToken">The cancellation token to be used when interacting with OpenStack.</param>
        /// <param name="serviceLocator">A service locator to be used to locate/inject dependent services.</param>
        /// <returns>An instance of the client.</returns>
        IIdentityServiceRestClient Create(IOpenStackCredential credential, CancellationToken cancellationToken, IServiceLocator serviceLocator);
    }
}
