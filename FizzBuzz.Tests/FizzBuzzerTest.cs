namespace FizzBuzz.Tests;

public class FizzBuzzerTest
{
    [Fact]
    public void MultipleOf3ShouldYieldFizz()
    {
        // Arrange

        // Act
        var result = FizzBuzzer.Fizz(3);

        // Assert
        Assert.Equal("Fizz", result);
    }

    [Fact]
    public void MultipleOf5ShouldYieldBuzz()
    {
        // Arrange

        // Act
        var result = FizzBuzzer.Fizz(10);

        // Assert
        Assert.Equal("Buzz", result);
    }

    [Fact]
    public void MultipleOfBoth3And5ShouldYieldBuzz()
    {
        // Arrange

        // Act
        var result = FizzBuzzer.Fizz(15);

        // Assert
        Assert.Equal("FizzBuzz", result);
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
        Assert.True(result.All(x => x == "Fizz"));
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
        Assert.True(result.All(x => x == "Buzz"));
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
        Assert.True(result.All(x => x == "FizzBuzz"));
    }
}