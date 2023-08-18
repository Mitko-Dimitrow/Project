using System.Globalization;
using System.Text.RegularExpressions;
using System.Text;

namespace FashionStoreDemo.Data
{
    public static class StringSlugify
    {
        public static string RemoveAccents(this string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return input;

            input = input.Normalize(NormalizationForm.FormD);
            char[] chars = input
                .Where(c => CharUnicodeInfo.GetUnicodeCategory(c)
                != UnicodeCategory.NonSpacingMark).ToArray();

            return new string(chars).Normalize(NormalizationForm.FormC);
        }


        public static string Slugify(this string phrase)
        {
            // Remove all accents and make the string lower case.  
            string output = RemoveAccents(phrase).ToLower();

            // Remove all special characters from the string.  

            output = Regex.Replace(output, @"[^A-Za-z0-9\s-]", "");

            // Remove all additional spaces in favour of just one.  
            output = Regex.Replace(output, @"\s+", " ").Trim();

            // Replace all spaces with the hyphen.  
            output = Regex.Replace(output, @"\s", "-");

            // Return the slug.  
            return output;
        }
    }
}
