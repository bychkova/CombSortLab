namespace CombSortLib.Tests;

public class CombSortTests
{
    [Test]
    public void CombSort_PositiveNumbers()
    {
        int[] arrayToTest = new int[5] { 3, 5, 1, 7, 33 };
        int[] expected = new int[5] { 1, 3, 5, 7, 33 };

        CombSort test = new CombSort();
        int[] actual = test.combSort(arrayToTest);

        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void CombSort_NegativeNumbers()
    {
        int[] arrayToTest = new int[5] { -3, -5, -1, -7, -33 };
        int[] expected = new int[5] { -33, -7, -5, -3, -1 };

        CombSort test = new CombSort();
        int[] actual = test.combSort(arrayToTest);

        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void CombSort_NegativePositiveZero()
    {
        int[] arrayToTest = new int[5] { -14, 45, 0, 46, 3 };
        int[] expected = new int[5] { -14, 0, 3, 45, 46 };

        CombSort test = new CombSort();
        int[] actual = test.combSort(arrayToTest);

        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void CombSort_DubbleBottomBorder()
    {
        int[] arrayToTest = new int[6] { -14, -14, 45, 0, 46, 3 };
        int[] expected = new int[6] { -14, -14, 0, 3, 45, 46 };

        CombSort test = new CombSort();
        int[] actual = test.combSort(arrayToTest);

        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void BubbleSort_DubbleTopBorder()
    {
        int[] arrayToTest = new int[6] { -14, 46, 45, 0, 46, 3 };
        int[] expected = new int[6] { -14, 0, 3, 45, 46, 46 };

        CombSort test = new CombSort();
        int[] actual = test.combSort(arrayToTest);

        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void CombSort_DubbleInTheMiddle()
    {
        int[] arrayToTest = new int[6] { -14, 3, 45, 0, 46, 3 };
        int[] expected = new int[6] { -14, 0, 3, 3, 45, 46 };

        CombSort test = new CombSort();
        int[] actual = test.combSort(arrayToTest);

        Assert.AreEqual(expected, actual);
    }
}
