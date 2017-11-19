namespace PerfectAbstraction
{
    public class Maybe<T>
    {
        private readonly bool hasValue = false;
        private readonly T value;
        public Maybe() { }
        public Maybe(T value)
        {
            hasValue = true;
            this.value = value;
        }
        public bool HasValue { get { return hasValue; } }
        public T Value { get { return value; } }
    }
}
