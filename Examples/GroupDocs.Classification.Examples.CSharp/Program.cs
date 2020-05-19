namespace GroupDocs.Classification.Examples
{
    using System;
    using System.Diagnostics;
    using System.IO;
    using System.Linq;
    using GroupDocs.Classification.DTO;
    using GroupDocs.Classification.Exceptions;

    class Program
    {
        public const string dataFolderPath = "../../../../Data";

        private static Classifier classifier;

        private static SentimentClassifier sentimentClassifier;

        static Program() { }

        static void Main(string[] args)
        {

            //ExStart:ApplyingLicense
            /**
             *  Applying product license
             *  Please uncomment the statement if you do have license.
             */
            // const string licensePath = "../../../../GroupDocs.Classification.NET.Full.lic";
            // new License().SetLicense(licensePath);

            //ExEnd:ApplyingLicense

            var englishSentiments = new string[]
            {
                "Now that that is out of the way, this thing is a beast. It is fast and runs cool.",
                "When I used compressed air a cloud of dust bellowed out from the card (small scuffs and scratches)."
            };

            var chineseSentiments = new string[]
            {
                "这款打开没有想象中好看，颜色太暗了。但是东西是好的，经常买。",
                "就那样，有 瑕疵"
            };
            
            var multilanguageSentiment = englishSentiments.Concat(chineseSentiments);

            Console.WriteLine("SentimentClassifier with language auto-detection initialization is started.");

            var sentimentClassifierAllLanguages = new SentimentClassifier(SentimentConfig.AllLanguages);

            Console.WriteLine("SentimentClassifier(SentimentConfig.AllLanguages) was initialized.");

            #region Classify raw texts with Classify method of SentimentClassifier class (language auto-detection).

            Console.WriteLine("\nClassify raw text with Classify method of SentimentClassifier class (language auto-detection).");
            foreach (var sentiment in multilanguageSentiment)
            {
                try
                {
                    Stopwatch sw = new Stopwatch();
                    sw.Start();
                    var result = sentimentClassifierAllLanguages.Classify(sentiment);
                    Console.WriteLine($"Sentiment is {result.BestClassName} with probability {result.BestClassProbability}. Elapsed: {sw.ElapsedMilliseconds}ms\n");
                }
                catch (ApiException e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            #endregion

            Console.WriteLine("SentimentClassifier initialization for the Chinese language is started.");

            var sentimentClassifierChineseLanguage = new SentimentClassifier(SentimentConfig.ChineseLanguage);

            Console.WriteLine("SentimentClassifier(SentimentConfig.ChineseLanguage) was initialized.");

            #region Classify raw texts with Classify method of SentimentClassifier class (Chinese language).

            Console.WriteLine("\nClassify raw text with Classify method of SentimentClassifier class (Chinese language).");
            foreach (var sentiment in chineseSentiments)
            {
                try
                {
                    Stopwatch sw = new Stopwatch();
                    sw.Start();
                    var result = sentimentClassifierChineseLanguage.Classify(sentiment);
                    Console.WriteLine($"Sentiment is {result.BestClassName} with probability {result.BestClassProbability}. Elapsed: {sw.ElapsedMilliseconds}ms\n");
                }
                catch (ApiException e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            #endregion

            Console.WriteLine("SentimentClassifier initialization is started.");
            
            sentimentClassifier = new SentimentClassifier();

            Console.WriteLine("SentimentClassifier was initialized.");

            #region Classify raw texts with Classify method of SentimentClassifier class (English language).

            Console.WriteLine("\nClassify raw text with Classify method of SentimentClassifier class (English language).");
            foreach (var sentiment in englishSentiments)
            {
                try
                {
                    Stopwatch sw = new Stopwatch();
                    sw.Start();
                    var result = sentimentClassifier.Classify(sentiment);
                    Console.WriteLine($"{sentiment}");
                    Console.WriteLine($"This sentiment is {result.BestClassName} with probability {result.BestClassProbability}. Elapsed: {sw.ElapsedMilliseconds}ms\n");
                }
                catch (ApiException e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            #endregion

            #region Classify raw text with PositiveProbability method of SentimentClassifier class.

            Console.WriteLine("\nClassify raw text with PositiveProbability method of SentimentClassifier class.");
            foreach (var sentiment in englishSentiments)
            {
                try
                {
                    Stopwatch sw = new Stopwatch();
                    sw.Start();
                    var positiveProbability = sentimentClassifier.PositiveProbability(sentiment);
                    Console.WriteLine($"{sentiment}");
                    Console.WriteLine($"This sentiment is {(positiveProbability > 0.5 ? "positive" : "negative")}. Elapsed: {sw.ElapsedMilliseconds}ms\n");
                }
                catch (ApiException e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            #endregion

            Console.WriteLine("Classifier initialization is started.");

            // Uncomment for the multilanguage sentiment classification.
            // classifier = new Classifier(SentimentConfig.AllLanguages);
            classifier = new Classifier();
            
            Console.WriteLine("Classifier was initialized.");
            
            ClassificationResponse response;

            #region Classify raw text with Classifier class.

            Console.WriteLine("\nClassify raw text with Classifier class.");

            // Simple IAB-2 text classification
            response = classifier.Classify("Medicine is an important part of our lifes");
            Console.WriteLine($"{response.BestClassName}, {response.BestClassProbability}");

            // Change taxonomy and best classes count
            response = classifier.Classify("Medicine is an important part of our lifes", 2, Taxonomy.Documents, PrecisionRecallBalance.Recall);
            Console.WriteLine($"{response.BestClassName}, {response.BestClassProbability}");

            // Classify sentiment
            response = classifier.Classify("This is a new must-have thing.", 2, Taxonomy.Sentiment);
            Console.WriteLine($"{response.BestClassName}, {response.BestClassProbability}");

            // Classify sentiment in Chinese
            response = classifier.Classify("这是新的必须要做的事情", 2, Taxonomy.Sentiment);
            Console.WriteLine($"{response.BestClassName}, {response.BestClassProbability}");

            #endregion

            #region Classify documents with IAB-2 taxonomy.

            Console.WriteLine("\nClassify documents with IAB-2 taxonomy.");

            // Classify PDF document by path with IAB-2 taxonomy and return 2 best results
            ClassifyByFilePath("Annotations.pdf", Taxonomy.Iab2, 2);

            // Classify doc document by path with IAB-2 taxonomy and return the best result
            ClassifyByFilePath("four-pages.docx", Taxonomy.Iab2, 1);

            // Classify txt document by path with IAB-2 taxonomy and return 4 best results
            ClassifyByFilePath("Letter.txt", Taxonomy.Iab2, 4);

            #endregion

            #region Classify documents with Documents taxonomy.

            Console.WriteLine("\nClassify documents with Documents taxonomy.");

            // Classify PDF document from stream with Documents taxonomy and return 2 best results
            ClassifyStream("Annotations.pdf", Taxonomy.Documents, 2);

            // Classify doc document from stream with Documents taxonomy and return the best result
            ClassifyStream("four-pages.docx", Taxonomy.Documents, 1);

            // Classify txt document from stream with Documents taxonomy and return 3 best results
            ClassifyStream("Letter.txt", Taxonomy.Documents, 3);

            #endregion

            #region Classify documents with Sentiment taxonomy.

            Console.WriteLine("\nClassify documents with Sentiment taxonomy.");

            // Classify PDF document from stream with Sentiment taxonomy and return 2 best results
            ClassifyStream("Annotations.pdf", Taxonomy.Sentiment, 2);

            // Classify doc document from stream with Sentiment taxonomy and return the best result
            ClassifyStream("four-pages.docx", Taxonomy.Sentiment, 1);

            // Classify txt document from stream with Sentiment taxonomy and return 3 best results
            ClassifyStream("Letter.txt", Taxonomy.Sentiment, 2);

            #endregion

            #region Classify password-protected documents.

            Console.WriteLine("\nClassify password-protected documents.");

            try
            {
                response = classifier.Classify("password-protected.docx", dataFolderPath, password: "password");
                Console.WriteLine($"password-protected.docx: {response.BestClassName}, {response.BestClassProbability}");
            }
            catch (ApiException e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                using (var fs = File.OpenRead(Path.Combine(dataFolderPath, "password-protected.docx")))
                {
                    response = classifier.Classify(fs, password: "password");
                    Console.WriteLine($"password-protected.docx: {response.BestClassName}, {response.BestClassProbability}");
                }
            }
            catch (ApiException e)
            {
                Console.WriteLine(e.Message);
            }

            #endregion

            #region Print taxonomy classes.

            Console.WriteLine("\nPrint taxonomy classes.");

            // Print IAB-2 taxonomy classes
            Console.WriteLine("IAB-2 taxonomy classes: ");
            Console.WriteLine(String.Join(" ", TaxonomyClasses.Iab2Classes));

            // Print Documents taxonomy classes
            Console.WriteLine("Documents taxonomy classes: ");
            Console.WriteLine(String.Join(" ", TaxonomyClasses.DocumentsClasses));

            // Print Sentiment taxonomy classes
            Console.WriteLine("Sentiment taxonomy classes: ");
            Console.WriteLine(String.Join(" ", TaxonomyClasses.SentimentClasses));

            #endregion

            Console.WriteLine("Done...");
            Console.ReadKey();
        }

        private static void ClassifyByFilePath(string filename, Taxonomy taxonomy, int bestClassesCount)
        {
            try
            {
                var response = classifier.Classify(filename, dataFolderPath, bestClassesCount, taxonomy);
                Console.WriteLine($"{filename}: {response.BestClassName}, {response.BestClassProbability}");
            }
            catch (ApiException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private static void ClassifyStream(string filename, Taxonomy taxonomy, int bestClassesCount)
        {
            try
            {
                using (var fs = File.OpenRead(Path.Combine(dataFolderPath, filename)))
                {
                    var response = classifier.Classify(fs, filename, bestClassesCount, taxonomy);
                    Console.WriteLine($"{filename}: {response.BestClassName}, {response.BestClassProbability}");
                }
            }
            catch (ApiException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}