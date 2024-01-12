
using System.Text;

public static class FizzBuzzer
{
    public static string FizzOrBuzz(int no)
    {
        StringBuilder sb = new();

        if (no % 3 == 0 || no % 5 == 0)
        {
            if (no % 3 == 0)
            {
                sb.Append("Fizz");
            }
            if (no % 5 == 0)
            {
                sb.Append("Buzz");
            }
        }
        else
        {
            sb.Append(no);
        }

        return sb.ToString();
    }
}