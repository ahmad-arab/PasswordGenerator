
namespace PasswordGenerator
{
    public class IncludeOptions
    {
        public bool IncludeCapitalLetters { get; set; } = true;
        public int WeightCapitalLetters { get; set; } = 1;

        public bool IncludeSmallLetters { get; set; } = true;
        public int WeightSmallLetters { get; set; } = 1;

        public bool IncludeNumbers { get; set; } = true;
        public int WeightNumbers { get; set; } = 1;

        public bool IncludeSymbols { get; set; } = true;
        public int WeightSymbols { get; set; } = 1;

    }
}
