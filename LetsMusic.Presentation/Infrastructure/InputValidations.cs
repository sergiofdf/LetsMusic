namespace LetsMusic.Presentation.Infrastructure
{
    public static class InputValidations
    {
        public static bool ValidateConsoleNotEmpty(string input)
        {
            return !string.IsNullOrEmpty(input);
        }
        public static bool ValidatePositiveNumber(string input)
        {
            if (ValidateConsoleNotEmpty(input))
            {
                if (input.Contains('.'))
                {
                    return false;
                }
                double convertedValue;
                return double.TryParse(input, out convertedValue) && convertedValue >= 0;
            }
            return false;
        }
    }
}
