﻿using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;
using Program1;

class Solution
{
    public static void Main(string[] args)
    {
        while (!CommandHandler.Quit)
        {
            CommandHandler.Run();
        }
        
    }
}
