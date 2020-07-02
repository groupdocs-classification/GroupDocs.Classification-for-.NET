---
id: groupdocs-classification-for-net-20-3-release-notes
url: classification/net/groupdocs-classification-for-net-20-3-release-notes
title: GroupDocs.Classification for .NET 20.3 Release Notes
weight: 2
description: " "
keywords: Sentiment Analysis Classification IAB-2 Documents .NET News Categorization
productName: GroupDocs.Classification for .NET
hideChildren: False
---
### Major Features

Sentiment Classification (Analysis) was added.

Raw text classification speed has been increased several times.

### All Changes

| Key | Summary | Category |
| --- | --- | --- |
| CLASSNET-6 | Implement Sentiment Classification | Feature |
| CLASSNET-26 | Increase processing speed for raw text classification | Feature |

## Public API and Backward Incompatible Changes

### Added a new class SentimentClassifier

It can be used without initialization of **Classifier** class. It requires less memory and initializes faster.

```csharp
var sentimentClassifier = new SentimentClassifier();
 
/// PositiveProbability method returns the probability of the positive sentiment.
var positiveProbability = sentimentClassifier.PositiveProbability("This is a new must-have thing.");
Console.WriteLine($"The probability of a positive sentiment is { positiveProbability }");
 
/// Classify method returns ClassificationResult object with the best class probability and name.
var response = sentimentClassifier.Classify("This is a new must-have thing.");
Console.WriteLine($"The best class name:{response.BestClassName}, probability: {response.BestClassProbability}");
```

### Added a new taxonomy: Taxonomy.Sentiment

Taxonomy.Sentiment can be used with Classifier class

```csharp
var classifier = new Classifier();
var response = classifier.Classify("This is a new must have thing.", bestClassesCount: 1, taxonomy: Taxonomy.Sentiment);
Console.WriteLine(response.BestClassName);
```

Taxonomy.Sentiment contains two classes: Negative and Positive.

It also can be used with files

```csharp
var response = classifier.Classify(filename, folder, taxonomy: Taxonomy.Sentiment);
Console.WriteLine(response.BestClassName);

```

  

or with file streams

```csharp
using (var stream = File.OpenRead(filepath))
{
    var result = classifier.Classify(stream, null, taxonomy: Taxonomy.Sentiment);
    Console.WriteLine(result.BestClassName);
}
```
