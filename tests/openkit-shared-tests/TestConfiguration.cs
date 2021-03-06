﻿//
// Copyright 2018 Dynatrace LLC
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
//

using Dynatrace.OpenKit.Core.Configuration;
using Dynatrace.OpenKit.Protocol.SSL;

namespace Dynatrace.OpenKit
{
    public class TestConfiguration : OpenKitConfiguration
    {
        public TestConfiguration()
            : base(OpenKitType.DYNATRACE, "", "", 0, "", new Providers.TestSessionIDProvider(), 
                  new SSLStrictTrustManager(), new Core.Device("", "", ""), "", 
                  new BeaconCacheConfiguration(
                    BeaconCacheConfiguration.DEFAULT_MAX_RECORD_AGE_IN_MILLIS,
                    BeaconCacheConfiguration.DEFAULT_LOWER_MEMORY_BOUNDARY_IN_BYTES,
                    BeaconCacheConfiguration.DEFAULT_UPPER_MEMORY_BOUNDARY_IN_BYTES))
        {
            EnableCapture();
        }
    }
}
