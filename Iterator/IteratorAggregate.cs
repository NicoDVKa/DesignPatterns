

using System.Collections;

namespace Iterator
{
    abstract public class IteratorAggregate: IEnumerable
    {
        public abstract IEnumerator GetEnumerator();
    }
}
