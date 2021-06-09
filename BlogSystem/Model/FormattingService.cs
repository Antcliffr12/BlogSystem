using System;
namespace BlogSystem.Model
{
    public class FormattingService
    {
        public string ReadableDate(DateTime date)
        {
            return date.ToString("D");
        }
    }
}
