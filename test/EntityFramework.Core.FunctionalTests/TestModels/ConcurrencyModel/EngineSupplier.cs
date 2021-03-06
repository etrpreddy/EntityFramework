// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Collections.Generic;

namespace Microsoft.Data.Entity.FunctionalTests.TestModels.ConcurrencyModel
{
    public class EngineSupplier
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public virtual ICollection<Engine> Engines { get; set; }
    }
}
