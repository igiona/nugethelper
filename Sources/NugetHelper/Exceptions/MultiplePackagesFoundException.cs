﻿using System;
using System.Collections.Generic;
using System.Text;

namespace NuGetClientHelper.Exceptions
{
    public class MultiplePackagesFoundException : Exception
    {
        public MultiplePackagesFoundException(string msg) : base(msg) { }
    }
}
