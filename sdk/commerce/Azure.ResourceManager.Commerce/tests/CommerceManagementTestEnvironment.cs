// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure.Core.TestFramework;

namespace Azure.ResourceManager.Commerce.Tests
{
    public class CommerceManagementTestEnvironment : TestEnvironment
    {
        public CommerceManagementTestEnvironment() : base("commercemgmt")
        {
        }
    }
}