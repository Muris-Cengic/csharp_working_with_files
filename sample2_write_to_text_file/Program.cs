namespace sample2_write_to_text_file
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // After the program is compiled it goes to <project_folder>\bin\Debug\netx.0\ folder
            // if we want to create a file in the same folder as this program before compailation we need to go back to project_folder
            StreamWriter writer = new StreamWriter(@"..\..\..\HelloWorldCreated.txt");
            writer.WriteLine("Hello World!!");
            writer.WriteLine("From the StreamWriter class");
            writer.Close();
        }
    }
}
