namespace StudentsConsole.extensions
{
    public static class DateTimeExtnesions
    {
        public static DateTime EndOfDay(this DateTime date)
        {
            return DateTime.Parse(date.ToString("dd/MM/yyyy 23:59:59"));
        }
        public static DateTime StartOfDay(this DateTime date)
        {
            return DateTime.Parse(date.ToString("dd/MM/yyyy 00:00:01"));
        }
    }
}
