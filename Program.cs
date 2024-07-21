namespace AppHWWeek3P2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Ensure that two command-line arguments are provided
            if (args.Length != 2)
            {
                Console.WriteLine("Usage: Program.exe <inputFile> <outputFile>");
                return;
            }

            string inputFilePath = args[0];
            string outputFilePath = args[1];

            try
            {
                using (StreamReader reader = new StreamReader(inputFilePath))
                using (StreamWriter writer = new StreamWriter(outputFilePath))
                {
                    string line;
                    int lineNumber = 1;

                    while ((line = reader.ReadLine()) != null)
                    {
                        writer.WriteLine($"{lineNumber}: {line}");
                        lineNumber++;
                    }
                }

                Console.WriteLine($"File '{inputFilePath}' has been processed and written to '{outputFilePath}' with line numbers.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }
}