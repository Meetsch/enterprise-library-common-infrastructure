// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

using System;
using System.Reflection;

[assembly: CLSCompliant(true)]
#if !TRIMBLE
[assembly: AssemblyProduct("Microsoft Enterprise Library")]
[assembly: AssemblyCompany("Microsoft Corporation")]

#if DEBUG
[assembly: AssemblyConfiguration("Debug")]
#else
[assembly: AssemblyConfiguration("Release")]
#endif
[assembly: AssemblyCopyright("")]
#endif
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]