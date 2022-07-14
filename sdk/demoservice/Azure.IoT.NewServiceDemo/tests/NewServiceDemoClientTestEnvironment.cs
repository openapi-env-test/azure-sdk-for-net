// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure.Core.TestFramework;

namespace Azure.IoT.NewServiceDemo.Tests
{
    public class NewServiceDemoClientTestEnvironment : TestEnvironment
    {
        public string Endpoint => GetRecordedVariable("NewServiceDemo_ENDPOINT");

        // Add other client paramters here as above.
    }
}
