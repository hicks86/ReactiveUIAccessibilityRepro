namespace WpfAccessibility
{
    public class Fruit
    {
        public Fruit(int index, string value)
        {
            Index = index;
            Value = value;
        }

        public int Index { get; }
        public string Value { get; }

        public override string ToString()
        {
            return this.Value;
        }
    }
}