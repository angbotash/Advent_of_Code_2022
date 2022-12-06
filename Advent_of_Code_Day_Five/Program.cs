namespace Advent_of_Code_Day_Five
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var steps = File.ReadLines("C:\\Users\\angbo\\Downloads\\input.txt").ToArray();
            var stacksOfCrates = new CrateStack();

            stacksOfCrates.AddCrate(new Crate(new[] { 'N', 'D', 'M', 'Q', 'B', 'P', 'Z' }));
            stacksOfCrates.AddCrate(new Crate(new[] { 'C', 'L', 'Z', 'Q', 'M', 'D', 'H', 'V' }));
            stacksOfCrates.AddCrate(new Crate(new[] { 'Q', 'H', 'R', 'D', 'V', 'F', 'Z', 'G' }));
            stacksOfCrates.AddCrate(new Crate(new[] { 'H', 'G', 'D', 'F', 'N' }));
            stacksOfCrates.AddCrate(new Crate(new[] { 'N', 'F', 'Q' }));
            stacksOfCrates.AddCrate(new Crate(new[] { 'D', 'Q', 'V', 'Z', 'F', 'B', 'T' }));
            stacksOfCrates.AddCrate(new Crate(new[] { 'Q', 'M', 'T', 'Z', 'D', 'V', 'S', 'H' }));
            stacksOfCrates.AddCrate(new Crate(new[] { 'M', 'G', 'F', 'P', 'N', 'Q' }));
            stacksOfCrates.AddCrate(new Crate(new[] { 'B', 'W', 'R', 'M' }));
            
            foreach (var s in steps)
            {
                var step = GetSteps(s);
                stacksOfCrates.MoveCrates(step);
            }

            var stacksOfCratesUpdated = new CrateStack();

            stacksOfCratesUpdated.AddCrate(new Crate(new[] { 'N', 'D', 'M', 'Q', 'B', 'P', 'Z' }));
            stacksOfCratesUpdated.AddCrate(new Crate(new[] { 'C', 'L', 'Z', 'Q', 'M', 'D', 'H', 'V' }));
            stacksOfCratesUpdated.AddCrate(new Crate(new[] { 'Q', 'H', 'R', 'D', 'V', 'F', 'Z', 'G' }));
            stacksOfCratesUpdated.AddCrate(new Crate(new[] { 'H', 'G', 'D', 'F', 'N' }));
            stacksOfCratesUpdated.AddCrate(new Crate(new[] { 'N', 'F', 'Q' }));
            stacksOfCratesUpdated.AddCrate(new Crate(new[] { 'D', 'Q', 'V', 'Z', 'F', 'B', 'T' }));
            stacksOfCratesUpdated.AddCrate(new Crate(new[] { 'Q', 'M', 'T', 'Z', 'D', 'V', 'S', 'H' }));
            stacksOfCratesUpdated.AddCrate(new Crate(new[] { 'M', 'G', 'F', 'P', 'N', 'Q' }));
            stacksOfCratesUpdated.AddCrate(new Crate(new[] { 'B', 'W', 'R', 'M' }));

            foreach (var s in steps)
            {
                var step = GetSteps(s);
                stacksOfCratesUpdated.MoveCratesUpdated(step);
            }
        }

        private static int[] GetSteps(string steps)
        {
            var result = new int[3];
            var separators = new[] { "move", "from", "to", " " };
            var separatedSteps = steps.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            result[0] = int.Parse(separatedSteps[0]);
            result[1] = int.Parse(separatedSteps[1]);
            result[2] = int.Parse(separatedSteps[2]);

            return result;
        }
    }
}