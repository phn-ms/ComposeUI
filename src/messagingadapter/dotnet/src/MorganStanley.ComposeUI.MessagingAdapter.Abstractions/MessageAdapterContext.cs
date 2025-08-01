﻿// Morgan Stanley makes this available to you under the Apache License,
// Version 2.0 (the "License"). You may obtain a copy of the License at
//
//      http://www.apache.org/licenses/LICENSE-2.0.
//
// See the NOTICE file distributed with this work for additional information
// regarding copyright ownership. Unless required by applicable law or agreed
// to in writing, software distributed under the License is distributed on an
// "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express
// or implied. See the License for the specific language governing permissions
// and limitations under the License.

namespace MorganStanley.ComposeUI.MessagingAdapter.Abstractions;

/// <summary>
/// Provides contextual information for a message received from the Message Router.
/// </summary>
public sealed class MessageAdapterContext
{
    /// <summary>
    /// Gets the client ID of the sender.
    /// </summary>
    public string SourceId { get; init; } = "";

    /// <summary>
    /// Gets the correlation ID of the message, if there's one.
    /// </summary>
    public string? CorrelationId { get; init; }
}