using CommandLine;
using System;
using System.IO;

namespace GroupDocs.Classification.Organizer
{
    class Options
    {
        [Option('i', "input", Default = "../../../../Data",
          HelpText = "Input directory to be processed.")]
        public string Input { get; set; }

        [Option('o', "output", Default = "../../../../Output",
          HelpText = "Output directory.")]
        public string Output { get; set; }
    }

    /// <summary>
    /// Organizes documents. Copies each file from the <input> folder to the class folder in the <output> folder.
    /// For example, a document that has been classified as Letter will be copied into <output>/Letter/ directory.
    /// </summary>
    class Organizer
    {
        private static readonly Classifier classifier = new Classifier();

        static Organizer() { }

        static void Main(string[] args)
        {
            Console.WriteLine("Classifier was initialized.");

            // Parse input and output folders.
            Parser.Default.ParseArguments<Options>(args)
                   .WithParsed<Options>(o =>
                   {
                       //ExStart:ApplyingLicense
                       /**
                        *  Applying product license
                        *  Please uncomment the statement if you do have license.
                        */
                       // const string licensePath = "../../../../GroupDocs.Classification.NET.Full.lic";
                       // new License().SetLicense(licensePath);

                       //ExEnd:ApplyingLicense

                       if (!Directory.Exists(o.Input))
                       {
                           throw new Exception("Input directory doesn't exist.");
                       }

                       // Creates <output> directory if it doesn't exist.
                       if (!Directory.Exists(o.Output))
                       {
                           Directory.CreateDirectory(o.Output);
                       }

                       // For each file in <input> folder.
                       foreach (var path in Directory.GetFiles(o.Input))
                       {
                           var filename = Path.GetFileName(path);
                           var directory = Path.GetDirectoryName(path);
                           try
                           {
                               // Classifies file with Documents taxonomy.
                               var result = classifier.Classify(filename, directory, taxonomy: Taxonomy.Documents);
                               Console.WriteLine(filename + ": " + result.BestClassName);

                               // Creates class directory in the <output> folder(if it doesn't exist)
                               var organizedDirectory = Path.Combine(o.Output, result.BestClassName);
                               if (!Directory.Exists(organizedDirectory))
                               {
                                   Directory.CreateDirectory(organizedDirectory);
                               }

                               // Copies the document.
                               File.Copy(path, Path.Combine(organizedDirectory, filename));
                           }
                           catch (Exception e)
                           {
                               Console.WriteLine(e.Message);
                           }
                       }
                   });
        }
    }
}
