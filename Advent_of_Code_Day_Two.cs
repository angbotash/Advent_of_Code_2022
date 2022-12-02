namespace Advent_of_Code_Day_Two
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var input = File.ReadLines(@"C:\Users\User\Downloads\input.txt").ToArray();
            var myScorePartOne = 0;
            var myScorePartTwo = 0;

            foreach (var line in input)
            {
                myScorePartOne += GetMyScore(line[2]);
                myScorePartOne += GetMyRoundOutcomePartOne(line[0], line[2]);
                myScorePartTwo += GetMyRoundOutcomePartTwo(line[0], line[2]);
            }

            Console.WriteLine(myScorePartOne);
            Console.WriteLine(myScorePartTwo);
        }

        public static int GetMyScore(char input)
        {
            var score = 0;

            switch (input)
            {
                case 'X':
                    score += 1;
                    break;
                case 'Y':
                    score += 2;
                    break;
                case 'Z':
                    score += 3;
                    break;
            }

            return score;
        }

        public static int GetMyRoundOutcomePartOne(char elf, char me)
        {
            var score = 0;
            var rockRock = elf == 'A' && me == 'X';
            var rockPaper = elf == 'A' && me == 'Y';
            var rockScissors = elf == 'A' && me == 'Z';
            var paperPaper = elf == 'B' && me == 'Y';
            var paperRock = elf == 'B' && me == 'X';
            var paperScissors = elf == 'B' && me == 'Z';
            var scissorsScissors = elf == 'C' && me == 'Z';
            var scissorsRock = elf == 'C' && me == 'X';
            var scissorsPaper = elf == 'C' && me == 'Y';

            if (rockRock || paperPaper || scissorsScissors)
            {
                score = 3;
            }
            else if (rockPaper || paperScissors || scissorsRock)
            { 
                score = 6;
            }
            else if (rockScissors || paperRock || scissorsPaper)
            {
                score = 0;
            }

            return score;
        }

        public static int GetMyRoundOutcomePartTwo(char elf, char option)
        {
            var score = 0;
            var drawRock = elf == 'A' && option == 'Y';
            var winRock = elf == 'A' && option == 'Z';
            var loseRock = elf == 'A' && option == 'X';
            var drawPaper = elf == 'B' && option == 'Y';
            var winPaper = elf == 'B' && option == 'Z';
            var losePaper = elf == 'B' && option == 'X';
            var drawScissors = elf == 'C' && option == 'Y';
            var winScissors = elf == 'C' && option == 'Z';
            var loseScissors = elf == 'C' && option == 'X';

            if (drawRock)
            {
                score = 3 + GetMyScore('X');
            }
            else if (winRock)
            {
                score = 6 + GetMyScore('Y');
            }
            else if (loseRock)
            {
                score = GetMyScore('Z');
            }
            else if (drawPaper)
            {
                score = 3 + GetMyScore('Y');
            }
            else if (winPaper)
            {
                score = 6 + GetMyScore('Z');
            }
            else if (losePaper)
            {
                score = GetMyScore('X');
            }
            else if (drawScissors)
            {
                score = 3 + GetMyScore('Z');
            }
            else if (winScissors)
            {
                score = 6 + GetMyScore('X');
            }
            else if (loseScissors)
            {
                score = GetMyScore('Y');
            }

            return score;
        }
    }
}
