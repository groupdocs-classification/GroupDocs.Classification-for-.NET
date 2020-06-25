---
id: classify-raw-text
url: classification/net/classify-raw-text
title: Classify Raw Text
weight: 4
description: ""
keywords: 
productName: GroupDocs.Classification for .NET
hideChildren: False
---
### Simple IAB-2 text classification

Call **[Classify](https://apireference.groupdocs.com/net/classification/groupdocs.classification.classifier/classify/methods/2)** method with a text as the first parameter to perform classification. Default taxonomy (IAB-2) and bestClassesCount (1) will be used.

```csharp
var response = classifier.Classify("Medicine is an important part of our lifes");
Console.WriteLine(response.BestClassName, response.BestClassProbability);
```

### Raw text classification with Documents taxonomy and 2 best classes to return

Taxonomy, bestClassesCount and precisionRecallBalance could also be specified:

```csharp
var response = classifier.Classify("Medicine is an important part of our lifes", 2, Taxonomy.Documents, PrecisionRecallBalance.Recall);
Console.WriteLine(response.BestClassName, response.BestClassProbability);
```
