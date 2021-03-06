﻿//--------------------------------------------------------------------------------- 
// <copyright file="DocumentCollectionSpec.cs" company="Microsoft">
// Microsoft (R) Azure DocumentDB SDK 
// Software Development Kit 
//  
// Copyright (c) Microsoft Corporation. All rights reserved.   
// 
// THIS CODE AND INFORMATION ARE PROVIDED "AS IS" WITHOUT WARRANTY OF ANY KIND,  
// EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE IMPLIED WARRANTIES  
// OF MERCHANTABILITY AND/OR FITNESS FOR A PARTICULAR PURPOSE.  
// </copyright>
//--------------------------------------------------------------------------------- 

namespace DocumentDB.Samples.Sharding
{
    using System;
    using System.Collections.Generic;
    using Microsoft.Azure.Documents;

    /// <summary>
    /// The specification/template for creating a new DocumentCollection.
    /// </summary>
    public class DocumentCollectionSpec
    {
        /// <summary>
        /// Gets or sets the IndexingPolicy to use.
        /// </summary>
        public IndexingPolicy IndexingPolicy { get; set; }

        /// <summary>
        /// Gets or sets the OfferType to use, e.g., S1, S2, S3.
        /// </summary>
        public string OfferType { get; set; }

        /// <summary>
        /// Gets or sets the stored procedures to register.
        /// </summary>
        public IList<StoredProcedure> StoredProcedures { get; set; }

        /// <summary>
        /// Gets or sets the triggers to register.
        /// </summary>
        public IList<Trigger> Triggers { get; set; }

        /// <summary>
        /// Gets or sets the UDFs to register.
        /// </summary>
        public IList<UserDefinedFunction> UserDefinedFunctions { get; set; }
    }
}
