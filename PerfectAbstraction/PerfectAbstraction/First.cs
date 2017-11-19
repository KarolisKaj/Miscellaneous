using System.Collections.Generic;
using System.Linq;

namespace PerfectAbstraction
{
    public class First<T> : Maybe<T>
    {
        public First() : base()
        {
        }
        public First(T value) : base(value)
        {
        }
        public First<T> TakeFirst(First<T> other)
        {
            return this.HasValue ? this : other;
        }
    }
    public static class First
    {
        public static First<T> Identity<T>()
        {
            return new First<T>();
        }
        public static First<T> Value<T>(IEnumerable<First<T>> values)
        {
            return values.Aggregate(new First<T>(), (seed, newValue) => seed.TakeFirst(newValue));
        }
    }
}
