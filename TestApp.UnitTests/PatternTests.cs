using NUnit.Framework;

namespace TestApp.UnitTests;

public class PatternTests
{
    // TODO: finish the test cases
    [TestCase("abcdef", 2, "aBcDeFaBcDeF")]
    [TestCase("ABCDEF", 1, "aBcDeF")]
    [TestCase("abcdef", 10, "aBcDeFaBcDeFaBcDeFaBcDeFaBcDeFaBcDeFaBcDeFaBcDeFaBcDeFaBcDeF")]
    public void Test_GeneratePatternedString_ValidInput_ReturnsExpectedResult(string input, 
        int repetitionFactor, string expected)
    {
        // Arrange

        // Act
        string result = Pattern.GeneratePatternedString(input, repetitionFactor);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GeneratePatternedString_EmptyInput_ThrowsArgumentException()
    {
        //Arrange
        string input = "";
        int repetitionFactor = 10;
        //Act + Assert
        Assert.That(() => Pattern.GeneratePatternedString(input, repetitionFactor), Throws.ArgumentException);
    }

    [Test]
    public void Test_GeneratePatternedString_NegativeRepetitionFactor_ThrowsArgumentException()
    {
        //Arrange
        string input = "ABCDEF";
        int repetitionFactor = -5;
        //Act + Assert
        Assert.That(() => Pattern.GeneratePatternedString(input, repetitionFactor), Throws.ArgumentException);
    }

    [Test]
    public void Test_GeneratePatternedString_ZeroRepetitionFactor_ThrowsArgumentException()
    {
        //Arrange
        string input = "ABCDEF";
        int repetitionFactor = 0;
        //Act + Assert
        Assert.That(() => Pattern.GeneratePatternedString(input, repetitionFactor), Throws.ArgumentException);
    }

    [TestCase("", 10)]
    [TestCase("abcdef", -5)]
    [TestCase("abcdefg", 0)]

    public void Test_GeneratePatternedString_InvalidInput_ThrowsArgumentException(string input, int repetitionFactor)
    {
        Assert.That(() => Pattern.GeneratePatternedString(input, repetitionFactor), Throws.ArgumentException);
    }
}
