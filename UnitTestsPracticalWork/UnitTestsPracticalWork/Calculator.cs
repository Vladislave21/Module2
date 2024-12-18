namespace UnitTestsPracticalWork;

public class Calculator
{
    public static int Factorial (int value)
    {
        if (value < 0)
            throw new ArgumentException("Cannot create factorial with values less 0");

        if (value < 2)
            return 1;

        return value * Factorial(--value);
    }
}