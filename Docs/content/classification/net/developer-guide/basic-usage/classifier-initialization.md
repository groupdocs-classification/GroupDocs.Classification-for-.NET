---
id: classifier-initialization
url: classification/net/classifier-initialization
title: Classifier initialization
weight: 1
description: ""
keywords: 
productName: GroupDocs.Classification for .NET
hideChildren: False
---
Initialization of **Classifier** class without any parameters will create English language classifier:

```csharp
var classifier = new Classifier();
```

Initialize with sentimentConfig parameter to enable Chinese-only language support or multiple languages support (English and Chinese).

**Initializes Classifier with the Chinese language sentiment classification**

```csharp
var classifier = new Classifier(SentimentConfig.ChineseLanguage);
```

**Initializes Classifier with the multiple language sentiment classification**

```csharp
var classifier = new Classifier(SentimentConfig.AllLanguages);
```

**Classifier** class is thread-safe.
