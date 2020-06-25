---
id: classify-document-from-stream
url: classification/net/classify-document-from-stream
title: Classify document from stream
weight: 3
description: ""
keywords: 
productName: GroupDocs.Classification for .NET
hideChildren: False
---
Classifying of the document from stream could be performed with the next step

*   Call [**Classify** ](https://apireference.groupdocs.com/net/classification/groupdocs.classification/classifier/methods/classify)method for "stream" stream with Documents taxonomy and return 2 best results.
*   Handle possible ApiException 

```csharp
Classify document from stream with Documents taxonomy and return 2 best resultstry
{
    var response = classifier.Classify(stream, 2, Taxonomy.Documents);
    Console.WriteLine(response.BestClassName, response.BestClassProbability);
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
}
```
