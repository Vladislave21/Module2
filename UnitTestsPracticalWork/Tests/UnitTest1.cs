using UnitTestsPracticalWork;

namespace Tests;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestLess0()
    {
        int value = -2;
        Assert.ThrowsException<ArgumentException>(() => Calculator.Factorial(value));
    }

    [TestMethod]
    public void Test0()
    {
        int value = 0;
        int prediction = 1;
        int real = Calculator.Factorial(value);
        Assert.AreEqual(prediction, real);
    }

    [TestMethod]
    public void Test1()
    {
        int value = 1;
        int prediction = 1;
        int real = Calculator.Factorial(value);
        Assert.AreEqual(prediction, real);
    }

    [TestMethod]
    public void TestMore2()
    {
        int value = 5;
        int prediction = 120;
        int real = Calculator.Factorial(value);
        Assert.AreEqual(prediction, real);
    }
}