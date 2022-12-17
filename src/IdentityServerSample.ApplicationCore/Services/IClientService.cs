﻿// Copyright (c) Dennis Shevtsov. All rights reserved.
// Licensed under the MIT License.
// See LICENSE in the project root for license information.

namespace IdentityServerSample.ApplicationCore.Services
{
  using IdentityServerSample.ApplicationCore.Dtos;
  using IdentityServerSample.ApplicationCore.Entities;

  /// <summary>Provides a simple API to execute queries and commands with clients.</summary>
  public interface IClientService
  {
    /// <summary>Gets a client that satisfies defined conditions.</summary>
    /// <param name="query">An object that represents conditions to query a client.</param>
    /// <param name="cancellationToken">An object that propagates notification that operations should be canceled.</param>
    /// <returns>An object that tepresents an asynchronous operation that produces a result at some time in the future.</returns>
    public Task<ClientEntity?> GetClientAsync(GetClientRequestDto query, CancellationToken cancellationToken);

    /// <summary>Gets clients that satisfied defined conditions.</summary>
    /// <param name="query">An object that represents conditions to query clients.</param>
    /// <param name="cancellationToken">An object that propagates notification that operations should be canceled.</param>
    /// <returns>An object that tepresents an asynchronous operation that produces a result at some time in the future.</returns>
    public Task<GetClientsResponseDto> GetClientsAsync(GetClientsRequestDto query, CancellationToken cancellationToken);
  }
}