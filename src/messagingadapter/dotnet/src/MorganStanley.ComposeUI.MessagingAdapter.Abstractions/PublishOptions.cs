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
/// Represents options for publishing a message, such as correlation identifiers for tracking.
/// </summary>
public readonly record struct PublishOptions
{
    /// <summary>
    /// Gets or sets the correlation identifier used to track the published message.
    /// </summary>
    public string? CorrelationId { get; init; }
}