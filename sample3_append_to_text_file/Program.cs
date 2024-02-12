namespace sample3_append_to_text_file
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //In properties of TextFileToAppendTo.txt it is set to always copy to output directory.
            //This means that original file will always(whenever we run the program) be copied to output directory. After it gets copied, program will append numbers to it.
            //append, intput parametar set to true
            StreamWriter sw = new StreamWriter("TextFileToAppendTo.txt", true);

            //Add empty line to existing file
            sw.WriteLine();

            //Write out the numbers 1 to 10 on the same line.
            for (int x = 0; x < 10; x++)
            {
                sw.Write(x);
            }

            sw.Close();

            //go to bin\Debug\netx.0 folder to see created text file 
        }
    }
}
