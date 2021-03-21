﻿using System;
using System.Collections.Generic;
using System.Text;

namespace NugetHelper
{
    public class NugetDependency
    { 
        public NugetDependency(NuGet.Packaging.Core.PackageDependency d, bool forceMinVersion)
        {
            PackageDependency = d;
            ForceMinVersion = forceMinVersion;
        }

        public bool ForceMinVersion{ get; private set; }

        public NuGet.Packaging.Core.PackageDependency PackageDependency { get; private set; }

        public override string ToString()
        {
            return PackageDependency.ToString();
        }
    }
}
