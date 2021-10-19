namespace PatternSingleton
{
    public class Key
    {
        public string Value { get; private set; }
        public Key(string value)
            => Value = value;
    }
}
