namespace MoneyExtension
{
    public static class Money
    {
        public static int ToCents(this decimal amount)
        {
            string text = amount.ToString("N2").Replace(",", "").Replace(".", "");
            if (string.IsNullOrEmpty(text)) return 0;
            int.TryParse(text, out int result);
            return result;
        }
    }
}
