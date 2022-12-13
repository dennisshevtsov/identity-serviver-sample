﻿// Copyright (c) Dennis Shevtsov. All rights reserved.
// Licensed under the MIT License.
// See LICENSE in the project root for license information.

namespace IdentityServerSample.ApplicationCore.Repositories
{
  using IdentityServerSample.ApplicationCore.Entities;

  /// <summary>Provides a simple API to query and save API resources.</summary>
  public interface IApiResourceRepository
  {
    /// <summary>Gets a collection of all API resources.</summary>
    /// <param name="cancellationToken">An object that propagates notification that operations should be canceled.</param>
    /// <returns>An object that tepresents an asynchronous operation that produces a result at some time in the future.</returns>
    public Task<ApiRecourceEntity[]> GetApiResourcesAsync(CancellationToken cancellationToken);
  }
}
