using static System.String;

namespace Core.Common.Extensions
{
    public static class StringCustomExtensions
    {
        public static bool IsNullOrEmptyOrWhiteSpace(this string a)
        {
            return IsNullOrEmpty(a) || IsNullOrEmpty(a);
        }
    }
}
