﻿// Copyright (c) .NET Foundation and contributors. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.DotNet.ProjectModel.Server.Models
{
    public class InitializeMessage
    {
        public int Version { get; set; }

        public string Configuration { get; set; }

        public string ProjectFolder { get; set; }
    }
}
