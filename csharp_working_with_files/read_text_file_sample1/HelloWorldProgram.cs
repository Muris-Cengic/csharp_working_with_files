namespace csharp_working_with_files.read_text_file_sample1
{
    internal class HelloWorldProgram
    {
        static void Main(string[] args)
        {
            // HelloWorld.txt must be present in the output directory
            // We can you the absolute path to file as well eg. C:\Users\...\csharp_working_with_files\HelloWorld.txt
            StreamReader reader = new StreamReader(@".\read_text_file_sample1\HelloWorld.txt");
            string line = reader.ReadLine();

            while (line != null)
            {
                Console.WriteLine(line);
                line = reader.ReadLine();
            }

            reader.Close();
        }
    }
}
