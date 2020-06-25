---
id: classify-document-by-path
url: classification/net/classify-document-by-path
title: Classify document by path
weight: 2
description: ""
keywords: 
productName: GroupDocs.Classification for .NET
hideChildren: False
---
### Classify document by path with IAB-2 taxonomy and return 2 best results

Classifying of the document could be performed with the next steps

*   Call **[Classify](https://apireference.groupdocs.com/net/classification/groupdocs.classification.classifier/classify/methods/2)** method for "document.pdf" file in the current (".") directory with IAB-2 taxonomy and return 2 best results.
*   Handle possible ApiException

```csharp
try
{
    var response = classifier.Classify("document.pdf", ".", 3, Taxonomy.Iab2);
    Console.WriteLine(response.BestClassName, response.BestClassProbability);
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
}
```

### Precisely classify document by path with Documents taxonomy and return 4 best results

*   Call **[Classify](https://apireference.groupdocs.com/net/classification/groupdocs.classification.classifier/classify/methods/2)** method for "document.doc" file in the current (".") directory with Documents taxonomy, set precision/recall balance to "Precision" and return 4 best results.
*   Handle possible ApiException
    

```csharp
try
{
    var response = classifier.Classify("document.doc", ".", 4, Taxonomy.Documents, PrecisionRecallBalance.Precision);
    Console.WriteLine(response.BestClassName, response.BestClassProbability);
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
}
```

### Classify password-protected document

Classifying of the password-protected document could be performed with the next step

*   Call **[Classify](https://apireference.groupdocs.com/net/classification/groupdocs.classification.classifier/classify/methods/2)** method for "document.doc" file in the current (".") directory with password parameter.
*   Handle possible ApiException

```csharp
try
{
    response = classifier.Classify("password-protected.docx", dataFolderPath, password: "password");
    Console.WriteLine(response.BestClassName, response.BestClassProbability);
}
catch (ApiException e)
{
    Console.WriteLine(e.Message);
}
```
