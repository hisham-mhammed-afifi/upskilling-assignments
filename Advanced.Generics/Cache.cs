namespace Advanced.Generics
{

    // LRU (Least Recently Used) cache, where the most recent items are always at the top, and old ones move down.
    public class Cache<TKey, TValue>
    {
        private int _capacity;
        private TKey[] _keys;
        private TValue[] _values;
        private int _size;

        public Cache(int capacity)
        {
            _capacity = capacity;
            _keys = new TKey[capacity];
            _values = new TValue[capacity];
            _size = 0;
        }

        public void Add(TKey key, TValue value)
        {
            int index = FindKeyIndex(key);

            if (index != -1) // If key exists, update it.
            {
                _values[index] = value;
                MoveToMostRecent(index);
            }
            else
            {
                if (_size < _capacity) // If it's not full, add.
                {
                    _keys[_size] = key;
                    _values[_size] = value;
                    _size++;
                }
                else // If it's full, remove the least recently used (first element)
                {
                    ShiftLeft();
                    _keys[_size - 1] = key;
                    _values[_size - 1] = value;
                }
            }
        }


        public TValue Get(TKey key)
        {
            int index = FindKeyIndex(key);

            if (index == -1)
                throw new Exception("Key not found in cache");

            TValue value = _values[index];
            MoveToMostRecent(index);
            return value;
        }


        public void Remove(TKey key)
        {
            int index = FindKeyIndex(key);

            if (index == -1)
            {
                Console.WriteLine("Key not found in cache");
                return;
            }

            ShiftLeft(index);

            _size--;
        }


        private int FindKeyIndex(TKey key)
        {
            for (int i = 0; i < _size; i++)
            {
                if (_keys[i].Equals(key))
                    return i;
            }
            return -1;
        }


        private void MoveToMostRecent(int index)
        {
            TKey key = _keys[index];
            TValue value = _values[index];

            ShiftLeft(index);

            _keys[_size - 1] = key;
            _values[_size - 1] = value;
        }


        private void ShiftLeft(int index = 0)
        {
            for (int i = index; i < _size - 1; i++)
            {
                _keys[i] = _keys[i + 1];
                _values[i] = _values[i + 1];
            }
        }


        public void DisplayCache()
        {
            Console.WriteLine("\nCache Display:");
            for (int i = _size - 1; i >= 0; i--)
            {
                Console.WriteLine($"{_keys[i]}: {_values[i]}");
            }
            Console.WriteLine("---");
        }
    }
}
