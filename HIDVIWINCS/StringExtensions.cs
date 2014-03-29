namespace HIDVIWINCS
{
    public static class StringExtensions
    {
        public static string EmptyOrNullAs(this string value, string defaultValue)
        {
            return string.IsNullOrEmpty(value) ? defaultValue : value;
        }
    }
}