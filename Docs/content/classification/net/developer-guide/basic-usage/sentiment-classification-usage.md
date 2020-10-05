---
id: sentiment-classification-usage
url: classification/net/sentiment-classification-usage
title: Sentiment classification usage
weight: 6
description: ""
keywords: 
productName: GroupDocs.Classification for .NET
hideChildren: False
---
Create an instance of **SentimentClassifier** class. It is multilingual and supports English, Chinese, Spanish, and German.

**Creates SentimentClassifier instance**

```csharp
var sentimentClassifier = new SentimentClassifier();
```

and call **PositiveProbability** method

**Classifies sentiment by text**

```csharp
var positiveProbability = sentimentClassifier.PositiveProbability("This is a new must-have thing.");
Console.WriteLine($"The probability of a positive sentiment is { positiveProbability }");
```

or call **Classify** method

**Classifies sentiment by text**

```csharp
var response = sentimentClassifier.Classify("This is a new must-have thing.");
Console.WriteLine($"The best class name:{response.BestClassName}, probability: {response.BestClassProbability}");
```

**Classifies sentiment by text with 3 classes taxonomy (Negative/Neutral/Positive)**

```csharp
var response = sentimentClassifier.Classify("This is a new must-have thing.", taxonomy: Taxonomy.Sentiment3);
Console.WriteLine($"The best class name:{response.BestClassName}, probability: {response.BestClassProbability}");
```

**SentimentClassifier** class is thread-safe.
