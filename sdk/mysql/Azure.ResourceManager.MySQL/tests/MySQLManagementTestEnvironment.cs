// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Azure.Core.TestFramework;

namespace Azure.ResourceManager.MySQL.Tests
{
    public class MySQLManagementTestEnvironment : TestEnvironment
    {
        public MySQLManagementTestEnvironment() : base("mysqlmgmt")
        {
        }
    }
}