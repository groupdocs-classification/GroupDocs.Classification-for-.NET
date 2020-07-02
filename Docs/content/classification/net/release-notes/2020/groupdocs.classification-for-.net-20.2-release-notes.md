---
id: groupdocs-classification-for-net-20-2-release-notes
url: classification/net/groupdocs-classification-for-net-20-2-release-notes
title: GroupDocs.Classification for .NET 20.2 Release Notes
weight: 1
description: ""
keywords: 
productName: GroupDocs.Classification for .NET
hideChildren: False
---
## GroupDocs.Classification for .NET 20.2 Release Notes

### Major Features

Supported Metered Licenses.

### All Changes

| Key | Summary | Category |
| --- | --- | --- |
| GDCLASS-42 | Support Metered Licenses for GroupDocs.Classification   | Feature   |

## Public API and Backward Incompatible Changes

**Set Metered license**  
Alternatively to license from file, you may set Metered license

```csharp
string PublicKey = ""; // Your public license key
string PrivateKey = ""; // Your private license key
Metered metered = new Metered();
metered.SetMeteredKey(PublicKey, PrivateKey);
```
