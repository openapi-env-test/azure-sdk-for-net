// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure.Core.TestFramework;

namespace Azure.IoT.NewServicesDemo.Tests
{
    public class NewServicesDemoClientTestEnvironment : TestEnvironment
    {
        public string Endpoint => GetRecordedVariable("NewServicesDemo_ENDPOINT");

        // Add other client paramters here as above.
    }
}
