# Text & Document Classification API

[GroupDocs.Classification for .NET](https://products.groupdocs.com/classification/net) is an on-premise library for text and document classification with the help of IAB-2, Document or Sentiment taxonomies.

<p align="center">

  <a title="Download GroupDocs.Classification for .NET source examples" href="https://codeload.github.com/groupdocs-classification/GroupDocs.Classification-for-.NET/zip/master">
	<img src="https://raw.github.com/AsposeExamples/java-examples-dashboard/master/images/downloadZip-Button-Large.png" />
  </a>
</p>

Directory | Description
--------- | -----------
[Examples](https://github.com/groupdocs-classification/GroupDocs.Classification-for-.NET/tree/master/Examples)  | C# based examples and sample files for quick start.
[Showcases](https://github.com/groupdocs-classification/GroupDocs.Classification-for-.NET/tree/master/Showcases)  | An open source UI-based application demonstrating the core features.

## Classification Features

- 10+ supported [document formats](https://docs.groupdocs.com/classification/net/supported-document-formats/).
- Support for various [taxonomies](https://docs.groupdocs.com/classification/net/taxonomies/).
- [Sentiment classification](https://docs.groupdocs.com/classification/net/sentiment-classification-usage/) for English and Chinese.
- Select the number of results to return.
- Select precision/recall balance for Documents taxonomy.
  
## Supported File Formats

**Microsoft Word:** DOC, DOCM, DOCX, DOT, DOTM, DOTX, RTF\
**OpenOffice:** ODT, OTT\
**Fixed Layout:** PDF\
**Other:** TXT

## Develop & Deploy GroupDocs.Classification Anywhere

**Operating Systems:** Windows 10 (x64), Windows Desktop (x64), Windows Server (x64), Windows Azure, Mac OS X x64 (10.12+), Linux\
**Supported Frameworks:** .NET Core 2.0 or later, .NET Framework 4.7 or higher

## Get Started with GroupDocs.Classification for .NET

Are you ready to give GroupDocs.Classification for .NET a try? Simply execute `Install-Package GroupDocs.Classification` from Package Manager Console in Visual Studio to fetch & reference GroupDocs.Classification assembly in your project. If you already have GroupDocs.Classification for .NET and want to upgrade it, please execute `Update-Package GroupDocs.Classification` to get the latest version.

## Classify PDF with IAB-2 Taxonomy

```csharp
var response = classifier.Classify("document.pdf", ".", 3, Taxonomy.Iab2);
Console.WriteLine(response.BestClassName, response.BestClassProbability);
```

[Product Page](https://products.groupdocs.com/classification/net) | [Documentation](https://docs.groupdocs.com/classification/net/) | [Demo](https://products.groupdocs.app/classification/family) | [API Reference](https://apireference.groupdocs.com/net/classification) | [Examples](https://github.com/groupdocs-classification/GroupDocs.Classification-for-.NET) | [Blog](https://blog.groupdocs.com/category/classification/) | [Free Support](https://forum.groupdocs.com/c/classification) | [Temporary License](https://purchase.groupdocs.com/temporary-license)
