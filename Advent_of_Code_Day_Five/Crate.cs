using System.Collections;

namespace Advent_of_Code_Day_Five
{
    public class Crate : IEnumerable
    {
        public Stack<char> Supplies { get; set; }

        public Crate()
        {
            Supplies = new Stack<char>();
        }

        public Crate(char[] items)
        {
            Supplies = new Stack<char>(items);
        }

        public char LiftItem()
        {
            var item = Supplies.Pop();

            return item;
        }

        public void PutDownItem(char item)
        {
            Supplies.Push(item);
        }

        public IEnumerator GetEnumerator()
        {
            return Supplies.GetEnumerator();
        }
    }
}
