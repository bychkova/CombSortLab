namespace CombSortLib;
public class CombSort
{
    public int[] combSort(int[] array)
    {
        int gap = array.Length;

        bool isSorted = false;
        while (!isSorted || gap != 1)
        {

            if (gap > 1)
            {
                gap = gap * 10 / 13; // gap / 1.3
            }
            else
            {
                gap = 1;
            }

            isSorted = true;
            for (int i = gap; i < array.Length; i++)
            {
                if (array[i - gap] > array[i])
                {
                    int tmp = array[i];
                    array[i] = array[i - gap];
                    array[i - gap] = tmp;
                    isSorted = false;
                }
            }
        }
        return array;
    }
}

