namespace Marketify.Application.Extensions
{
    public static class CustomEncoders
    {
        public static string UrlEncode(this string value)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(value);
            return WebEncoders.Base64UrlEncode(bytes);
        }

        public static string UrlDecode(this string value)
        {
            byte[] bytes = WebEncoders.Base64UrlDecode(value);
            return Encoding.UTF8.GetString(bytes);
        }
    }
}
