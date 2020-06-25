---
id: system-requirements
url: classification/net/system-requirements
title: System requirements
weight: 4
description: ""
keywords: 
productName: GroupDocs.Classification for .NET
hideChildren: False
---
## Overview

To produce and manipulate the documents, the machine that GroupDocs.Classification for .NET runs on doesn't need to have Adobe Acrobat, Microsoft Office or OpenOffice installed: GroupDocs.Classification for .NET has their own document processing engine.  
The machine that GroupDocs.Classification for .NET runs on doesn't need to have Adobe Acrobat, Microsoft Office or OpenOffice installed: GroupDocs.Classification for .NET has their own document processing engine.

## Supported Operating System

### Windows

*   Microsoft Windows 2000 Professional (x64)
*   Microsoft Windows 2000 Server (x64)
*   Microsoft Windows 2003 Server (x64)
*   Microsoft Windows 2008 Server (x64)
*   Microsoft Windows 2012 Server (x64)
*   Microsoft Windows 2012 R2 Server (x64)
*   Microsoft Windows 2016 Server (x64)
*   Microsoft Windows 2019 Server (x64)
*   Microsoft Windows Vista (x64)
*   Microsoft Windows XP (x64)
*   Microsoft Windows 7 (x64)
*   Microsoft Windows 8, 8.1 (x64)
*   Microsoft Windows 10 (x64)
*   Microsoft Azure

### macOS

*   Mac OS X x64 (10.12+) 

### Linux

*   Linux x64 ( 6, 7 ,27, 9, 8.7+, 18.04, 16.04, 14.04, 18, 17, 42.3+, 12 SP2+)

## Memory Requirements

3GB RAM

## Development Environments

You can use GroupDocs.Classification for .NET to develop applications in any development environment that targets the .NET platform, but the following environments are explicitly supported:

*   Microsoft Visual Studio 2013
*   Microsoft Visual Studio 2015
*   Microsoft Visual Studio 2017
*   Microsoft Visual Studio 2019

## Supported Frameworks

GroupDocs.Classification is a Netstandard2 library, so each framework that supports Netstandard could also uses the library:

*   .NET Framework 4.7 or later
*   .NET Core 2.0 or later

GroupDocs.Classification for .NET uses System.Numerics.Vectors library for the fast calculations.  
Please use bindings redirect for proper work with old-style projects. Include the following XML code in your app configuration file (inside assemblyBinding element in app.config). 

```csharp
<dependentAssembly>
	<assemblyIdentity name="System.Numerics.Vectors" publicKeyToken="b03f5f7f11d50a3a" culture="neutral" />
	<bindingRedirect oldVersion="0.0.0.0-4.1.4.0" newVersion="4.1.4.0" />
</dependentAssembly>
```
