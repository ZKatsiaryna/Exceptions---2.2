using System;
using ConvertStringToIntLibrary;

namespace CheckConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            var numberToTranslate = Console.ReadLine();

            try
            {
                StringConverter converter = new StringConverter();
                int i = converter.ConvertStringToInt(numberToTranslate);
            }

            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (InvalidNumberFormatException ex)
            {
                Console.WriteLine(ex.Message);
            }

            catch (Exception)
            {
                Console.WriteLine("The unhandled error occurred.");
            }
        }
    }
}
