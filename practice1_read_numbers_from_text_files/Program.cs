namespace practice1_read_numbers_from_text_files
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = "numbers1.txt";
            int highestNumber = int.MinValue;

            using StreamReader reader = new StreamReader(filePath);

            string content = reader.ReadToEnd();

            string[] numbersAsArrayOfStrings = content.Split(',');

            for (int i = 0; i < numbersAsArrayOfStrings.Length; i++)
            {
                string numberAsString = numbersAsArrayOfStrings[i].Trim();
                int number = int.Parse(numberAsString);

                if (number > highestNumber)
                {
                    highestNumber = number;
                }
            }

            Console.WriteLine($"The highest number is: {highestNumber}");
        }
    }
}
