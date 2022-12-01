public class Program
{
    public static void Main(string[] args)
    {
        var array = File.ReadLines(@"C:\Users\User\Downloads\input.txt").ToArray();
        var elvesWithFood = CaloriesToList(array);
        var maxCalories = elvesWithFood.Max();

        elvesWithFood.Sort();

        var firstThreeElvesCalories = elvesWithFood[^1] + elvesWithFood[^2] + elvesWithFood[^3];

        Console.WriteLine(maxCalories);
        Console.WriteLine(firstThreeElvesCalories);
    }

    public static List<int> CaloriesToList(string[] calories)
    {
        var elves = new List<int>();
        var index = 0;
        var tempElf = 0;

        do
        {
            if (calories[index] == "")
            {
                elves.Add(tempElf);
                tempElf = 0;
                index++;
                continue;
            }

            if (index == calories.Length - 1)
            {
                var tempNum = int.Parse(calories[index]);
                tempElf += tempNum;
                elves.Add(tempElf);
                tempElf = 0;
                index++;
                continue;
            }

            var temp = int.Parse(calories[index]);
            tempElf += temp;
            index++;
        }
        while (index < calories.Length);

        return elves;
    }
}