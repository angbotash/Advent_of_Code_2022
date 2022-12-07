namespace Advent_of_Code_Day_Six
{
    public class Program
    {
        public static void Main()
        {
            var input = File.ReadAllText(@"C:\Users\User\Downloads\input.txt");

            var markerLength = 4;
            var messageLength = 14;

            var firstMarker = GetFirstUniqueSequenceIndex(input, markerLength);
            var firstMessage = GetFirstUniqueSequenceIndex(input, messageLength);
            
            Console.WriteLine(firstMarker == - 1 ? "There was no marker." : firstMarker);
            Console.WriteLine(firstMessage == -1 ? "There was no message." : firstMessage);
        }

        private static int GetFirstUniqueSequenceIndex(string input, int sequenceLength)
        {
            var markerIndex = -1;

            for (int i = sequenceLength - 1; i < input.Length; i++)
            {
                var marker = input.Substring(i - (sequenceLength - 1), sequenceLength);

                if (AllUniqueCharacters(marker))
                {
                    markerIndex = i + 1;

                    return markerIndex;
                }
            }

            return markerIndex;
        }

        private static bool AllUniqueCharacters(string characters)
        {
            var result = true;

            for (int i = 0; i < characters.Length; i++)
            {
                for (int j = i + 1; j < characters.Length; j++)
                {
                    if (characters[i] == characters[j])
                    {
                        return false;
                    }
                }
            }

            return result;
        }
    }
}
