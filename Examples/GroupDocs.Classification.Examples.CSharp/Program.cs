namespace GroupDocs.Classification.Examples
{
    using System;
    using System.IO;
    using GroupDocs.Classification.DTO;
    using GroupDocs.Classification.Exceptions;

    class Program
    {
        public const string dataFolderPath = "../../../../Data";

        private static readonly Classifier classifier = new Classifier();

        static Program() { }

        static void Main(string[] args)
        {
            Console.WriteLine("Classifier was initialized.");

            //ExStart:ApplyingLicense
            /**
             *  Applying product license
             *  Please uncomment the statement if you do have license.
             */
            // const string licensePath = "../../../../GroupDocs.Classification.NET.Full.lic";
            // new License().SetLicense(licensePath);

            //ExEnd:ApplyingLicense

            ClassificationResponse response;

            #region Classify raw text

            // Simple IAB-2 text classification
            response = classifier.Classify("Medicine is an important part of our lifes");
            Console.WriteLine($"{response.BestClassName}, {response.BestClassProbability}");

            // Change taxonomy and best classes count
            response = classifier.Classify("Medicine is an important part of our lifes", 2, Taxonomy.Documents, PrecisionRecallBalance.Recall);
            Console.WriteLine($"{response.BestClassName}, {response.BestClassProbability}");
            #endregion

            #region Classify documents

            // Classify PDF document by path with IAB-2 taxonomy and return 2 best results
            ClassifyByFilePath("Annotations.pdf", Taxonomy.Iab2, 2);

            // Classify doc document by path with IAB-2 taxonomy and return 3 best results
            ClassifyByFilePath("four-pages.docx", Taxonomy.Iab2, 3);

            // Classify txt document by path with Documents taxonomy and return 4 best results
            ClassifyByFilePath("Letter.txt", Taxonomy.Documents, 4);

            // Classify txt document by path with Documents taxonomy and return 4 best results
            ClassifyByFilePath("Letter.txt", Taxonomy.Documents, 4);

            // Classify PDF document from stream with Documents taxonomy and return 2 best results
            ClassifyStream("Annotations.pdf", Taxonomy.Documents, 2);

            // Classify doc document from stream with Documents taxonomy and return the best result
            ClassifyStream("four-pages.docx", Taxonomy.Documents, 1);

            // Classify txt document from stream with IAB-2 taxonomy and return 3 best results
            ClassifyStream("Letter.txt", Taxonomy.Iab2, 3);

            #endregion

            #region Classify password-protected documents

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

            #region Print taxonomy classes

            // Print IAB-2 taxonomy classes
            Console.WriteLine("IAB-2 taxonomy classes: ");
            Console.WriteLine(String.Join(" ", TaxonomyClasses.Iab2Classes));

            // Print Documents taxonomy classes
            Console.WriteLine("Documents taxonomy classes: ");
            Console.WriteLine(String.Join(" ", TaxonomyClasses.DocumentsClasses));

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