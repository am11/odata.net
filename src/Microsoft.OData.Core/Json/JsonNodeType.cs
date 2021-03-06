﻿//---------------------------------------------------------------------
// <copyright file="JsonNodeType.cs" company="Microsoft">
//      Copyright (C) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.
// </copyright>
//---------------------------------------------------------------------

#if SPATIAL
namespace Microsoft.Data.Spatial
#else
namespace Microsoft.OData.Core.Json
#endif
{
    #region Namespaces
    #endregion Namespaces

    /// <summary>
    /// Enumeration of all JSON node type.
    /// </summary>
#if ODATALIB_PUBLICJSONREADER
    public
#else
    internal
#endif
    enum JsonNodeType
    {
        /// <summary>
        /// No node - invalid value.
        /// </summary>
        None,

        /// <summary>
        /// Start of JSON object record, the { character.
        /// </summary>
        StartObject,

        /// <summary>
        /// End of JSON object record, the } character.
        /// </summary>
        EndObject,

        /// <summary>
        /// Start of JSON array, the [ character.
        /// </summary>
        StartArray,

        /// <summary>
        /// End of JSON array, the ] character.
        /// </summary>
        EndArray,

        /// <summary>
        /// Property, the name of the property (the value will be reported as a separate node or nodes)
        /// </summary>
        Property,

        /// <summary>
        /// Primitive value, that is either null, true, false, number or string.
        /// </summary>
        PrimitiveValue,

        /// <summary>
        /// End of input reached.
        /// </summary>
        EndOfInput
    }
}
