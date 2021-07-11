using System;
using System.IO;

namespace WordCounterConsoleApp.Classes
{
    public static class TextFileStreamReaderResult
    {
        public static StreamReader GetStream(string filePath)
        {
            try
            {
                var streamReader = new StreamReader(filePath);

                Console.WriteLine($"File {filePath} successfully opened");

                return streamReader;
            }
            catch(FileNotFoundException)
            {
                Console.Error.WriteLine($"File {filePath} not found");
            }
            catch(DirectoryNotFoundException)
            {
                Console.Error.WriteLine("Directory not found");
            }
            catch(IOException)
            {
                Console.WriteLine($"Cannot open file {filePath}");
            }

            return null;
        }
    }
}
