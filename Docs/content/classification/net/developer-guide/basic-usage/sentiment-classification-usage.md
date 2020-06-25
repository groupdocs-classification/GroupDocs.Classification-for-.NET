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
Create an instance of **SentimentClassifier** class

**Creates SentimentClassifier instance**

```csharp
var sentimentClassifier = new SentimentClassifier();
```

**Creates SentimentClassifier instance for the Chinese language**

```csharp
var sentimentClassifier = new SentimentClassifier(SentimentConfig.ChineseLanguage);
```

**Creates an instance of the Sentiment Classifier with multi-language support and auto-detection is English or Chinese**

```csharp
var sentimentClassifier = new SentimentClassifier(SentimentConfig.AllLanguages);
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

**SentimentClassifier **class is thread-safe.
