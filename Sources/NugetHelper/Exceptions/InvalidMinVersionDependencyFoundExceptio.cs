﻿using System;
using System.Collections.Generic;
using System.Text;

namespace NugetHelper.Exceptions
{
    public class InvalidMinVersionDependencyFoundExceptio : Exception
    {
        public InvalidMinVersionDependencyFoundExceptio(string msg) : base(msg) { }
    }
}