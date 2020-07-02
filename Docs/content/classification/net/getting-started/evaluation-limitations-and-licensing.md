---
id: evaluation-limitations-and-licensing
url: classification/net/evaluation-limitations-and-licensing
title: Evaluation Limitations and Licensing
weight: 6
description: ""
keywords: 
productName: GroupDocs.Classification for .NET
hideChildren: False
---
## Evaluation Limitations

You can easily download GroupDocs.Classification for evaluation. The evaluation download is the same as the purchased download. The evaluation version simply becomes licensed when you add a few lines of code to apply the license. You will face following limitations while using the API without the license:  

*   Texts with more than 200 characters are not supported.
*   Documents with more than 200 characters are not supported.
*   For the sentiment classification this limitations are 100 for English and 30 Chinese.

## Licensing

The license file contains details such as the product name, number of developers it is licensed to, subscription expiry date and so on. It contains the digital signature, so don't modify the file. Even inadvertent addition of an extra line break into the file will invalidate it. You need to set a license before utilizing GroupDocs.Classification API if you want to avoid its evaluation limitations.   
The license can be loaded from a file or stream object.

#### Setting License from File

The code below will explain how to set product license.

```csharp
// For complete examples and data files, please go to https://github.com/groupdocs-classification/GroupDocs.Classification-for-.NET

// Setup license.

License license = new License();

license.SetLicense(licensePath);
```

#### Setting License from Stream

The following example shows how to load a license from a stream.

```csharp
// For complete examples and data files, please go to https://github.com/groupdocs-classification/GroupDocs.Classification-for-.NET

using (FileStream fileStream = File.OpenRead("GroupDocs.Classification.lic"))
{
    License license = new License();

    license.SetLicense(fileStream);
}
```

Calling License.SetLicense multiple times is not harmful but simply wastes processor time. If you are developing a Windows Forms or console application, call License.SetLicense in your startup code, before using GroupDocs.Classification classes. 

When developing an ASP.NET application, you can call License.SetLicense from the Global.asax.cs (Global.asax.vb) file in the Application\_Start protected method. It is called once when the application starts.   
Do not call License.SetLicense from within Page\_Load methods since it means the license will be loaded every time a web page is loaded.
