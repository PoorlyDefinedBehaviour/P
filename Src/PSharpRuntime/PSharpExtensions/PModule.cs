﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.PSharp;

namespace PSharpExtensions
{

    public class PModule
    {
        public static Dictionary<string, string> interfaceDefinitionMap = new Dictionary<string, string>();
        public static Dictionary<string, IEnumerable<string>> monitorMap = new Dictionary<string, IEnumerable<string>>();
        public static IDictionary<string, IDictionary<string, string>> linkMap = new Dictionary<string, IDictionary<string, string>>();
    }
}
