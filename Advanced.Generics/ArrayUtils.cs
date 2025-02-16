namespace Advanced.Generics
{
    public static class ArrayUtils
    {
        public static void ReverseArray<T>(T[] array)
        {
            if (array == null || array.Length <= 1) return;

            int left = 0, right = array.Length - 1;
            while (left < right)
            {
                (array[left], array[right]) = (array[right], array[left]);
                left++;
                right--;
            }
        }

        public static T FindMax<T>(T[] array) where T : IComparable<T>
        {
            if (array == null || array.Length == 0)
                throw new ArgumentException("Array is null or empty");

            T max = array[0];
            foreach (T item in array)
            {
                if (item.CompareTo(max) > 0)
                {
                    max = item;
                }
            }
            return max;
        }
    }
}
