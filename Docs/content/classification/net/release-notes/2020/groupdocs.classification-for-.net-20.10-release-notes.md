---
id: groupdocs-classification-for-net-20-10-release-notes
url: classification/net/groupdocs-classification-for-net-20-10-release-notes
title: GroupDocs.Classification for .NET 20.10 Release Notes
weight: 5
description: " "
keywords: Sentiment Analysis Classification IAB-2 Documents .NET News Categorization
productName: GroupDocs.Classification for .NET
hideChildren: False
---
### Major Features

*   A new 3 classes Sentiment Classification taxonomy was added (positive/neutral/negative).
*   Sentiment Classification (Analysis) supports 4 languages now: English, Chinese, Spanish, and German.
*   Sentiment Classification is now multilingual: there is no need to select language(s) and input text can be multilingual.

### All Changes

| Key | Summary | Category |
| --- | --- | --- |
| CLASSNET-72 | Add Spanish and German languages support | Feature |
| CLASSNET-74 | Add a new taxonomy for 3 classes Sentiment Classification  | Feature |

## Public API and Backward Incompatible Changes

### Update SentimentClassifier class

SentimentConfig parameter of SentimentClassifier constructor has no effect now. It remains as a parameter for the back-compatibility.

```csharp
var sentimentClassifier = new SentimentClassifier();
 
/// PositiveProbability method returns the probability of the positive sentiment.
var positiveProbability = sentimentClassifier.PositiveProbability("This is a new must-have thing.");
Console.WriteLine($"The probability of a positive sentiment is { positiveProbability }");
 
/// Classify method returns ClassificationResult object with the best class probability and name.
var response = sentimentClassifier.Classify("This is a new must-have thing.");
Console.WriteLine($"The best class name:{response.BestClassName}, probability: {response.BestClassProbability}");
```

### Added a new taxonomy: Taxonomy.Sentiment3

Taxonomy.Sentiment3 categorize sentiments into Negative, Neutral or Positive classes and can be used with Classifier class

```csharp
var classifier = new Classifier();
var response = classifier.Classify("This is a new must have thing.", taxonomy: Taxonomy.Sentiment3);
Console.WriteLine(response.BestClassName);

response = classifier.Classify("Esto es algo nuevo que debe tener.", taxonomy: Taxonomy.Sentiment3);
Console.WriteLine(response.BestClassName);
```
  
More resources

### GitHub Examples

You may easily run the code above and see the feature in action in our GitHub examples:

*   [GroupDocs.Classification for .NET examples and showcase](https://github.com/groupdocs-classification/GroupDocs.Classification-for-.NET)

### Free Online App

Along with full-featured .NET library we provide simple but powerful free Apps. 

You are welcome to classify texts and/or documents with free to use online **[GroupDocs Classification App](https://products.groupdocs.app/classification/total)**.