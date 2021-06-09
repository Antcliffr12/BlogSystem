using System;
namespace BlogSystem.Areas.Identity.Data
{
    public class FormatWithFirstCaptial
    {
        public static string FirstLetterToUpper(string input)
        {
            return input = input.Substring(0, 1).ToUpper() + input.Substring(1, input.Length - 1);
        }

        
    }
}
