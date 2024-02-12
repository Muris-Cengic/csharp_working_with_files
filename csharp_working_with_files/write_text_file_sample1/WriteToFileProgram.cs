namespace csharp_working_with_files.write_text_file_sample1
{
    public class WriteToFileProgram
    {
        public static void Main(string[] args)
        {
            String fileLocation = @".\write_text_file_sample1\HelloWorldCreated.txt";
            StreamWriter writer = new StreamWriter(fileLocation);

            writer.WriteLine("HelloWorld!");
            writer.WriteLine("From the StreamWriter Class");
            writer.Close();
        }
    }
}
