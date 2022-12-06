namespace Advent_of_Code_Day_Four
{
    public static class Program
    {
        public static void Main()
        {
            var elfPairs = File.ReadLines(@"C:\Users\User\Downloads\input.txt").ToArray();

            var cntContainsRanges = 0;
            var cntOverlapRanges = 0;

            foreach (var ep in elfPairs)
            {
                var elfPairRanges = GetRanges(ep);
                cntContainsRanges += FullyContainsRange(elfPairRanges) ? 1 : 0;
                cntOverlapRanges += RangesOverlap(elfPairRanges) ? 1 : 0;
            }

            Console.WriteLine(cntContainsRanges);
            Console.WriteLine(cntOverlapRanges);
        }

        private static int[] GetRanges(string elfPair)
        {
            var ranges = new int[4];

            var rangesArrStr = elfPair.Split('-', ',');
            ranges[0] = int.Parse(rangesArrStr[0]);
            ranges[1] = int.Parse(rangesArrStr[1]);
            ranges[2] = int.Parse(rangesArrStr[2]);
            ranges[3] = int.Parse(rangesArrStr[3]);

            return ranges;
        }

        private static bool FullyContainsRange(int[] ranges)
        {
            var result = false;

            if (ranges[0] <= ranges[2] && ranges[1] >= ranges[3])
            {
                result = true;
            }
            else if (ranges[2] <= ranges[0] && ranges[3] >= ranges[1])
            {
                result = true;
            }

            return result;
        }

        private static bool RangesOverlap(int[] ranges)
        {
            var result = false;

            if ((ranges[0] <= ranges[2] && ranges[1] >= ranges[2]) || (ranges[2] <= ranges[0] && ranges[2] >= ranges[1]))
            {
                result = true;
            }
            else if ((ranges[0] <= ranges[3] && ranges[1] >= ranges[3]) || (ranges[3] <= ranges[0] && ranges[3] >= ranges[1]))
            {
                result = true;
            }
            else if (FullyContainsRange(ranges))
            {
                result = true;
            }

            return result;
        }
    }
}