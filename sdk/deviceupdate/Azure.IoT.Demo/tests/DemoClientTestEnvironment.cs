// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure.Core.TestFramework;

namespace Azure.IoT.Demo.Tests
{
    public class DemoClientTestEnvironment : TestEnvironment
    {
        public string Endpoint => GetRecordedVariable("Demo_ENDPOINT");

        // Add other client paramters here as above.
    }
}
