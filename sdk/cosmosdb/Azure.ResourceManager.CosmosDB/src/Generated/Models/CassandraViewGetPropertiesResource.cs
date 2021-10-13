// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> The CassandraViewGetPropertiesResource. </summary>
    public partial class CassandraViewGetPropertiesResource : CassandraViewResource
    {
        /// <summary> Initializes a new instance of CassandraViewGetPropertiesResource. </summary>
        /// <param name="id"> Name of the Cosmos DB Cassandra view. </param>
        /// <param name="viewDefinition"> View Definition of the Cosmos DB Cassandra view. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> or <paramref name="viewDefinition"/> is null. </exception>
        public CassandraViewGetPropertiesResource(string id, string viewDefinition) : base(id, viewDefinition)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }
            if (viewDefinition == null)
            {
                throw new ArgumentNullException(nameof(viewDefinition));
            }
        }

        /// <summary> Initializes a new instance of CassandraViewGetPropertiesResource. </summary>
        /// <param name="id"> Name of the Cosmos DB Cassandra view. </param>
        /// <param name="viewDefinition"> View Definition of the Cosmos DB Cassandra view. </param>
        /// <param name="rid"> A system generated property. A unique identifier. </param>
        /// <param name="ts"> A system generated property that denotes the last updated timestamp of the resource. </param>
        /// <param name="etag"> A system generated property representing the resource etag required for optimistic concurrency control. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> or <paramref name="viewDefinition"/> is null. </exception>
        internal CassandraViewGetPropertiesResource(string id, string viewDefinition, string rid, float? ts, string etag) : base(id, viewDefinition)
        {
            if (id == null)
            {
                throw new ArgumentNullException(nameof(id));
            }
            if (viewDefinition == null)
            {
                throw new ArgumentNullException(nameof(viewDefinition));
            }

            Rid = rid;
            Ts = ts;
            Etag = etag;
        }

        /// <summary> A system generated property. A unique identifier. </summary>
        public string Rid { get; }
        /// <summary> A system generated property that denotes the last updated timestamp of the resource. </summary>
        public float? Ts { get; }
        /// <summary> A system generated property representing the resource etag required for optimistic concurrency control. </summary>
        public string Etag { get; }
    }
}
