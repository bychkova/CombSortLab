namespace CombSortLib;
public class CombSort
{
    public int[] BubbleSort(int[] arrayToSort)
    {
        for (int i = 1; i < arrayToSort.Length; i++)
        {
            for (int j = 1; j < arrayToSort.Length; j++)
            {
                if (arrayToSort[j] < arrayToSort[j - 1])
                {
                    int temp = arrayToSort[j];
                    arrayToSort[j] = arrayToSort[j - 1];
                    arrayToSort[j - 1] = temp;
                }
            }
        }
        return arrayToSort;
    }
}

