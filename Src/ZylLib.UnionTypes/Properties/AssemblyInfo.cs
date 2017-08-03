using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
#if (NETSTANDARD1_0)
[assembly: AssemblyTitle("ZylLib.UnionTypes for .NET Standard 1.0")]
#elif (NET40)
[assembly: AssemblyTitle("ZylLib.UnionTypes for .NET 4.0")]
#elif (NET40 && PORTABLE)
[assembly: AssemblyTitle("ZylLib.UnionTypes for Portable .NET 4.0")]
#elif (NET20)
[assembly: AssemblyTitle("ZylLib.UnionTypes for .NET 2.0")]
#elif (NETSTANDARD)
[assembly: AssemblyTitle("ZylLib.UnionTypes for .NET Standard")]
#elif (PORTABLE)
[assembly: AssemblyTitle("ZylLib.UnionTypes for Portable")]
#else
[assembly: AssemblyTitle("ZylLib.UnionTypes")]
#endif
[assembly: AssemblyDescription("Union types in C# (C#的联合体类型)")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("zyl910")]
[assembly: AssemblyProduct("ZylLib.UnionTypes")]
[assembly: AssemblyCopyright("Copyright (C) zyl910 2017")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]


// Setting ComVisible to false makes the types in this assembly not visible 
// to COM componenets.  If you need to access a type in this assembly from 
// COM, set the ComVisible attribute to true on that type.
#if (PORTABLE)
#else
[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("05e81ce3-6739-4d9d-bd40-50d26c634bcc")]
#endif

// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version 
//      Build Number
//      Revision
//
// You can specify all the values or you can default the Revision and Build Numbers 
// by using the '*' as shown below:
//[assembly: AssemblyVersion("1.0.0.0")]
//[assembly: AssemblyFileVersion("1.0.0.0")]
// See AssemblyVer.cs

[assembly: CLSCompliant(true)]

[assembly: AllowPartiallyTrustedCallers]
