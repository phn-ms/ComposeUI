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

namespace MorganStanley.ComposeUI.Messaging.Client.Abstractions;

/// <summary>
/// Creates instances of <see cref="IConnection"/>
/// </summary>
public interface IConnectionFactory
{
    /// <summary>
    /// Creates a new <see cref="IConnection"/> instance.
    /// </summary>
    /// <returns></returns>
    public IConnection CreateConnection();
}