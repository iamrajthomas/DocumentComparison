using System;
using System.IO;

namespace ConsoleApp
{
    class Program
    {
        static string dataDir = "../../UserFiles/";

        static void Main(string[] args)
        {
            StartInvokeComparison();
        }

        public static void StartInvokeComparison()
        {
            try
            {
                Common.SetLicense();

                string document1 = dataDir + "Document version 1.docx";
                string document2 = dataDir + "Document version 3.docx";
                string comparisonDocument = GetCompareDocumentName(document1, document2);
                int added = 0, deleted = 0;

                DocumentComparisonUtility comp = new DocumentComparisonUtility();
                comp.Compare(document1, document2, comparisonDocument, ref added, ref deleted);

                Console.WriteLine("comparison document: " + comparisonDocument);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("Program finished successfully.");
            Console.ReadKey();
        }

        private static string GetCompareDocumentName(string document1, string document2)
        {
            return dataDir + Path.GetFileNameWithoutExtension(document1) + " Compared to " +
                Path.GetFileNameWithoutExtension(document2) + ".docx";
        }
    }
}
