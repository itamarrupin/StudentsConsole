namespace StudentsConsole.extensions
{
    public static class IntegerExtension
    {
        public static bool Between(this int number, int min, int max)
        {
            return (number >= min && number <= max);
        }
    }
}
