﻿/*
 * Morgan Stanley makes this available to you under the Apache License,
 * Version 2.0 (the "License"). You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0.
 *
 * See the NOTICE file distributed with this work for additional information
 * regarding copyright ownership. Unless required by applicable law or agreed
 * to in writing, software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express
 * or implied. See the License for the specific language governing permissions
 * and limitations under the License.
 */

using MorganStanley.ComposeUI.Fdc3.DesktopAgent.Channels;
using MorganStanley.ComposeUI.MessagingAdapter.Abstractions;

namespace MorganStanley.ComposeUI.Fdc3.DesktopAgent.Tests.Channels;

public class AppChannelTests : ChannelTestBase
{
    private const string TestChannel = "testChannel";

    public AppChannelTests()
    {
        Channel = new AppChannel(TestChannel, new Mock<IMessaging>().Object, null);
        Topics = Fdc3Topic.AppChannel(TestChannel);
    }
}
