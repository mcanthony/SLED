/*
 * Copyright (C) Sony Computer Entertainment America LLC. 
 * All Rights Reserved. 
 */

using System.Reflection;
using System.Runtime.InteropServices;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("Sled.Net.Tcp")]
[assembly: AssemblyDescription("SLED - Script Language Editor & Debugger")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("Sony Computer Entertainment America LLC")]
[assembly: AssemblyProduct("SLED")]
[assembly: AssemblyCopyright("Copyright © 2015")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

// Setting ComVisible to false makes the types in this assembly not visible 
// to COM components.  If you need to access a type in this assembly from 
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("7cdb0b45-9c29-4412-8bcd-1413b058611c")]

// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version 
//      Build Number
//      Revision
//
// You can specify all the values or you can default the Revision and Build Numbers 
// by using the '*' as shown below:
[assembly: AssemblyVersion("5.1.2.0")]
[assembly: AssemblyFileVersion("5.1.2.0")]

// Mark assembly as an ATF Plugin
[assembly: Sce.Atf.AtfPlugin]
// Mark assembly as a SLED Network Plugin
[assembly: Sce.Sled.Shared.Plugin.SledNetworkPlugin]
