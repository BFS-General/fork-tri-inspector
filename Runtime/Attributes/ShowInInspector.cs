﻿using System;
using System.Diagnostics;
namespace TriInspector
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
    [Conditional("UNITY_EDITOR")]
    [JetBrains.Annotations.MeansImplicitUse]
    public class ShowInInspectorAttribute : Attribute
    {
    }
}