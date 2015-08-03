using System;
using System.Linq;

namespace P2_ReformatYourOwnCode
{
    class Reformatted
    {
        private static string RemoveInvalidChars(string source, char[] invalidChars)
        {
            return invalidChars.Aggregate(source, (current, c) => current.Replace(c.ToString(), ""));
        }

        //Test
        static void Main()
        {
            string text = "Once upon a time there was a fabulous kingdom!";
            string processed = RemoveInvalidChars(text, new[]
            {
                's',
                'c'
            });

            Console.WriteLine(processed);
        }
    }
}
