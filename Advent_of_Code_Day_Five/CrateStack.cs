using System.Collections;

namespace Advent_of_Code_Day_Five
{
    public class CrateStack : IEnumerable
    {
        public List<Crate> StackOfCrate { get; set; }

        public CrateStack()
        {
            this.StackOfCrate = new List<Crate>();
        }

        public void AddCrate(Crate crate)
        {
            this.StackOfCrate.Add(crate);
        }

        public void MoveCrates(int[] steps)
        {
            var from = steps[1] - 1;
            var to = steps[2] - 1;

            for (int i = 0; i < steps[0]; i++)
            {
                var temp = this.StackOfCrate[from].LiftItem();
                this.StackOfCrate[to].PutDownItem(temp);
            }
        }

        public void MoveCratesUpdated(int[] steps)
        {
            var from = steps[1] - 1;
            var to = steps[2] - 1;
            var tempStash = new char[steps[0]];

            for (int i = 0; i < steps[0]; i++)
            {
                tempStash[i] = this.StackOfCrate[from].LiftItem();
            }

            for (int i = tempStash.Length - 1; i >= 0; i--)
            {
                this.StackOfCrate[to].PutDownItem(tempStash[i]);
            }
        }

        public IEnumerator GetEnumerator()
        {
            return StackOfCrate.GetEnumerator();
        }

        public Crate this[int index]
        {
            get => this.StackOfCrate[index];
            set => this.StackOfCrate[index] = value;
        }
    }
}
