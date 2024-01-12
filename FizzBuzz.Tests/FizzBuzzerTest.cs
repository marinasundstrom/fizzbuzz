namespace FizzBuzz.Tests;

public class FizzBuzzerTest
{
    const string Fizz = nameof(Fizz);
    const string Buzz = nameof(Buzz);
    const string FizzBuzz = nameof(FizzBuzz);

    [Theory]
    [InlineData(3)]
    [InlineData(6)]
    [InlineData(9)]
    [InlineData(12)]
    public void KnownMultipleOf3ShouldYieldFizz(int no)
    {
        // Arrange

        // Act
        var result = FizzBuzzer.Fizz(no);

        // Assert
        Assert.Equal(Fizz, result);
    }

    [Theory(DisplayName = "Known number {0} is a multiple of 5 and should yield Buzz")]
    [InlineData(5)]
    [InlineData(10)]
    public void KnownMultipleOf5ShouldYieldBuzz(int no)
    {
        // Arrange

        // Act
        var result = FizzBuzzer.Fizz(no);

        // Assert
        Assert.Equal(Buzz, result);
    }

    [Theory]
    [InlineData(15)]
    public void KnownMultipleOfBoth3AndFiveShouldYieldFizzBuzz(int no)
    {
        // Arrange

        // Act
        var result = FizzBuzzer.Fizz(no);

        // Assert
        Assert.Equal(FizzBuzz, result);
    }

    [Fact]
    public void MultipleOfBoth3And5ShouldYieldBuzz()
    {
        // Arrange

        // Act
        var result = FizzBuzzer.Fizz(15);

        // Assert
        Assert.Equal(FizzBuzz, result);
    }

    [Fact]
    public void MultiplesOf3ShouldYieldFizz()
    {
        // Arrange
        Func<int, bool> multiplesOf3Only = x => x % 3 == 0 && x % 5 != 0;

        // Act
        var result = Enumerable.Range(1, 100)
            .Where(multiplesOf3Only)
            .Select(FizzBuzzer.Fizz);

        // Assert
        Assert.True(result.All(x => x == Fizz));
    }

    [Fact]
    public void MultiplesOf5ShouldYieldFizz()
    {
        // Arrange
        Func<int, bool> multiplesOf5Only = x => x % 5 == 0 && x % 3 != 0;

        // Act
        var result = Enumerable.Range(1, 100)
            .Where(multiplesOf5Only)
            .Select(FizzBuzzer.Fizz);

        // Assert
        Assert.True(result.All(x => x == Buzz));
    }

    [Fact]
    public void MultiplesOfBoth3And5ShouldYieldFizzBuzz()
    {
        // Arrange
        Func<int, bool> multiplesOfBoth3And5 = x => x % 3 == 0 && x % 5 == 0;

        // Act
        var result = Enumerable.Range(1, 100)
            .Where(multiplesOfBoth3And5)
            .Select(FizzBuzzer.Fizz);

        // Assert
        Assert.True(result.All(x => x == FizzBuzz));
    }
}