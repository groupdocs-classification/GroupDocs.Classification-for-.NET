---
id: features-overview
url: classification/net/features-overview
title: Features Overview
weight: 2
description: ""
keywords: 
productName: GroupDocs.Classification for .NET
hideChildren: False
---
GroupDocs.Classification main feature is an ability to classify raw text and documents with IAB-2, Documents, Sentiment or Sentiment3 [taxonomies]({{< ref "classification/net/developer-guide/taxonomies.md" >}}).
Sentiment Classification (Analysis) supports 4 languages: English, Chinese, Spanish, and German.

GroupDocs.Classification provides flexible set of settings to customize classification process:

| Name | Description | Default value |
| --- | --- | --- |
| bestClassesCount | Select the number of results to return | 1 |
| taxonomy | Select [taxonomy]({{< ref "classification/net/developer-guide/taxonomies.md" >}}) (IAB-2, Documents, Sentiment or Sentiment3). | Taxonomy.Iab2 |
| precisionRecallBalance | Select precision/recall balance for Documents taxonomy. If the classifier is not sure of the result, it will return Other class. If precision selected, then classificator will try to return document class only if completely sure. Opposite if recall selected, then it will try to return document class even if it not sure. Default is a balanced one value. | PrecisionRecallBalance.Default |

##   
Raw text classification

GroupDocs.Classification supports classifying raw text with IAB-2, Documents, Sentiment or Sentiment3 taxonomies. The classifier will not use the document structure in this case.

## Document classification

GroupDocs.Classification supports classifying documents with the next format:

*   Docs
*   PDF
*   OpenOffice
*   RichText (RTF), TXT

## Classification results

GroupDocs.Classification returns result in the next form:

```csharp
ClassificationResult{
    BestClassName: string,
    BestClassProbability: float
    BestResults :
        Array<{
           Name: string,
           Probability: float
        }>
}
```

BestResults will be null if the number of results to return equals 1.
