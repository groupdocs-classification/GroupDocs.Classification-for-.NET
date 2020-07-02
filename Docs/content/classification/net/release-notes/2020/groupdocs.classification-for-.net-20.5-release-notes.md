---
id: groupdocs-classification-for-net-20-5-release-notes
url: classification/net/groupdocs-classification-for-net-20-5-release-notes
title: GroupDocs.Classification for .NET 20.5 Release Notes
weight: 3
description: " "
keywords: Sentiment Analysis Classification IAB-2 Documents .NET News Categorization
productName: GroupDocs.Classification for .NET
hideChildren: False
---
### Major Features

*   Chinese language support was added to the Sentiment Classification (Analysis).
*   Supported languages for the Sentiment Classification can be selected in the classifier constructor. If all the languages are selected, then both English and Chinese will be used and the proper language will be automatically detected.

### All Changes

| Key | Summary | Category |
| --- | --- | --- |
| CLASSNET-37 | Chinese language support in the Sentiment Classification | Feature |

## Public API and Backward Incompatible Changes

### Changes in GroupDocs.Classification.DTO.SentimentConfig class 

GroupDocs.Classification.DTO.SentimentConfig class was added

```csharp
/// <summary>
/// Configuration for the sentiment classification.
/// </summary>
public class SentimentConfig
{
    /// <summary>
    /// Sentiment configuration for all languages.
    /// </summary>
    public static readonly SentimentConfig AllLanguages;
 
    /// <summary>
    /// Sentiment configuration for the English language.
    /// </summary>
    public static readonly SentimentConfig EnglishLanguage;
 
    /// <summary>
    /// Sentiment configuration for the Chinese language.
    /// </summary>
    public static readonly SentimentConfig ChineseLanguage;
}
```

### Changes in GroupDocs.GroupDocs.Classification.Classifier class

Constructor was changed to public Classifier(SentimentConfig sentimentConfig = null). sentimentConfig parameter was added.

Initializes new instance of Classifier class

```csharp
/// <summary>
/// Initializes a new instance of Classifier class.
/// </summary>
/// <param name="sentimentConfig">Sentiment classifier configuration.</param>
public Classifier(SentimentConfig sentimentConfig = null)
```

### Changes in GroupDocs.GroupDocs.Classification.SentimentClassifier class

Constructor was changed to public public SentimentClassifier(SentimentConfig config = null). config parameter was added.

Initializes new instance of SentimentClassifier class.

```csharp
/// <summary>
/// Initializes a new instance of SentimentClassifier class.
/// </summary>
/// <param name="config">Sentiment classifier configuration.</param>
public SentimentClassifier(SentimentConfig config = null)
```

## More resources

### GitHub Examples

You may easily run the code above and see the feature in action in our GitHub examples:

*   [GroupDocs.Classification for .NET examples and showcase](https://github.com/groupdocs-classification/GroupDocs.Classification-for-.NET)

### Free Online App

Along with full-featured .NET library we provide simple but powerful free Apps. 

You are welcome to classify texts and/or documents with free to use online **[GroupDocs Classification App](https://products.groupdocs.app/classification/total)**.
