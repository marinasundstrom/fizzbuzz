public static class RangeEnumerableExtensions
{
    public static IEnumerator<int> GetEnumerator(this Range range)
    {
        if (range.End.IsFromEnd)
        {
            throw new NotSupportedException();
        }

        return Enumerable.Range(range.Start.Value, range.End.Value).GetEnumerator();
    }
}