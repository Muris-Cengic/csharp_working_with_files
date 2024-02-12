namespace sample1_read_text_file
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // HelloWorld.txt must be present in the output directory
            // We can you the absolute path to file as well eg. C:\Users\...\csharp_working_with_files\HelloWorld.txt
            StreamReader reader = new StreamReader(@"HelloWorld.txt");
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
