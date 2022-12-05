namespace Advent_of_Code_Day_Three
{
    public static class Program
    {


        public static void Main()
        {
            var rucksacks = File.ReadLines(@"C:\Users\User\Downloads\input.txt").ToArray();

            var allPriorities = 0;

            foreach (var r in rucksacks)
            {
                var repeatedItem = GetRepeatedItem(r);
                allPriorities += GetItemPriority(repeatedItem);
            }

            var badgePriorities = 0;

            for (int i = 0; i < rucksacks.Length - 2; i += 3)
            {
                var badge = GetGroupBadge(rucksacks[i], rucksacks[i + 1], rucksacks[i + 2]);
                badgePriorities += GetItemPriority(badge);
            }

            Console.WriteLine(allPriorities);
            Console.WriteLine(badgePriorities);
        }

        private static char GetRepeatedItem(string rucksack)
        {
            var item = ' ';

            for (int i = 0; i < rucksack.Length / 2; i++)
            {
                for (int j = rucksack.Length - 1; j >= rucksack.Length / 2; j--)
                {
                    if (rucksack[i].Equals(rucksack[j]))
                    {
                        item = rucksack[i];
                        break;
                    }
                }
            }

            Console.WriteLine(item);

            return item;
        }

        private static int GetItemPriority(char item)
        {
            if (item.Equals(' '))
            {
                return 0;
            }

            var priority = ItemPriority[item];

            return priority;
        }

        private static char GetGroupBadge(string first, string second, string third)
        {
            var badge = ' ';

            foreach (var i in first)
            {
                if (second.Contains(i) && third.Contains(i))
                {
                    badge = i;
                    break;
                }
            }

            return badge;
        }

        private static readonly Dictionary<char, int> ItemPriority = new()
        {
            { 'a', 1 },
            { 'b', 2 },
            { 'c', 3 },
            { 'd', 4 },
            { 'e', 5 },
            { 'f', 6 },
            { 'g', 7 },
            { 'h', 8 },
            { 'i', 9 },
            { 'j', 10 },
            { 'k', 11 },
            { 'l', 12 },
            { 'm', 13 },
            { 'n', 14 },
            { 'o', 15 },
            { 'p', 16 },
            { 'q', 17 },
            { 'r', 18 },
            { 's', 19 },
            { 't', 20 },
            { 'u', 21 },
            { 'v', 22 },
            { 'w', 23 },
            { 'x', 24 },
            { 'y', 25 },
            { 'z', 26 },
            { 'A', 27 },
            { 'B', 28 },
            { 'C', 29 },
            { 'D', 30 },
            { 'E', 31 },
            { 'F', 32 },
            { 'G', 33 },
            { 'H', 34 },
            { 'I', 35 },
            { 'J', 36 },
            { 'K', 37 },
            { 'L', 38 },
            { 'M', 39 },
            { 'N', 40 },
            { 'O', 41 },
            { 'P', 42 },
            { 'Q', 43 },
            { 'R', 44 },
            { 'S', 45 },
            { 'T', 46 },
            { 'U', 47 },
            { 'V', 48 },
            { 'W', 49 },
            { 'X', 50 },
            { 'Y', 51 },
            { 'Z', 52 },
        };
    }
}

