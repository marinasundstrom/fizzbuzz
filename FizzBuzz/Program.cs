using static System.Console;

// INFO: I have extended Range to have an enumerator.
foreach (var no in 1..100)
{
    WriteLine(FizzBuzzer.Fizz(no));
}