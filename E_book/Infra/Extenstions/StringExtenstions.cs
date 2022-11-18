namespace E_book.Infra.Extenstions
{
    public static class StringExtenstions
    {
        public static int ToInt(this string source, int defaultValue)
        {
            bool isInt = int.TryParse(source, out int number);

            return isInt ? number : defaultValue;
        }
    }
}
